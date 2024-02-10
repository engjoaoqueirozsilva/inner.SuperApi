using Abp.Domain.Entities;
using Abp.Timing;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace inner.masterApi.Treino
{
    [Table("Treino")]
    public class Treino : Entity
    {
        [Required]
        [StringLength(150)]
        public string NomeTreino { get; set; }
        [Required]
        public string ModalidadeTreino { get; set; }
        public string Fundamento1 { get; set; }
        public string Fundamento2 { get; set; }
        public string Fundamento3 { get; set; }
        public string Fundamento4 { get; set; }
        public string Fundamento5 { get; set; }
        public string Fundamento6 { get; set; }
        public DateTime CreationTime { get; set; }

        public Treino()
        {
            CreationTime = Clock.Now;
        }
    }
}
