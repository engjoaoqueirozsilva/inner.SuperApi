using Abp.Domain.Repositories;
using inner.masterApi.Treino.Dto;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
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

        public async Task<Treino> Insert(CreateTreinoDto createTreinoDto)
        {
            var teste = await _taskRepository.InsertOrUpdateAsync(new Treino
            {   
                NomeTreino = createTreinoDto.NomeTreino,
                ModalidadeTreino = createTreinoDto.ModalidadeTreino,
                Fundamento1 = createTreinoDto.Fundamento1,
                Fundamento2 = createTreinoDto.Fundamento2,
                Fundamento3 = createTreinoDto.Fundamento3,
                Fundamento4 = createTreinoDto.Fundamento4,
                Fundamento5 = createTreinoDto.Fundamento5,
                Fundamento6 = createTreinoDto.Fundamento6
            });

            return teste;
        }
    }
}
