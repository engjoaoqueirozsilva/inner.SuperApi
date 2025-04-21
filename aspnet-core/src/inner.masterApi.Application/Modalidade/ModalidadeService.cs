using Abp.Domain.Repositories;
using inner.masterApi.Modalidade.Dto;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace inner.masterApi.Modalidade
{
    public class ModalidadeService : IModalidadeService
    {
        private readonly IRepository<Modalidade> _modalidadeRepository;
        public ModalidadeService(IRepository<Modalidade> modalidadeRepository)
        {
            _modalidadeRepository = modalidadeRepository;
        }

        public async Task<List<Modalidade>> GetAll()
        {
            var modalidades = _modalidadeRepository.GetAll().ToList();
            List<Modalidade> result = new();
            foreach (var modalidadeDto in modalidades)
            {
                result.Add(modalidadeDto);
            }

            return result;
        }

        public async Task<Modalidade> Insert(CrateModalidadeDto createModalidadeDto)
        {
            var teste = await _modalidadeRepository.InsertOrUpdateAsync(new Modalidade
            {
                NomeModalidade = createModalidadeDto.NomeModalidade,
                RespTecnico = createModalidadeDto.RespTecnico,
                AuxTecnico = createModalidadeDto.AuxTecnico,
                Obs = createModalidadeDto.Obs,
                CreationTime = createModalidadeDto.CreationTime
            });

            return teste;
        }
    }
}
