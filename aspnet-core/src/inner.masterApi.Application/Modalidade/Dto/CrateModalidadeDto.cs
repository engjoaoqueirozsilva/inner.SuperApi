using System;
using System.ComponentModel.DataAnnotations;

namespace inner.masterApi.Modalidade.Dto
{
    public class CrateModalidadeDto
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
       
    }
}
