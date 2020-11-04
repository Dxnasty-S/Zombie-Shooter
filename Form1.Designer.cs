namespace Zombie_Shooter
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.txtMunicao = new System.Windows.Forms.Label();
            this.txtEliminacoes = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.barraSorte = new System.Windows.Forms.ProgressBar();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.Jogador = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Jogador)).BeginInit();
            this.SuspendLayout();
            // 
            // txtMunicao
            // 
            this.txtMunicao.AutoSize = true;
            this.txtMunicao.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMunicao.Location = new System.Drawing.Point(12, 9);
            this.txtMunicao.Name = "txtMunicao";
            this.txtMunicao.Size = new System.Drawing.Size(128, 25);
            this.txtMunicao.TabIndex = 1;
            this.txtMunicao.Text = "Munição: 0";
            // 
            // txtEliminacoes
            // 
            this.txtEliminacoes.AutoSize = true;
            this.txtEliminacoes.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEliminacoes.Location = new System.Drawing.Point(231, 9);
            this.txtEliminacoes.Name = "txtEliminacoes";
            this.txtEliminacoes.Size = new System.Drawing.Size(166, 25);
            this.txtEliminacoes.TabIndex = 1;
            this.txtEliminacoes.Text = "Eliminações: 0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(567, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "Sorte: ";
            // 
            // barraSorte
            // 
            this.barraSorte.Location = new System.Drawing.Point(640, 9);
            this.barraSorte.Name = "barraSorte";
            this.barraSorte.Size = new System.Drawing.Size(232, 25);
            this.barraSorte.TabIndex = 2;
            this.barraSorte.Value = 100;
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Interval = 20;
            this.gameTimer.Tick += new System.EventHandler(this.Atualizar);
            // 
            // Jogador
            // 
            this.Jogador.Image = global::Zombie_Shooter.Properties.Resources.up;
            this.Jogador.Location = new System.Drawing.Point(385, 391);
            this.Jogador.Name = "Jogador";
            this.Jogador.Size = new System.Drawing.Size(71, 100);
            this.Jogador.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Jogador.TabIndex = 0;
            this.Jogador.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.barraSorte);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtEliminacoes);
            this.Controls.Add(this.txtMunicao);
            this.Controls.Add(this.Jogador);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.MaximumSize = new System.Drawing.Size(900, 600);
            this.MinimumSize = new System.Drawing.Size(900, 600);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TeclaEstaPressionada);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TeclaFoiLiberada);
            ((System.ComponentModel.ISupportInitialize)(this.Jogador)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Jogador;
        private System.Windows.Forms.Label txtMunicao;
        private System.Windows.Forms.Label txtEliminacoes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ProgressBar barraSorte;
        private System.Windows.Forms.Timer gameTimer;
    }
}

