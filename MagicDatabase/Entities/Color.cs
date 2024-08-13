using System.ComponentModel.DataAnnotations;

namespace MagicDatabaseUI.Entities
{
	public class Color
	{
		[Key]
		public int Id { get; set; }

		[Required]
		[MaxLength(10)]
		public string Name { get; set; }

		public virtual ICollection<Card> Cards { get; set; }
	}
}
