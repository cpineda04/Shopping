using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Shopping.Data.Entities
{
    public class State
    {
        public int Id { get; set; }

        [Display(Name = "Estados/Provincia")]
        [MaxLength(50, ErrorMessage = ("El campo {0} tiene un maximo de {1} caracteres."))]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public string Name { get; set; }
        public Country Country { get; set; }

        public ICollection<City> Cities { get; set; }

        [Display(Name = "Cuidades")]
        public int CitiesNumber => Cities == null ? 0 : Cities.Count;

        //[NotMapped]
        //public int CountryId { get; set; }
    }
}
