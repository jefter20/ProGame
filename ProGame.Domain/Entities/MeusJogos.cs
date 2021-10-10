using System;

namespace ProGame.Domain.Entities
{
    public class MeusJogos
    {
        public Guid Id { get; set; }

        public JogoPlataforma JogoPlataforma { get; set; }

        public bool Desejado { get; set; }

        public DateTime DataDesejo { get; set; }

        public bool Troco { get; set; }

        public bool Vendo { get; set; }
    }
}
