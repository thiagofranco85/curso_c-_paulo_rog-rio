using XGameDomain.ValueObjects;

namespace XGameDomain.Interfaces.Services
{
    public class AutenticarJogadorRequest
    {
        public string Email { get; set; }
        public string Senha { get; set; }
        public int Status { get; set; }
    }
}