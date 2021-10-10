using ProGame.Domain.Enum;
using ProGame.Domain.ValueObjects;
using System;

namespace ProGame.Domain
{
    public class Jogador
    {
        public Guid Id { get; set; }

        public Nome Nome { get; set; }

        public Email Email { get; set; }

        public string Senha { get; set; }

        public EnumSituacaoJogador Status { get; set; }
    }
}
