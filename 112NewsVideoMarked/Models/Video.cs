using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace _112NewsVideoMarked.Models
{
	public class Video
	{
		[Key]
		public int VideoID { get; set; }

		[Display(Name = "Filnavn")]
		public string VideoName { get; set; }

		[Display(Name = "Sti")]
		public string VideoPath { get; set; }

		public int CaseContentID { get; set; }
		public CaseContent CaseContent { get; set; }
	}
}
