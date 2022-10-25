﻿using System.ComponentModel.DataAnnotations;

namespace Shopping.Models
{
    public class StateViewModel
    {
        public int Id { get; set; }

        [Display(Name = "Estados/Provincia")]
        [MaxLength(50, ErrorMessage = ("El campo {0} tiene un maximo de {1} caracteres."))]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public string Name { get; set; }

        public int CountryId { get; set; }
    }
}
