using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Abp.Authorization;
using Abp.Domain.Repositories;
using Abp.ObjectMapping;
using Abp.Runtime.Session;
using AutoMapper;
using inner.masterApi.Authorization;
using inner.masterApi.Authorization.Roles;
using inner.masterApi.Authorization.Users;
using inner.masterApi.Tarefa.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inner.masterApi.Tarefa
{
    
    public class TarefasService : ITarefasService
    {

        private readonly IRepository<Tarefa> _taskRepository;
        public TarefasService(IRepository<Tarefa> taskRepository)
        {
            _taskRepository = taskRepository;
        }
        public async Task<List<Tarefa>> GetAll()
        {
            var tarefas = _taskRepository.GetAll().ToList();
            List<Tarefa> result = new();
            foreach (var tarefaDto in tarefas)
            {
                result.Add(tarefaDto);
            }

            return result;
        }
    }
}
