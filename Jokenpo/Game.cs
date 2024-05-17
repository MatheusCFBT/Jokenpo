using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jokenpo
{
    internal class Game
    {

        public enum Resultado // Enumeração que cóntém os resultados
        {
            Ganhar, Perder, Empatar
        }

        public static Image[] images = 
        { 
            Image.FromFile("imagens/pedra.png"),
            Image.FromFile("imagens/papel.png"),
            Image.FromFile("imagens/tesoura.png")
        };

        public Image ImgCPU { get; private set; } // private set pois o usuário não pode definir a imagem
        public Image ImgJogador { get; private set; } // private set pois a imagem será definida pelo codigo

        public Resultado Jogar (int Jogador)
        {
            int cpu = JogadaCPU();

            ImgJogador = images[Jogador];
            ImgCPU = images[cpu];

            if ( Jogador == cpu)
            {
                return Resultado.Empatar;
            }
            else if ((Jogador == 0 && cpu == 2) || (Jogador == 1 && cpu == 0) || (Jogador == 2 && cpu == 1))
            {
                return Resultado.Ganhar;
            }
            else
            {
                return Resultado.Perder;
            }
        }

        private int JogadaCPU()
        {
           int mili = DateTime.Now.Millisecond;

            if (mili < 333)
            {
                return 0;
            } 
            else if (mili >= 333 && mili <667)
            {
                return 1;
            } 
            else
            {
                return 2;
            }
        }
    }
}
