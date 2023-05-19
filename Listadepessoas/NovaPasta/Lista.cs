using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listadepessoas.NovaPasta
{
    internal class Lista
    {
        public int Id { get; set; }
        public String? nomeList { get; set; }
        public string nome { get; set; }
        public string? sobrenome { get; }
        public DateTime datanascimento
        {
            get; set;
        }
        public string? email { get; set; }
        public string? cpf { get; set; }
        public string? fone { get; set; }
        public string? sexo { get; set; }
        public string? estadocivil { get; set; }
        public string? hobbie { get; set; }
        public string? idade { get; set; }

        
            
    }
}
