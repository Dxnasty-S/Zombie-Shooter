using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zombie_Shooter
{
    
    public partial class Form1 : Form
    {
        bool irParaEsquerda, IrParaDireita, irParaCima, irParaBaixo, gameOver;
        string olhando = "cima";
        int sorteDoJogador = 100;
        int velocidadeDoJogador = 10;
        int municaoDoJogador = 10;
        int eliminacoes = 0;
        int velocidadeDoZumbi = 3;
        Random numeroAleatorio = new Random();
        List<PictureBox> listaDeZumbis = new List<PictureBox>();

        private void TeclaFoiLiberada(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                irParaCima = false;
            }

            if (e.KeyCode == Keys.Down)
            {
                irParaBaixo = false;
            }

            if (e.KeyCode == Keys.Left)
            {
                irParaEsquerda = false;
            }

            if (e.KeyCode == Keys.Right)
            {
                IrParaDireita = false;
            }

            if(e.KeyCode == Keys.Space && municaoDoJogador > 0)
            {
                municaoDoJogador--;
                Atirar(olhando);

                if(municaoDoJogador < 1)
                {
                    CriarMunicao();
                }
            }
        }

        private void TeclaEstaPressionada(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Up )
            {
                irParaCima = true;
                olhando = "cima";
                Jogador.Image = Properties.Resources.up;
            }

            if(e.KeyCode == Keys.Down)
            {
                irParaBaixo = true;
                olhando = "baixo";
                Jogador.Image = Properties.Resources.down;
            }

            if (e.KeyCode == Keys.Left)
            {
                irParaEsquerda = true;
                olhando = "esquerda";
                Jogador.Image = Properties.Resources.left;
            }

            if(e.KeyCode == Keys.Right)
            {
                IrParaDireita = true;
                olhando = "direita";
                Jogador.Image = Properties.Resources.right;
            }

        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Atualizar(object sender, EventArgs e)
        {
            txtMunicao.Text = "municao" + municaoDoJogador;

            if (irParaEsquerda == true && Jogador.Left > 0)
            {
                Jogador.Left -= velocidadeDoJogador;
            }

            if(IrParaDireita == true && Jogador.Left + Jogador.Width < this.ClientSize.Width)
            {
                Jogador.Left += velocidadeDoJogador;
            }

            if(irParaCima == true && Jogador.Top > 40)
            {
                Jogador.Top -= velocidadeDoJogador;
            }

            if(irParaBaixo == true && Jogador.Top + Jogador.Height < this.ClientSize.Height)
            {
                Jogador.Top += velocidadeDoJogador;  
            } 

            foreach(Control item in this.Controls)
            {
                if (item is PictureBox && (string) item.Tag == "municao")
                {
                    if (Jogador.Bounds.IntersectsWith(item.Bounds))
                    {
                        this.Controls.Remove(item);
                        ((PictureBox)item).Dispose();
                        municaoDoJogador += 5;
                    }
                }

                if (item is PictureBox && (string) item.Tag == "zumbi")
                {
                    if (Jogador.Bounds.IntersectsWith(item.Bounds))
                    {
                        sorteDoJogador -= 1;
                    }

                    if (item.Left > Jogador.Left)
                    {
                        item.Left -= velocidadeDoZumbi;
                        ((PictureBox)item).Image = Properties.Resources.zleft;
                    }

                    if (item.Left < Jogador.Left)
                    {
                        item.Left += velocidadeDoZumbi;
                        ((PictureBox)item).Image = Properties.Resources.zright;
                    }

                    if (item.Top > Jogador.Top)
                    {
                        item.Top -= velocidadeDoZumbi;
                        ((PictureBox)item).Image = Properties.Resources.zup;
                    }

                    if (item.Top < Jogador.Top)
                    {
                        item.Top += velocidadeDoZumbi;
                        ((PictureBox)item).Image = Properties.Resources.zdown;
                    }

                    foreach (Control controle in Controls)
                    {
                        if(controle is PictureBox & (string) controle.Tag == "projetil" &&
                           item is PictureBox && (string) controle.Tag == "zumbi")
                        {
                            if (controle.Bounds.IntersectsWith(item.Bounds))
                            {
                                eliminacoes++;
                                this.Controls.Remove(item);
                                ((PictureBox)item).Dispose();
                                this.Controls.Remove(controle);
                                ((PictureBox)item).Dispose();
                                listaDeZumbis.Remove((PictureBox)item);
                                CriarZumbi();
                            }
                        }
                    }
                }
            }

        }

        private void Atirar(string direcaoDoTiro)
        {

            Projetil meuProjetil = new Projetil();
            meuProjetil.direcao = direcaoDoTiro;
            meuProjetil.projetilEsquerda = Jogador.Left + (Jogador.Width / 2);
            meuProjetil.projetilTopo = Jogador.Top + (Jogador.Height / 2);
            meuProjetil.CriarProjetil(this);
        }

        private void CriarMunicao()
        {
            PictureBox municao = new PictureBox();
            municao.Image = Properties.Resources.ammo_Image;
            municao.SizeMode = PictureBoxSizeMode.AutoSize;
            municao.Left = numeroAleatorio.Next(10, this.ClientSize.Width - municao.Width);
            municao.Top = numeroAleatorio.Next(60, this.ClientSize.Height - municao.Height);
            municao.Tag = "municao";
            this.Controls.Add(municao);

            municao.BringToFront();
            Jogador.BringToFront();
        }

        private void CriarZumbi()
        {
            PictureBox zumbi = new PictureBox();
            zumbi.Tag = "zumbi";
            zumbi.Image = Properties.Resources.zdown;
            zumbi.Left = numeroAleatorio.Next(0, 900);
            zumbi.Top = numeroAleatorio.Next(0, 800);
            zumbi.SizeMode = PictureBoxSizeMode.AutoSize;
            listaDeZumbis.Add(zumbi);
            this.Controls.Add(zumbi);
            Jogador.BringToFront();

        }
    }
}
