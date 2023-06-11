using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SudeProje.Models
{
	public class Admin
	{
		[Key]
		public int AdminID { get; set; }
		public string Mail { get; set; }
		public string Sifre { get; set; }
	}
}
