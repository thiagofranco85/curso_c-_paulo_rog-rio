using System;

namespace XGameDomain.Entities
{
    class JogoPlataforma
    {
        public Guid Id { get; set; }
        public Jogo Jogo { get; set; }
        public Plataforma Plataforma { get; set; }
        public DateTime Data { get; set; }
    }
}
