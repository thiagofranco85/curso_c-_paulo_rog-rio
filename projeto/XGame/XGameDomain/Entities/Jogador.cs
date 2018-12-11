using prmToolkit.NotificationPattern;
using prmToolkit.NotificationPattern.Extensions;
using System;
using XGameDomain.Enum;
using XGameDomain.Resources;
using XGameDomain.ValueObjects;

namespace XGameDomain.Entities
{
    public class Jogador : Notifiable
    { 
        public Jogador(Nome nome, Email email, string senha)
        {
            Id = Guid.NewGuid();
            Nome = nome;
            Email = email;
            Senha = senha;
            Status = EnumSituacaoJogador.EmAnalise;

            new AddNotifications<Jogador>(this)
               .IfNotEmail(x => x.Email.Endereco, "Informe um email válido!")
               .IfNullOrInvalidLength(x => x.Senha, 6, 32, Message.X0_OBRIGATORIO_DEVE_CONTER_ENTRE_X1_E_X2_CARACTERES.ToFormat("Último Nome", "3", "50"));

        }

        public Jogador(  Email email, string senha)
        {
            Id = Guid.NewGuid(); 
            Email = email;
            Senha = senha;
            Status = EnumSituacaoJogador.EmAnalise;

            new AddNotifications<Jogador>(this)
               .IfNotEmail(x => x.Email.Endereco, "Informe um email válido!")
               .IfNullOrInvalidLength(x => x.Senha, 6, 32, Message.X0_OBRIGATORIO_DEVE_CONTER_ENTRE_X1_E_X2_CARACTERES.ToFormat("Último Nome", "3", "50"));

        }

        public Guid Id { get; private set; }
        public Nome  Nome { get; private set; } 
        public Email Email { get; private set; }
        public string Senha { get; private set; }
        public EnumSituacaoJogador Status { get; private set; }
    }
}
