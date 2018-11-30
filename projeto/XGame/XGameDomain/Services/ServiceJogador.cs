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
            var jogador = new Jogador(request.Email, "222");
             
            jogador.Email = request.Email;
            jogador.Nome = request.Nome;
            jogador.Status = Enum.EnumSituacaoJogador.EmAndamento;

            Guid id = _repositoryJogador.AdicionarJogador(jogador);
            return new AdicionarJogadorResponse() { Id = id, Message = "Operação Realizada com sucesso!" };
        }

        public AutenticarJogadorResponse AutenticarJogador(AutenticarJogadorRequest request)
        {
            if( request == null)
            {
                AddNotification("AutenticarJogadorRequest", Message.X0_E_OBRIGATORIO.ToFormat("AutenticarJogadorRequest") );
            }
             
            var jogador = new Jogador(request.Email, request.Senha);

            AddNotifications( jogador );

            if( jogador.IsInvalid() )
            {
                return null;
            }
            return _repositoryJogador.AutenticarJogador(request);
        }

        private bool IsEmail(string email)
        {
           return false;
        }
    }
}
