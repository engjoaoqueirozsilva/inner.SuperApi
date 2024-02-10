using Abp.Domain.Entities;
using Abp.Timing;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inner.masterApi.Modalidade
{
    [Table("Modalidade")]
    public class Modalidade : Entity
    {
        [Required]
        [StringLength(150)]
        public string NomeModalidade { get; set; }
        [Required]
        [StringLength(100)]
        public string RespTecnico { get; set; }
        public string AuxTecnico { get; set; }
        public string Obs { get; set; }
        public DateTime CreationTime { get; set; }

        public Modalidade()
        {
            CreationTime = Clock.Now;
        }
    }
}
