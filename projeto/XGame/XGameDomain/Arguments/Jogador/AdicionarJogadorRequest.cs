using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XGameDomain.Interfaces.Arguments;
using XGameDomain.ValueObjects;

namespace XGameDomain.Arguments.Jogador
{
    public class AdicionarJogadorRequest : IRequest
    {
         
        public string Email { get; set; }
        public string Senha { get; set; }
        public string PrimeiroNome { get; set; }
        public string UltimoNome { get; set; }
    }
}
