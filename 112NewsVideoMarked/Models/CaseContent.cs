using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace _112NewsVideoMarked.Models
{
	public class CaseContent
	{
		public int CaseContentID { get; set; }

		[Display(Name = "Fotograf")]
		public string Photographer { get; set; }

		[Required]
		[Display(Name = "Overskrift")]
		public string Title { get; set; }

		[Required]
		[Display(Name = "Beskrivelse")]
		public string Description { get; set; }

		[Required]
		[Display(Name = "Vejnavn")]
		public string Street { get; set; }

		[Required]
		[Display(Name = "By")]
		public string Town { get; set; }

		[Required]
		[Display(Name = "Postnummer")]
		public int PostalCode { get; set; }

		[Display(Name = "Oprettet")]
		public DateTime Published { get; set; } = DateTime.Now;

		// Navigation property for CaseOwnerID from AspNetUser table...
		public string OwnerID { get; set; }

		// Navigation property for video content...
		public ICollection<Video> Videos { get; set; }

		// Navigation property for image content...
		public ICollection<Image> Images { get; set; }
	}
}
