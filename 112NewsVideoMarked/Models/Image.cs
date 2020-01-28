using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace _112NewsVideoMarked.Models
{
	public class Image
	{
		[Key]
		public int ImageID { get; set; }

		[Display(Name = "Filnavn")]
		public string ImageName { get; set; }

		[Display(Name = "Sti")]
		public string ImagePath { get; set; }

		public int CaseContentID { get; set; }
		public CaseContent CaseContent { get; set; }
	}
}
