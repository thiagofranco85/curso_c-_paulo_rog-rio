using prmToolkit.NotificationPattern;
using prmToolkit.NotificationPattern.Extensions;
using System;
using XGameDomain.Arguments.Jogador;
using XGameDomain.Entities;
using XGameDomain.Interfaces.Repositories;
using XGameDomain.Interfaces.Services;
using XGameDomain.Resources;
using XGameDomain.ValueObjects;

namespace XGameDomain.Services
{
    public class ServiceJogador : Notifiable, IServiceJogador
    {
        private readonly IRepositoryJogador _repositoryJogador;

        public ServiceJogador(IRepositoryJogador repositoryJogador)
        {
            _repositoryJogador = repositoryJogador;
        }

        public ServiceJogador()
        {
        }

        public AdicionarJogadorResponse AdicionarJogador(AdicionarJogadorRequest request)
        {
            var nome = new Nome(request.PrimeiroNome, request.UltimoNome);
            var email = new Email(request.Email);

            var jogador = new Jogador(nome, email, request.Senha);
            
            if( this.IsInvalid())
            {
                return null;
            }

            //jogador = _repositoryJogador.AdicionarJogador(jogador);

            return new AdicionarJogadorResponse() { Id = Guid.NewGuid(), Message = "Operação Realizada com sucesso!" };
        }

        public AutenticarJogadorResponse AutenticarJogador(AutenticarJogadorRequest request)
        {
            if( request == null)
            {
                AddNotification("AutenticarJogadorRequest", Message.X0_E_OBRIGATORIO.ToFormat("AutenticarJogadorRequest") );
            }

            var email = new Email(request.Email); 

            var jogador = new Jogador( email, request.Senha);

            AddNotifications( jogador );

            if( jogador.IsInvalid() )
            {
                return null;
            }
            jogador =  _repositoryJogador.AutenticarJogador(request);
            /*
            AutenticarJogadorResponse response = new AutenticarJogadorResponse();
            response.Email = jogador.Email.Endereco;
            response.PrimeiroNome = jogador.Nome.PrimeiroNome;
            response.Status = (int) jogador.Status;
            */
            return (AutenticarJogadorResponse) jogador;
        }

        private bool IsEmail(string email)
        {
           return false;
        }
    }
}
