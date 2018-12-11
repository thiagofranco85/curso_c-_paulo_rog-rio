using prmToolkit.NotificationPattern;
using prmToolkit.NotificationPattern.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XGameDomain.Resources;

namespace XGameDomain.ValueObjects
{
    public class Nome : Notifiable
    {
        public Nome(string primeiroNome, string ultimoNome)
        {
            PrimeiroNome = primeiroNome;
            UltimoNome = ultimoNome;

            new AddNotifications<Nome>(this) 
              .IfNullOrInvalidLength(x => x.PrimeiroNome, 6, 50, Message.X0_OBRIGATORIO_DEVE_CONTER_ENTRE_X1_E_X2_CARACTERES.ToFormat("Primeiro Nome", "3", "50"))
              .IfNullOrInvalidLength(x => x.UltimoNome, 6, 50, Message.X0_OBRIGATORIO_DEVE_CONTER_ENTRE_X1_E_X2_CARACTERES.ToFormat("Último Nome", "3", "50"));

        }

        public string PrimeiroNome { get; private set; }
        public string UltimoNome { get; private set; }
    }
}
