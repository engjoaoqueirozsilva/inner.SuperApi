using Abp.Application.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inner.masterApi.Modalidade
{
    public interface IModalidadeService : IApplicationService
    {
        Task<List<Modalidade>> GetAll();
    }
}
