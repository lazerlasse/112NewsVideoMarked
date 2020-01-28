using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _112NewsVideoMarked.Utillities
{
	public class MediaValidator
	{
		private const int ImageMinimumBytes = 512;

		public static bool ValidateMediaFile(IFormFile postedFile)
		{
			//-------------------------------------------
			//  Check the accepted mime types
			//-------------------------------------------
			if (postedFile.ContentType.ToLower() != "image/jpg" &&
						postedFile.ContentType.ToLower() != "image/jpeg" &&
						postedFile.ContentType.ToLower() != "video/mp4" &&
						postedFile.ContentType.ToLower() != "video/avi" &&
						postedFile.ContentType.ToLower() != "video/mpeg" &&
						postedFile.ContentType.ToLower() != "video/mpg")
			{
				return false;
			}

			//-------------------------------------------
			//  Check the accepted file extension
			//-------------------------------------------
			if (Path.GetExtension(postedFile.FileName).ToLower() != ".jpg"
				&& Path.GetExtension(postedFile.FileName).ToLower() != ".jpeg"
				&& Path.GetExtension(postedFile.FileName).ToLower() != ".mp4"
				&& Path.GetExtension(postedFile.FileName).ToLower() != ".mpeg"
				&& Path.GetExtension(postedFile.FileName).ToLower() != "mpg"
				&& Path.GetExtension(postedFile.FileName).ToLower() != "avi")
			{
				return false;
			}

			//-------------------------------------------
			//  Attempt to read the file and check the first bytes
			//-------------------------------------------
			try
			{
				// Try reading the file.
				if (!postedFile.OpenReadStream().CanRead)
				{
					return false;
				}

				//------------------------------------------
				//check whether the file size exceeding the limit or not
				//------------------------------------------ 
				if (postedFile.Length < ImageMinimumBytes)
				{
					return false;
				}

				byte[] buffer = new byte[ImageMinimumBytes];
				postedFile.OpenReadStream().Read(buffer, 0, ImageMinimumBytes);
				string content = System.Text.Encoding.UTF8.GetString(buffer);
				if (Regex.IsMatch(content, @"<script|<html|<head|<title|<body|<pre|<table|<a\s+href|<img|<plaintext|<cross\-domain\-policy",
					RegexOptions.IgnoreCase | RegexOptions.CultureInvariant | RegexOptions.Multiline))
				{
					return false;
				}
			}
			catch (Exception)
			{
				return false;
			}

			// If the test has passed return true.
			return true;
		}
	}
}
