using Abp.Application.Services;
using Abp.Application.Services.Dto;
using inner.masterApi.Tarefa.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inner.masterApi.Tarefa
{
    public interface ITarefasService : IApplicationService
    {
        Task<List<Tarefa>> GetAll();
    }
}
