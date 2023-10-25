using System.ComponentModel.DataAnnotations;

namespace Examen.Models
{
    public class AnthonyRodriguez_tabla1
    {
        public int arCedula { get; set; }
        [Required]
        public string? arNombre { get; set; }
        public bool arEstudiante { get; set; }
        [Range(1.00 , 3.00)]
        public decimal arEstatura { get; set; }

        DateTime fechaActual = new DateTime(2023, 10, 25, 7, 32, 00);
    }
}
