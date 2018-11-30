using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XGameDomain.Interfaces.Arguments;

namespace XGameDomain.Arguments.Plataforma
{
    public class AdicionarPlataformaRequest : IRequest
    {
        public string Nome { get; set; }
    }
}
