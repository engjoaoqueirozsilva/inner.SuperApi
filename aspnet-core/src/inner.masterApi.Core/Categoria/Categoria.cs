using Abp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inner.masterApi.Categoria
{
    [Table("Categoria")]
    public class Categoria : Entity
    {
        [Required]
        [StringLength(150)]
        public string NomeCategoria { get; set; }

        public int LimiteIdade { get; set; }

        public int Modalidade { get; set; }
    }
}
