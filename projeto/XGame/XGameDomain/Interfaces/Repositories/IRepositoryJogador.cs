using System;
using XGameDomain.Entities;
using XGameDomain.Interfaces.Services;

namespace XGameDomain.Interfaces.Repositories
{
    public interface IRepositoryJogador
    {
        AutenticarJogadorResponse AutenticarJogador(AutenticarJogadorRequest request);
        Guid AdicionarJogador(Jogador jogador);
    }
}
