namespace Jokenpo
{
    partial class FormGame
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.gbPlacar = new System.Windows.Forms.GroupBox();
            this.resulCPU = new System.Windows.Forms.Label();
            this.resulJog = new System.Windows.Forms.Label();
            this.labelCPU = new System.Windows.Forms.Label();
            this.labeljog = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnPedra = new System.Windows.Forms.Button();
            this.btnPapel = new System.Windows.Forms.Button();
            this.btnTesoura = new System.Windows.Forms.Button();
            this.labelpedra = new System.Windows.Forms.Label();
            this.labelteso = new System.Windows.Forms.Label();
            this.labelPapel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelResul = new System.Windows.Forms.Label();
            this.picResul = new System.Windows.Forms.PictureBox();
            this.gbPlacar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picResul)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(111, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(578, 94);
            this.label1.TabIndex = 1;
            this.label1.Text = "Faça sua escolha";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gbPlacar
            // 
            this.gbPlacar.Controls.Add(this.resulCPU);
            this.gbPlacar.Controls.Add(this.resulJog);
            this.gbPlacar.Controls.Add(this.labelCPU);
            this.gbPlacar.Controls.Add(this.labeljog);
            this.gbPlacar.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbPlacar.Location = new System.Drawing.Point(12, 418);
            this.gbPlacar.Name = "gbPlacar";
            this.gbPlacar.Size = new System.Drawing.Size(99, 83);
            this.gbPlacar.TabIndex = 3;
            this.gbPlacar.TabStop = false;
            this.gbPlacar.Text = "Placar";
            // 
            // resulCPU
            // 
            this.resulCPU.AutoSize = true;
            this.resulCPU.Location = new System.Drawing.Point(79, 56);
            this.resulCPU.Name = "resulCPU";
            this.resulCPU.Size = new System.Drawing.Size(16, 20);
            this.resulCPU.TabIndex = 3;
            this.resulCPU.Text = "0";
            // 
            // resulJog
            // 
            this.resulJog.AutoSize = true;
            this.resulJog.Location = new System.Drawing.Point(79, 25);
            this.resulJog.Name = "resulJog";
            this.resulJog.Size = new System.Drawing.Size(16, 20);
            this.resulJog.TabIndex = 2;
            this.resulJog.Text = "0";
            // 
            // labelCPU
            // 
            this.labelCPU.AutoSize = true;
            this.labelCPU.Location = new System.Drawing.Point(6, 56);
            this.labelCPU.Name = "labelCPU";
            this.labelCPU.Size = new System.Drawing.Size(38, 20);
            this.labelCPU.TabIndex = 1;
            this.labelCPU.Text = "CPU:";
            // 
            // labeljog
            // 
            this.labeljog.AutoSize = true;
            this.labeljog.Location = new System.Drawing.Point(6, 25);
            this.labeljog.Name = "labeljog";
            this.labeljog.Size = new System.Drawing.Size(57, 20);
            this.labeljog.TabIndex = 0;
            this.labeljog.Text = "Jogador:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(223, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(354, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "Clique em uma das opções para selecionar";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnPedra
            // 
            this.btnPedra.BackColor = System.Drawing.Color.Cyan;
            this.btnPedra.BackgroundImage = global::Jokenpo.Properties.Resources.Pedra;
            this.btnPedra.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPedra.Location = new System.Drawing.Point(214, 151);
            this.btnPedra.Name = "btnPedra";
            this.btnPedra.Size = new System.Drawing.Size(100, 100);
            this.btnPedra.TabIndex = 5;
            this.btnPedra.UseVisualStyleBackColor = false;
            this.btnPedra.Click += new System.EventHandler(this.btnPedra_Click);
            // 
            // btnPapel
            // 
            this.btnPapel.BackgroundImage = global::Jokenpo.Properties.Resources.Papel;
            this.btnPapel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPapel.Location = new System.Drawing.Point(349, 152);
            this.btnPapel.Name = "btnPapel";
            this.btnPapel.Size = new System.Drawing.Size(100, 100);
            this.btnPapel.TabIndex = 6;
            this.btnPapel.UseVisualStyleBackColor = true;
            this.btnPapel.Click += new System.EventHandler(this.btnPapel_Click);
            // 
            // btnTesoura
            // 
            this.btnTesoura.BackgroundImage = global::Jokenpo.Properties.Resources.Tesoura;
            this.btnTesoura.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTesoura.Location = new System.Drawing.Point(485, 152);
            this.btnTesoura.Name = "btnTesoura";
            this.btnTesoura.Size = new System.Drawing.Size(100, 100);
            this.btnTesoura.TabIndex = 7;
            this.btnTesoura.UseVisualStyleBackColor = true;
            this.btnTesoura.Click += new System.EventHandler(this.btnTesoura_Click);
            // 
            // labelpedra
            // 
            this.labelpedra.AutoSize = true;
            this.labelpedra.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelpedra.Location = new System.Drawing.Point(239, 132);
            this.labelpedra.Name = "labelpedra";
            this.labelpedra.Size = new System.Drawing.Size(42, 20);
            this.labelpedra.TabIndex = 8;
            this.labelpedra.Text = "Pedra";
            // 
            // labelteso
            // 
            this.labelteso.AutoSize = true;
            this.labelteso.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelteso.Location = new System.Drawing.Point(509, 132);
            this.labelteso.Name = "labelteso";
            this.labelteso.Size = new System.Drawing.Size(56, 20);
            this.labelteso.TabIndex = 9;
            this.labelteso.Text = "Tesoura";
            // 
            // labelPapel
            // 
            this.labelPapel.AutoSize = true;
            this.labelPapel.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPapel.Location = new System.Drawing.Point(378, 133);
            this.labelPapel.Name = "labelPapel";
            this.labelPapel.Size = new System.Drawing.Size(41, 20);
            this.labelPapel.TabIndex = 10;
            this.labelPapel.Text = "Papel";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(359, 357);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 19);
            this.label3.TabIndex = 11;
            this.label3.Text = "Resultado:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelResul
            // 
            this.labelResul.AutoSize = true;
            this.labelResul.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelResul.Location = new System.Drawing.Point(395, 418);
            this.labelResul.Name = "labelResul";
            this.labelResul.Size = new System.Drawing.Size(16, 20);
            this.labelResul.TabIndex = 12;
            this.labelResul.Text = "?";
            this.labelResul.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picResul
            // 
            this.picResul.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picResul.Location = new System.Drawing.Point(350, 379);
            this.picResul.Name = "picResul";
            this.picResul.Size = new System.Drawing.Size(100, 100);
            this.picResul.TabIndex = 13;
            this.picResul.TabStop = false;
            // 
            // FormGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 513);
            this.Controls.Add(this.labelResul);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelPapel);
            this.Controls.Add(this.labelteso);
            this.Controls.Add(this.labelpedra);
            this.Controls.Add(this.btnTesoura);
            this.Controls.Add(this.btnPapel);
            this.Controls.Add(this.btnPedra);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.gbPlacar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picResul);
            this.Name = "FormGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "JoKenPo!";
            this.gbPlacar.ResumeLayout(false);
            this.gbPlacar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picResul)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbPlacar;
        private System.Windows.Forms.Label labelCPU;
        private System.Windows.Forms.Label labeljog;
        private System.Windows.Forms.Label resulCPU;
        private System.Windows.Forms.Label resulJog;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnPedra;
        private System.Windows.Forms.Button btnPapel;
        private System.Windows.Forms.Button btnTesoura;
        private System.Windows.Forms.Label labelpedra;
        private System.Windows.Forms.Label labelteso;
        private System.Windows.Forms.Label labelPapel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelResul;
        private System.Windows.Forms.PictureBox picResul;
    }
}