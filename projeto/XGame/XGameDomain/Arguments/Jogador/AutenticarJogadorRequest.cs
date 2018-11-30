using XGameDomain.ValueObjects;

namespace XGameDomain.Interfaces.Services
{
    public class AutenticarJogadorRequest
    {
        public Email Email { get; set; }
        public string Senha { get; set; }
    }
}