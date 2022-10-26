using System.ComponentModel.DataAnnotations;

namespace ProjektObsługaOperacjiKont.Models
{
    public class TypDigitalCurrency
    {
        public int IdTypJednostki { get; set; }
        [Required(ErrorMessage ="Wpisz nazwę waluty")]
        public string NazwaTypu { get; set; }

        public int UserId { get; set; }
    }
}
