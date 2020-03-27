using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TP3REAL.Models;

namespace TP3REAL.Repositorios
{
    public class PessoaInfoRepositorio
    {
        public static List<PessoaInfoModel> Pessoas { get; set; } = new List<PessoaInfoModel>
        {
            new PessoaInfoModel
            {
                Id = 1,
                Nome = "teste",
                Sobrenome = "testando",
                DataDeNascimento = DateTime.Now

            }
        };
        
        public List<PessoaInfoModel> GetAll()
        {
            return Pessoas;
        }
        public PessoaInfoModel ProcurarId(int id)
        {
            var pessoa = Pessoas.FirstOrDefault(x => x.Id == id);

            return pessoa;  
        }

        public List<PessoaInfoModel> PesquisaNome(string nome)
        {
            var resultadoPesquisa = Pessoas.Where(x => x.Nome.Contains(nome, StringComparison.OrdinalIgnoreCase));
            
            return resultadoPesquisa.ToList();
                
        }

        public void Add(PessoaInfoModel novaPessoa)
        {
            Pessoas.Add(novaPessoa);
        }

        public void Atualizar(PessoaInfoModel editPessoa)
        {
            var pessoaOriginal = ProcurarId(editPessoa.Id);

            pessoaOriginal.Nome = editPessoa.Nome;
            pessoaOriginal.Sobrenome = editPessoa.Sobrenome;
            pessoaOriginal.DataDeNascimento = editPessoa.DataDeNascimento;
            
        }
     
        public void Delete(int id)
        {
            var pessoaDeletar = ProcurarId(id);

            Pessoas.Remove(pessoaDeletar);
           
        }


    }
}
