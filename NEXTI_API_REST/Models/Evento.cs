using System.ComponentModel.DataAnnotations.Schema;

namespace NEXTI_API_REST.Models
{
    public class Evento
    {
        public int Id { get; set; }
        public DateTime EventDate { get; set; }
        public string? EventLocation { get; set; }
        public string? EventDescription { get; set; }

        [Column(TypeName = "decimal(19,4)")]
        public decimal? Price { get; set; }
        public bool IsDeleted { get; set; } = false; // Eliminación lógica
    }
}
