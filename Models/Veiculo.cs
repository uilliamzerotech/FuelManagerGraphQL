﻿using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace FuelManagerGraphQL.Models
{
    [Table("Veiculos")]
    public class Veiculo
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Marca { get; set; }
        [Required]
        public string Modelo { get; set; }
        [Required]
        public string Placa { get; set; }
        [Required]
        public int AnoFabricacao { get; set; }
        [Required]
        public int AnoModelo { get; set; }

        public ICollection<Consumo>? Consumos { get; set; }
    }
}
