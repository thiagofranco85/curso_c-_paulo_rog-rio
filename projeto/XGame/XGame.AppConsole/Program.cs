using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XGameDomain.Arguments.Jogador;
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

            AutenticarJogadorRequest autenticarRequest = new AutenticarJogadorRequest();
            Console.WriteLine("Criei minha instancia do objeto request...");
            autenticarRequest.Email =  "thiago@gmail.com";
            autenticarRequest.Senha = "123456";

            var request = new AdicionarJogadorRequest()
            {
                Email = "thiago@gmail.com",
                PrimeiroNome = "Thiago",
                UltimoNome = "Franco",
                Senha = "123456"
            };
            var response = service.AutenticarJogador(autenticarRequest);

            var response2 = service.AdicionarJogador(request);

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
