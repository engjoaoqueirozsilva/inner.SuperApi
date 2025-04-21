using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inner.masterApi.Atleta.DTO
{
    [AutoMapFrom(typeof(Atleta))]
    public class AtletaDTO : EntityDto<long>
    {
        public string NomeAtleta { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public string PosicaoPreferencial { get; set; }
        public string PosicaoSecundaria { get; set; }
        public int Modalidade { get; set; }
        public string RG { get; set; }
        public string Endereço { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string CEP { get; set; }
        public string ContatoEmergencia { get; set; }
        public string Obs { get; set; }
        public DateTime CreationTime { get; set; }
    }
}