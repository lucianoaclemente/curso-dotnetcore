using System;

namespace GameTOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Jogo jogo = new Jogo(
                new Jogador1(),
                new Jogador2()
            );

            jogo.IniciarJogo();
        }
    }


}
