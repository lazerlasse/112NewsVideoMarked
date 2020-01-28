using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace _112NewsVideoMarked.Models
{
	public class FileUpload
	{
		[Display(Name = "Vælg fil")]
		public IFormFile VideoFile { get; set; }
	}
}
