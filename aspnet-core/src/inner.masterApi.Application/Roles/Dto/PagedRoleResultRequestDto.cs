using Abp.Application.Services.Dto;

namespace inner.masterApi.Roles.Dto
{
    public class PagedRoleResultRequestDto : PagedResultRequestDto
    {
        public string Keyword { get; set; }
    }
}

