using System.ComponentModel.DataAnnotations;

namespace RazorPagesPizza.Models;

    public class Soda
    {
        public int Id { get; set; }

        [Required]
        public string? Name { get; set; }
        public SodaSize Size { get; set; }
        public bool IsDiet { get; set; }

        [Range(0.01, 9999.99)]
        public decimal Price { get; set; }
    }

    public enum SodaSize { Small, Medium, Large }

