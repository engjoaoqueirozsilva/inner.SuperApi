using Abp.Domain.Repositories;
using System.Collections.Generic;
using System.Linq;
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
