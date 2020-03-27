using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TP3REAL.Models
{
    public class PessoaInfoModel
    {
        public int Id { get; set; }
        public string Nome { get; set; }
       
        public string Sobrenome { get; set; }

        public DateTime DataDeNascimento  { get; set; }
    }
}
