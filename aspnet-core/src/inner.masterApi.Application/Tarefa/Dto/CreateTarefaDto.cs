using Abp.AutoMapper;
using Abp.Runtime.Validation;
using System;
using System.ComponentModel.DataAnnotations;

namespace inner.masterApi.Tarefa.Dto
{
    [AutoMapTo(typeof(Tarefa))]
    public class CreateTarefaDto : IShouldNormalize
    {
        [Required]
        [StringLength(5000)]
        public string Titulo { get; set; }
        [Required]
        [StringLength(5000)]
        public string Descricao { get; set; }
        public DateTime CreationTime { get; set; }
        public byte State { get; set; }
        public void Normalize()
        {
        }
    }
}
