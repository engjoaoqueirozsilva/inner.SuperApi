using Abp.Application.Services;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace inner.masterApi.Atleta
{
    public interface IAtletasService : IApplicationService
    {
        Task<List<Atleta>> GetAll();
    }
}
