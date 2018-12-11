using System;
using XGameDomain.Entities;
using XGameDomain.Interfaces.Services;

namespace XGameDomain.Interfaces.Repositories
{
    public interface IRepositoryJogador
    {
        Jogador AutenticarJogador(AutenticarJogadorRequest request);
        Jogador AdicionarJogador(Jogador jogador);
    }
}
