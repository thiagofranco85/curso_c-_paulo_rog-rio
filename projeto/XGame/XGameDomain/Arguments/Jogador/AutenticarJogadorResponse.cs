using System;
using XGameDomain.Entities;
using XGameDomain.Interfaces.Arguments;
using XGameDomain.ValueObjects;

namespace XGameDomain.Interfaces.Services
{
    public class AutenticarJogadorResponse : IResponse
    {
        public string PrimeiroNome { get; set; }
        public string Email { get; set; }
        public int Status { get; set; }

        public static explicit operator AutenticarJogadorResponse(Jogador v)
        {
            return new AutenticarJogadorResponse
            {
                Email = v.Email.Endereco,
                PrimeiroNome = v.Nome.PrimeiroNome,
                Status = (int)v.Status
            };
        }
    }
}