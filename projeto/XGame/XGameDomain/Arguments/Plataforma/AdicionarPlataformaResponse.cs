using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XGameDomain.Interfaces.Arguments;

namespace XGameDomain.Arguments.Plataforma
{
    class AdicionarPlataformaResponse : IResponse
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public string Message { get; set; }
    }
}
