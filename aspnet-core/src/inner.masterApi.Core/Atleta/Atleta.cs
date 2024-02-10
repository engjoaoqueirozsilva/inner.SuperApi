using Abp.Domain.Entities;
using Abp.Timing;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inner.masterApi.Atleta
{
    [Table("Atleta")]
    public class Atleta : Entity
    {
        [Required]
        [StringLength(150)]
        public string NomeAtleta { get; set; }
        [Required]
        [StringLength(100)]
        public string Email { get; set; }
        public string Telefone{ get; set; }
        public string PosicaoPreferencial{ get; set; }
        public string PosicaoSecundaria { get; set; }
        [Required]
        public int Modalidade { get; set; }
        public string RG { get; set; }
        public string Endereço { get; set; }
        public string Cidade{ get; set; }
        public string Estado{ get; set; }
        public string CEP { get; set; }
        public string ContatoEmergencia { get; set; }
        public string Obs { get; set; }
        public DateTime CreationTime { get; set; }

        public Atleta()
        {
            CreationTime = Clock.Now;
        }
    }
}
