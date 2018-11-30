using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XGameDomain.Interfaces.Services;
using XGameDomain.Services;

namespace XGame.AppConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iniciando...");
            var service = new ServiceJogador();
            Console.WriteLine("Instanciando objeto servicejogador...");
            AutenticarJogadorRequest request = new AutenticarJogadorRequest();
            request.Email = new XGameDomain.ValueObjects.Email("thiago@gmail.com");
            //request.Senha = "123456";

            var response = service.AutenticarJogador(request);
              
            Console.WriteLine("Serviço e valido? " +service.IsValid());
            /*
            service.Notifications.ToList().ForEach(x =>
            {
                Console.WriteLine(x.Message);
            });
            */
            Console.ReadKey();
        }
    }
}
