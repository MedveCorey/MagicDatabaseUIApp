using System.ComponentModel.DataAnnotations;
using System.Drawing;

namespace MagicDatabaseUI.Entities
{
	public class Card
	{
		[Key]
		public int Id { get; set; }
		[Required]
		[MaxLength(100)]
		public string Name { get; set; }

		[MaxLength(50)]
		public string ManaCost { get; set; }
		public int? ManaValue{ get; set; }

		[MaxLength(50)]
		public string Type { get; set; }

		[MaxLength(50)]
		public string Subtype { get; set; }

		[MaxLength(1000)]
		public string Text { get; set; }

		// Power and toughness (for creatures)
		public string? Power { get; set; }
		public string? Toughness { get; set; }

		[MaxLength(50)]
		public string Rarity { get; set; }

		[MaxLength(50)]
		public string Set { get; set; }

		[MaxLength(50)]
		public string Artist { get; set; }
		public int Quantity { get; set; }
		public bool IsFoil { get; set; }
		public decimal? Price { get; set; }
		public int? Loyalty { get; set; }

		public virtual ICollection<Color> Colors { get; set; }

	}
}
