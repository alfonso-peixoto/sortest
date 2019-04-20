using System;

namespace Gerenc_Provas
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.LogLogin = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.LogSenha = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.LabCadastrar = new System.Windows.Forms.Label();
            this.LogEsqueceuSenha = new System.Windows.Forms.Label();
            this.LogButEntrar = new Bunifu.Framework.UI.BunifuThinButton2();
            this.SuspendLayout();
            // 
            // LogLogin
            // 
            this.LogLogin.AllowDrop = true;
            this.LogLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.LogLogin.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.LogLogin.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogLogin.ForeColor = System.Drawing.Color.White;
            this.LogLogin.HintForeColor = System.Drawing.Color.White;
            this.LogLogin.HintText = "Usuário";
            this.LogLogin.isPassword = false;
            this.LogLogin.LineFocusedColor = System.Drawing.Color.Silver;
            this.LogLogin.LineIdleColor = System.Drawing.Color.Gray;
            this.LogLogin.LineMouseHoverColor = System.Drawing.Color.Silver;
            this.LogLogin.LineThickness = 3;
            this.LogLogin.Location = new System.Drawing.Point(211, 118);
            this.LogLogin.Margin = new System.Windows.Forms.Padding(4);
            this.LogLogin.Name = "LogLogin";
            this.LogLogin.Size = new System.Drawing.Size(370, 44);
            this.LogLogin.TabIndex = 0;
            this.LogLogin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LogSenha
            // 
            this.LogSenha.AllowDrop = true;
            this.LogSenha.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.LogSenha.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogSenha.ForeColor = System.Drawing.Color.White;
            this.LogSenha.HintForeColor = System.Drawing.Color.White;
            this.LogSenha.HintText = "Senha";
            this.LogSenha.isPassword = true;
            this.LogSenha.LineFocusedColor = System.Drawing.Color.Silver;
            this.LogSenha.LineIdleColor = System.Drawing.Color.Gray;
            this.LogSenha.LineMouseHoverColor = System.Drawing.Color.Silver;
            this.LogSenha.LineThickness = 3;
            this.LogSenha.Location = new System.Drawing.Point(211, 210);
            this.LogSenha.Margin = new System.Windows.Forms.Padding(4);
            this.LogSenha.Name = "LogSenha";
            this.LogSenha.Size = new System.Drawing.Size(370, 44);
            this.LogSenha.TabIndex = 1;
            this.LogSenha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LabCadastrar
            // 
            this.LabCadastrar.AutoSize = true;
            this.LabCadastrar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabCadastrar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.LabCadastrar.Location = new System.Drawing.Point(362, 352);
            this.LabCadastrar.Name = "LabCadastrar";
            this.LabCadastrar.Size = new System.Drawing.Size(74, 16);
            this.LabCadastrar.TabIndex = 3;
            this.LabCadastrar.Text = "Cadastrar";
            this.LabCadastrar.Click += new System.EventHandler(this.LabCadastrar_Click);
            // 
            // LogEsqueceuSenha
            // 
            this.LogEsqueceuSenha.AutoSize = true;
            this.LogEsqueceuSenha.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogEsqueceuSenha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.LogEsqueceuSenha.Location = new System.Drawing.Point(448, 258);
            this.LogEsqueceuSenha.Name = "LogEsqueceuSenha";
            this.LogEsqueceuSenha.Size = new System.Drawing.Size(133, 17);
            this.LogEsqueceuSenha.TabIndex = 4;
            this.LogEsqueceuSenha.Text = "Esqueceu a Senha?";
            // 
            // LogButEntrar
            // 
            this.LogButEntrar.ActiveBorderThickness = 1;
            this.LogButEntrar.ActiveCornerRadius = 20;
            this.LogButEntrar.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.LogButEntrar.ActiveForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.LogButEntrar.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.LogButEntrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.LogButEntrar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("LogButEntrar.BackgroundImage")));
            this.LogButEntrar.ButtonText = "Entrar";
            this.LogButEntrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LogButEntrar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogButEntrar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.LogButEntrar.IdleBorderThickness = 1;
            this.LogButEntrar.IdleCornerRadius = 20;
            this.LogButEntrar.IdleFillColor = System.Drawing.Color.Silver;
            this.LogButEntrar.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.LogButEntrar.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.LogButEntrar.Location = new System.Drawing.Point(306, 306);
            this.LogButEntrar.Margin = new System.Windows.Forms.Padding(5);
            this.LogButEntrar.Name = "LogButEntrar";
            this.LogButEntrar.Size = new System.Drawing.Size(181, 41);
            this.LogButEntrar.TabIndex = 7;
            this.LogButEntrar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LogButEntrar.Click += new System.EventHandler(this.LogButEntrar_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LogButEntrar);
            this.Controls.Add(this.LogEsqueceuSenha);
            this.Controls.Add(this.LabCadastrar);
            this.Controls.Add(this.LogSenha);
            this.Controls.Add(this.LogLogin);
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void LabCadastrar_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Bunifu.Framework.UI.BunifuMaterialTextbox LogLogin;
        private Bunifu.Framework.UI.BunifuMaterialTextbox LogSenha;
        private System.Windows.Forms.Label LabCadastrar;
        private System.Windows.Forms.Label LogEsqueceuSenha;
        private Bunifu.Framework.UI.BunifuThinButton2 LogButEntrar;
    }
}

