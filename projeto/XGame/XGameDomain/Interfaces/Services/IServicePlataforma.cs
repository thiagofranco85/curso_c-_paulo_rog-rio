using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XGameDomain.Arguments.Plataforma;

namespace XGameDomain.Interfaces.Services
{
    interface IServicePlataforma
    {
        AdicionarPlataformaResponse AdicionarPlataforma( AdicionarPlataformaRequest request );
    }
}
