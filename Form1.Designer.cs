using System;

namespace Gerenc_Prova
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.logUsuario = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.logSenha = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.logButEsntar = new Bunifu.Framework.UI.BunifuThinButton2();
            this.logCadastrar = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // logUsuario
            // 
            this.logUsuario.AllowDrop = true;
            this.logUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.logUsuario.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.logUsuario.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.logUsuario.ForeColor = System.Drawing.Color.White;
            this.logUsuario.HintForeColor = System.Drawing.Color.White;
            this.logUsuario.HintText = "Usuário";
            this.logUsuario.isPassword = false;
            this.logUsuario.LineFocusedColor = System.Drawing.Color.Silver;
            this.logUsuario.LineIdleColor = System.Drawing.Color.Gray;
            this.logUsuario.LineMouseHoverColor = System.Drawing.Color.Silver;
            this.logUsuario.LineThickness = 3;
            this.logUsuario.Location = new System.Drawing.Point(217, 162);
            this.logUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.logUsuario.Name = "logUsuario";
            this.logUsuario.Size = new System.Drawing.Size(370, 44);
            this.logUsuario.TabIndex = 0;
            this.logUsuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // logSenha
            // 
            this.logSenha.AllowDrop = true;
            this.logSenha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.logSenha.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.logSenha.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.logSenha.ForeColor = System.Drawing.Color.White;
            this.logSenha.HintForeColor = System.Drawing.Color.White;
            this.logSenha.HintText = "Senha";
            this.logSenha.isPassword = false;
            this.logSenha.LineFocusedColor = System.Drawing.Color.Silver;
            this.logSenha.LineIdleColor = System.Drawing.Color.Gray;
            this.logSenha.LineMouseHoverColor = System.Drawing.Color.Silver;
            this.logSenha.LineThickness = 3;
            this.logSenha.Location = new System.Drawing.Point(217, 255);
            this.logSenha.Margin = new System.Windows.Forms.Padding(4);
            this.logSenha.Name = "logSenha";
            this.logSenha.Size = new System.Drawing.Size(370, 44);
            this.logSenha.TabIndex = 1;
            this.logSenha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // logButEsntar
            // 
            this.logButEsntar.ActiveBorderThickness = 1;
            this.logButEsntar.ActiveCornerRadius = 20;
            this.logButEsntar.ActiveFillColor = System.Drawing.Color.Silver;
            this.logButEsntar.ActiveForecolor = System.Drawing.Color.Gray;
            this.logButEsntar.ActiveLineColor = System.Drawing.Color.Silver;
            this.logButEsntar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.logButEsntar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("logButEsntar.BackgroundImage")));
            this.logButEsntar.ButtonText = "Entrar";
            this.logButEsntar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logButEsntar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logButEsntar.ForeColor = System.Drawing.Color.White;
            this.logButEsntar.IdleBorderThickness = 1;
            this.logButEsntar.IdleCornerRadius = 20;
            this.logButEsntar.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.logButEsntar.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.logButEsntar.IdleLineColor = System.Drawing.Color.Silver;
            this.logButEsntar.Location = new System.Drawing.Point(300, 363);
            this.logButEsntar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.logButEsntar.Name = "logButEsntar";
            this.logButEsntar.Size = new System.Drawing.Size(199, 48);
            this.logButEsntar.TabIndex = 2;
            this.logButEsntar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.logButEsntar.Click += new System.EventHandler(this.LogButEsntar_Click);
            // 
            // logCadastrar
            // 
            this.logCadastrar.AutoSize = true;
            this.logCadastrar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logCadastrar.ForeColor = System.Drawing.Color.Black;
            this.logCadastrar.Location = new System.Drawing.Point(362, 416);
            this.logCadastrar.Name = "logCadastrar";
            this.logCadastrar.Size = new System.Drawing.Size(74, 16);
            this.logCadastrar.TabIndex = 3;
            this.logCadastrar.Text = "Cadastrar";
            this.logCadastrar.Click += new System.EventHandler(this.LogCadastrar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(470, 303);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Redefinir Senha?";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(295, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(209, 120);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(799, 451);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.logCadastrar);
            this.Controls.Add(this.logButEsntar);
            this.Controls.Add(this.logSenha);
            this.Controls.Add(this.logUsuario);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuMaterialTextbox logUsuario;
        private Bunifu.Framework.UI.BunifuMaterialTextbox logSenha;
        private Bunifu.Framework.UI.BunifuThinButton2 logButEsntar;
        private System.Windows.Forms.Label logCadastrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

