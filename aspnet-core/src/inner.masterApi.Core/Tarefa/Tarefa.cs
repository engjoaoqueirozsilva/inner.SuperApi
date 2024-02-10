using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using Abp.Timing;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inner.masterApi.Tarefa
{
    [Table("Tarefas")]
    public class Tarefa : Entity
    {
        [Required]
        [StringLength(5000)]
        public string Titulo { get; set; }
        [Required]
        [StringLength(5000)]
        public string Descricao { get; set; }
        public DateTime CreationTime { get; set; }
        public TaskState State { get; set; }

        public Tarefa()
        {
            CreationTime = Clock.Now;
            State = TaskState.Open;    

        }

        public enum TaskState : byte
        {
            Open = 0,
            Completed = 1
        }

        public bool IsTransient()
        {
            throw new NotImplementedException();
        }
    }
}
