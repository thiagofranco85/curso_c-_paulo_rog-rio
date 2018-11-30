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
    public class Email : Notifiable
    {         
        public string Endereco { get; private set; }

        public Email(string endereco)
        {
            Endereco = endereco;

            new AddNotifications<Email>(this).IfNotEmail( x => x.Endereco, Message.X0_INVALIDO.ToFormat("Email") );
        }

    }
}
