using XGameDomain.Interfaces.Arguments;
using XGameDomain.ValueObjects;

namespace XGameDomain.Interfaces.Services
{
    public class AutenticarJogadorResponse : IResponse
    {
        public string PrimeiroNome { get; set; }
        public string Email { get; set; }
    }
}