using Abp.Application.Services;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace inner.masterApi.Treino
{
    public interface ITreinoService : IApplicationService
    {
        Task<List<Treino>> GetAll();
    }
}
