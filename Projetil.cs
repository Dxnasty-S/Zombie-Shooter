using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace Zombie_Shooter
{
    class Projetil
    {
        public string direcao;
        public int projetilEsquerda;
        public int projetilTopo;

        private int velocidade = 20;
        private PictureBox projetil = new PictureBox();
        private Timer cronometroProjetil = new Timer();

        public void CriarProjetil(Form form)
        {
            projetil.BackColor = Color.White;
            projetil.Size = new Size(5, 5);
            projetil.Tag = "projetil";
            projetil.Left = projetilEsquerda;
            projetil.Top = projetilTopo;
            projetil.BringToFront();

            form.Controls.Add(projetil);

            cronometroProjetil.Interval = velocidade;
            cronometroProjetil.Tick += new EventHandler(AtualizarProjetil);
            cronometroProjetil.Start();
        }


        private void AtualizarProjetil(object sender, EventArgs e)
        {
            if (direcao == "esquerda")
            {
                projetil.Left -= velocidade;
            }

            if(direcao == "direita")
            {
                projetil.Left += velocidade;
            }

            if(direcao == "cima")
            {
                projetil.Top -= velocidade;
            }

            if(direcao == "baixo")
            {
                projetil.Top += velocidade;
            }

            if(projetil.Left < 10 ||
               projetil.Left > 860 ||
               projetil.Top < 10 ||
               projetil.Top > 600)
            {
                cronometroProjetil.Stop();
                cronometroProjetil.Dispose();
                projetil.Dispose();
                cronometroProjetil = null;
                projetil = null;
            }
        }



    }

   
}
