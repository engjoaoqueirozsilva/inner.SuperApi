using Abp.Runtime.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inner.masterApi.Treino.Dto
{
    public class CreateTreinoDto : IShouldNormalize
    {
        [Required]
        [StringLength(150)]
        public string NomeTreino { get; set; }
        [Required]
        [StringLength(100)]
        public string ModalidadeTreino { get; set; }

        public string Fundamento1 { get; set; }
        public string Fundamento2 { get; set; }
        public string Fundamento3 { get; set; }
        public string Fundamento4 { get; set; }
        public string Fundamento5 { get; set; }
        public string Fundamento6 { get; set; }
        public DateTime CreationTime { get; set; }

        public void Normalize()
        {
            throw new NotImplementedException();
        }
    }
}
