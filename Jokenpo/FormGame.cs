using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jokenpo
{
    public partial class FormGame : Form
    {
        int placarJog = 0;
        int placarCPU = 0;

        public FormGame()
        {
            InitializeComponent();
        }

        private void btnPedra_Click(object sender, EventArgs e)
        {
            StartGame(0);
        }

        private void btnPapel_Click(object sender, EventArgs e)
        {
            StartGame(1);
        }

        private void btnTesoura_Click(object sender, EventArgs e)
        {
            StartGame(2);
        }

        private void StartGame(int opcao)
        {
            labelResul.Visible = false;
            Game jogo = new Game();

            switch (jogo.Jogar(opcao))
            {
                case Game.Resultado.Ganhar:
                    picResul.BackgroundImage = Image.FromFile("imagens/Ganhar.png");
                    ++placarJog;
                    resulJog.Text = placarJog.ToString();
                    break;

                case Game.Resultado.Empatar:
                    picResul.BackgroundImage = Image.FromFile("imagens/Empatar.png");

                    break;

                case Game.Resultado.Perder:
                    picResul.BackgroundImage = Image.FromFile("imagens/Perder.png");
                    ++placarCPU;
                    resulCPU.Text = placarCPU.ToString();
                    break;
            } 
        }
    }
}
