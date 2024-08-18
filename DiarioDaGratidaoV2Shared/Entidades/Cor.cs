using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiarioDaGratidaoV2.Shared.Entidades
{
    public class Cor
    {
        public int Id { get; set; }
        [Required]

        public string Hexa { get; set; } = string.Empty;
    }
}
