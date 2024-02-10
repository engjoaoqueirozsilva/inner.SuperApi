using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using inner.masterApi.Authorization.Users;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using inner.masterApi.Tarefa;

namespace inner.masterApi.Tarefa.Dto
{
    [AutoMapFrom(typeof(Tarefa))]
    public class TarefaDto: EntityDto<long>
    {
        [Required]
        [StringLength(5000)]
        public string Titulo { get; set; }
        [Required]
        [StringLength(5000)]
        public string Descricao { get; set; }
        public DateTime CreationTime { get; set; }
        public byte State { get; set; }
    }
}
