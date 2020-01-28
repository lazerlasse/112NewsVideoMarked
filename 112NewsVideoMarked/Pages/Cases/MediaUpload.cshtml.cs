using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _112NewsVideoMarked.Data;
using _112NewsVideoMarked.Models;
using _112NewsVideoMarked.Utillities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace _112NewsVideoMarked.Pages.Cases
{
    public class MediaUploadModel : PageModel
    {
		private readonly ApplicationDbContext _context;

		public MediaUploadModel(ApplicationDbContext context)
		{
			_context = context;
		}

		// Content properties...
		[BindProperty]
		public FileUpload FileUpload { get; set; }
		public CaseContent CaseContent { get; set; }

		// OnGet method...
		public async Task<IActionResult> OnGetAsync(int? id)
		{
			if (id == null)
			{
				return NotFound();
			}

			// Load CaseContent from DB...
			CaseContent = await _context.CaseContent
				.Include(i => i.Images)
				.Include(v => v.Videos)
					.AsNoTracking().FirstOrDefaultAsync(i => i.CaseContentID == id);

			// Check loaded content not null...
			if (CaseContent == null)
			{
				return NotFound();
			}

			return Page();
		}

		// OnPost method...
		public async Task<IActionResult> OnPostUploadAsync(int? id)
		{
			// Check if id not null...
			if (id == null)
			{
				return NotFound();
			}

			// Perform an initial check to catch FileUpload class attribute violations.
			if (!ModelState.IsValid)
			{
				return Page();
			}

			// Try validate the uploaded file...
			if (!MediaValidator.ValidateMediaFile(FileUpload.VideoFile))
			{
				return RedirectToPage("./Upload", new { id });
			}

			// Generate physical path for files...
			string contentPath = "/Cases/" + id + "/";

			// Save Files to case folder...
			SaveUpload saveUpload = new SaveUpload();
			await saveUpload.SaveUploadedFile(FileUpload.VideoFile, id.Value);

			// Create new Image object if file are Image file and save context...
			if (saveUpload.FileExtension == ".jpg" || saveUpload.FileExtension == ".jpeg")
			{
				// Create object to save...
				Image image = new Image()
				{
					ImageName = System.IO.Path.GetFileNameWithoutExtension(FileUpload.VideoFile.FileName),
					ImagePath = System.IO.Path.Combine(contentPath, FileUpload.VideoFile.FileName),
					CaseContentID = id.Value
				};

				_context.Image.Add(image);
				await _context.SaveChangesAsync();
			}

			// Create new Video object if the file are Video file and save context...
			if (saveUpload.FileExtension == ".mp4" || saveUpload.FileExtension == ".mpeg"
				|| saveUpload.FileExtension == ".mpg" || saveUpload.FileExtension == ".avi")
			{
				// Create object to save...
				Video video = new Video()
				{
					VideoName = System.IO.Path.GetFileNameWithoutExtension(FileUpload.VideoFile.FileName),
					VideoPath = contentPath + FileUpload.VideoFile.FileName,
					CaseContentID = id.Value
				};

				// Save content to the database...
				_context.Video.Add(video);
				await _context.SaveChangesAsync();

				// Generate Thumbnails from video...
				IList<Image> imageFiles = GenerateThumbnailFromVideo.GenerateThumbs(saveUpload.FullFilePath, saveUpload.CaseContentFolder, id.Value, contentPath);

				// Save generated image to the database...
				if (imageFiles != null)
				{
					foreach (Image image in imageFiles)
					{
						_context.Image.Add(image);
					}

					await _context.SaveChangesAsync();
				}
			}

			return RedirectToPage("./MediaUpload", id);
		}

		// OnGet deleting video from the case...
		public async Task<IActionResult> OnGetDeleteVideoAsync(int? videoId, int? caseContentId)
		{
			// Initial check if videoId not null...
			if (videoId == null)
			{
				return NotFound();
			}

			// Get video from database...
			Video video = await _context.Video
				.AsNoTracking()
				.FirstOrDefaultAsync(v => v.VideoID == videoId);

			// Check the video object not null...
			if (video == null)
			{
				return NotFound();
			}

			// Save changes to database...
			_context.Video.Remove(video);
			await _context.SaveChangesAsync();

			// Load content and update the page...
			CaseContent = await _context.CaseContent
				.Include(i => i.Images)
				.Include(v => v.Videos)
					.AsNoTracking().FirstOrDefaultAsync(i => i.CaseContentID == caseContentId);

			// Check content not null...
			if (CaseContent == null)
			{
				return NotFound();
			}
			return Page();
		}


		// OnGet deleting image from the case...
		public async Task<IActionResult> OnGetDeleteImageAsync(int? imageId, int? caseContentId)
		{
			// Check ID not null...
			if (imageId == null)
			{
				return NotFound();
			}

			// Find the image from id...
			Image image = await _context.Image
				.AsNoTracking()
				.FirstOrDefaultAsync(i => i.ImageID == imageId);

			// Check image not null...
			if (image == null)
			{
				return NotFound();
			}

			// Delete image from disk...
			bool deleted = MediaFileHandler.DeleteMediaFile(image.ImagePath);

			// check that the file is deleted....
			if (deleted == true)
			{
				// If succes remove the image from database...
				_context.Image.Remove(image);
				await _context.SaveChangesAsync();
			}

			// Load content and update the page...
			CaseContent = await _context.CaseContent
				.Include(i => i.Images)
				.Include(v => v.Videos)
					.AsNoTracking().FirstOrDefaultAsync(i => i.CaseContentID == caseContentId);

			// Check content not null...
			if (CaseContent == null)
			{
				return NotFound();
			}
			return Page();
		}
	}
}