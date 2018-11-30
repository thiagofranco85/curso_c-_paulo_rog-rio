using System;
using XGameDomain.Arguments.Jogador;
using XGameDomain.ValueObjects;

namespace XGameDomain.Interfaces.Services
{
    public interface IServiceJogador
    {
       AutenticarJogadorResponse AutenticarJogador( AutenticarJogadorRequest request );
       AdicionarJogadorResponse AdicionarJogador( AdicionarJogadorRequest request );
    }
}
