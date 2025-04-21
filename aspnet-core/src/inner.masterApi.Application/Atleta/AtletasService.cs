using Abp.Domain.Repositories;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace inner.masterApi.Atleta
{
    public class AtletasService : IAtletasService
    {
        private readonly IRepository<Atleta> _atletaRepository;
        public AtletasService(IRepository<Atleta> atletaRepository)
        {
            _atletaRepository = atletaRepository;
        }
       
        public async Task<List<Atleta>> GetAll()
        {
            var atletas = _atletaRepository.GetAll().ToList();
            List<Atleta> result = new();
            foreach (var atletaDto in atletas)
            {
                result.Add(atletaDto);
            }

            return result;
        }

        public async Task<Atleta> Include(Atleta atleta)
        {
            Atleta result = new();

            var atletaInserted = _atletaRepository.Insert(atleta);

            if(atleta != null)
            {
                result = atletaInserted;
            }

            return result;
        }
    }
}
