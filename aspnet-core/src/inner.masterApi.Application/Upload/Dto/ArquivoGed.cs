using inner.masterApi.Upload.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inner.masterApi.Upload.Dto
{
    public class ArquivoGed
    {
        [Required]
        public string chaveAcesso { get; set; }

        [Required]
        public int codigoEmpresaPrincipal { get; set; }
        [Required]
        public int codigoResponsavel { get; set; }

        [Required]
        public string codigoUsuario { get; set; }

        [Required]
        public byte[] arquivo{ get; set; }

        [Required]
        public int codigoGed { get; set; }

        [Required]
        public int codigoSequencialFicha { get; set; }

        [Required]
        public string codigoTipoGed { get; set; }

        [Required]
        public Extensao extensaoArquivo { get; set; }

        [Required]
        public Classificacao classificacao { get; set; }

        [Required]
        public string nomeArquivo { get; set; }

        public string nomeGed { get; set; }

        public string nomeTipoGed { get; set; }
        
        public bool sobreescreveArquivo { get; set; }

        public string codigoUnidadeGed { get; set; }
        
        public DateTime dataValidadeGed { get; set; }
        
        public string revisaoGed { get; set; }
        public string observacao { get; set; }


    }
}
