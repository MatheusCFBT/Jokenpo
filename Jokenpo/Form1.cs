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
    public partial class JoKenPo : Form
    {
        public JoKenPo()
        {
            InitializeComponent();
        }

        private void btnJogar_Click(object sender, EventArgs e)
        {
            this.Hide(); 
            FormGame TelaJogo = new FormGame();

            TelaJogo.ShowDialog();
            this.Show();
        }
    }
}
