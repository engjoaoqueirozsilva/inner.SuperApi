using Abp.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inner.masterApi.Treino
{
    public class TreinoService : ITreinoService
    {
        private readonly IRepository<Treino> _taskRepository;
        public TreinoService(IRepository<Treino> taskRepository)
        {
            _taskRepository = taskRepository;
        }

        public async Task<List<Treino>> GetAll()
        {
            var treinos = _taskRepository.GetAll().ToList();
            List<Treino> result = new();
            foreach (var treinoDto in treinos)
            {
                result.Add(treinoDto);
            }

            return result;
        }
    }
}
