namespace Gerenc_Prova
{
    partial class cadastros
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(cadastros));
            this.cadNome = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.cadSobrenome = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.cadEmail = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.cadSenha = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.cadConfSenha = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.cadButCadastrar = new Bunifu.Framework.UI.BunifuThinButton2();
            this.cadEntrar = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cadNome
            // 
            this.cadNome.AllowDrop = true;
            this.cadNome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cadNome.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.cadNome.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.cadNome.ForeColor = System.Drawing.Color.White;
            this.cadNome.HintForeColor = System.Drawing.Color.White;
            this.cadNome.HintText = "Nome";
            this.cadNome.isPassword = false;
            this.cadNome.LineFocusedColor = System.Drawing.Color.Silver;
            this.cadNome.LineIdleColor = System.Drawing.Color.Gray;
            this.cadNome.LineMouseHoverColor = System.Drawing.Color.Silver;
            this.cadNome.LineThickness = 3;
            this.cadNome.Location = new System.Drawing.Point(172, 101);
            this.cadNome.Margin = new System.Windows.Forms.Padding(4);
            this.cadNome.Name = "cadNome";
            this.cadNome.Size = new System.Drawing.Size(220, 44);
            this.cadNome.TabIndex = 1;
            this.cadNome.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.cadNome.OnValueChanged += new System.EventHandler(this.CadNome_OnValueChanged);
            // 
            // cadSobrenome
            // 
            this.cadSobrenome.AllowDrop = true;
            this.cadSobrenome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cadSobrenome.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.cadSobrenome.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.cadSobrenome.ForeColor = System.Drawing.Color.White;
            this.cadSobrenome.HintForeColor = System.Drawing.Color.White;
            this.cadSobrenome.HintText = "Sobrenome";
            this.cadSobrenome.isPassword = false;
            this.cadSobrenome.LineFocusedColor = System.Drawing.Color.Silver;
            this.cadSobrenome.LineIdleColor = System.Drawing.Color.Gray;
            this.cadSobrenome.LineMouseHoverColor = System.Drawing.Color.Silver;
            this.cadSobrenome.LineThickness = 3;
            this.cadSobrenome.Location = new System.Drawing.Point(402, 101);
            this.cadSobrenome.Margin = new System.Windows.Forms.Padding(4);
            this.cadSobrenome.Name = "cadSobrenome";
            this.cadSobrenome.Size = new System.Drawing.Size(220, 44);
            this.cadSobrenome.TabIndex = 2;
            this.cadSobrenome.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // cadEmail
            // 
            this.cadEmail.AllowDrop = true;
            this.cadEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cadEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.cadEmail.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.cadEmail.ForeColor = System.Drawing.Color.White;
            this.cadEmail.HintForeColor = System.Drawing.Color.White;
            this.cadEmail.HintText = "E-mail";
            this.cadEmail.isPassword = false;
            this.cadEmail.LineFocusedColor = System.Drawing.Color.Silver;
            this.cadEmail.LineIdleColor = System.Drawing.Color.Gray;
            this.cadEmail.LineMouseHoverColor = System.Drawing.Color.Silver;
            this.cadEmail.LineThickness = 3;
            this.cadEmail.Location = new System.Drawing.Point(172, 153);
            this.cadEmail.Margin = new System.Windows.Forms.Padding(4);
            this.cadEmail.Name = "cadEmail";
            this.cadEmail.Size = new System.Drawing.Size(450, 44);
            this.cadEmail.TabIndex = 3;
            this.cadEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // cadSenha
            // 
            this.cadSenha.AllowDrop = true;
            this.cadSenha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cadSenha.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.cadSenha.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.cadSenha.ForeColor = System.Drawing.Color.White;
            this.cadSenha.HintForeColor = System.Drawing.Color.White;
            this.cadSenha.HintText = "Senha";
            this.cadSenha.isPassword = false;
            this.cadSenha.LineFocusedColor = System.Drawing.Color.Silver;
            this.cadSenha.LineIdleColor = System.Drawing.Color.Gray;
            this.cadSenha.LineMouseHoverColor = System.Drawing.Color.Silver;
            this.cadSenha.LineThickness = 3;
            this.cadSenha.Location = new System.Drawing.Point(172, 205);
            this.cadSenha.Margin = new System.Windows.Forms.Padding(4);
            this.cadSenha.Name = "cadSenha";
            this.cadSenha.Size = new System.Drawing.Size(450, 44);
            this.cadSenha.TabIndex = 4;
            this.cadSenha.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // cadConfSenha
            // 
            this.cadConfSenha.AllowDrop = true;
            this.cadConfSenha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cadConfSenha.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.cadConfSenha.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.cadConfSenha.ForeColor = System.Drawing.Color.White;
            this.cadConfSenha.HintForeColor = System.Drawing.Color.White;
            this.cadConfSenha.HintText = "Conf. Senha";
            this.cadConfSenha.isPassword = false;
            this.cadConfSenha.LineFocusedColor = System.Drawing.Color.Silver;
            this.cadConfSenha.LineIdleColor = System.Drawing.Color.Gray;
            this.cadConfSenha.LineMouseHoverColor = System.Drawing.Color.Silver;
            this.cadConfSenha.LineThickness = 3;
            this.cadConfSenha.Location = new System.Drawing.Point(172, 257);
            this.cadConfSenha.Margin = new System.Windows.Forms.Padding(4);
            this.cadConfSenha.Name = "cadConfSenha";
            this.cadConfSenha.Size = new System.Drawing.Size(450, 44);
            this.cadConfSenha.TabIndex = 5;
            this.cadConfSenha.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // cadButCadastrar
            // 
            this.cadButCadastrar.ActiveBorderThickness = 1;
            this.cadButCadastrar.ActiveCornerRadius = 20;
            this.cadButCadastrar.ActiveFillColor = System.Drawing.Color.Silver;
            this.cadButCadastrar.ActiveForecolor = System.Drawing.Color.Gray;
            this.cadButCadastrar.ActiveLineColor = System.Drawing.Color.Silver;
            this.cadButCadastrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cadButCadastrar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cadButCadastrar.BackgroundImage")));
            this.cadButCadastrar.ButtonText = "Cadastrar";
            this.cadButCadastrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cadButCadastrar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cadButCadastrar.ForeColor = System.Drawing.Color.White;
            this.cadButCadastrar.IdleBorderThickness = 1;
            this.cadButCadastrar.IdleCornerRadius = 20;
            this.cadButCadastrar.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cadButCadastrar.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cadButCadastrar.IdleLineColor = System.Drawing.Color.Silver;
            this.cadButCadastrar.Location = new System.Drawing.Point(302, 362);
            this.cadButCadastrar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cadButCadastrar.Name = "cadButCadastrar";
            this.cadButCadastrar.Size = new System.Drawing.Size(199, 48);
            this.cadButCadastrar.TabIndex = 6;
            this.cadButCadastrar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cadEntrar
            // 
            this.cadEntrar.AutoSize = true;
            this.cadEntrar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cadEntrar.ForeColor = System.Drawing.Color.Black;
            this.cadEntrar.Location = new System.Drawing.Point(378, 415);
            this.cadEntrar.Name = "cadEntrar";
            this.cadEntrar.Size = new System.Drawing.Size(46, 16);
            this.cadEntrar.TabIndex = 7;
            this.cadEntrar.Text = "Entrar";
            this.cadEntrar.Click += new System.EventHandler(this.CadEntrar_Click);
            // 
            // cadastros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cadEntrar);
            this.Controls.Add(this.cadButCadastrar);
            this.Controls.Add(this.cadConfSenha);
            this.Controls.Add(this.cadSenha);
            this.Controls.Add(this.cadEmail);
            this.Controls.Add(this.cadSobrenome);
            this.Controls.Add(this.cadNome);
            this.Name = "cadastros";
            this.Text = "cadastros";
            this.Load += new System.EventHandler(this.Cadastros_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuMaterialTextbox cadNome;
        private Bunifu.Framework.UI.BunifuMaterialTextbox cadSobrenome;
        private Bunifu.Framework.UI.BunifuMaterialTextbox cadEmail;
        private Bunifu.Framework.UI.BunifuMaterialTextbox cadSenha;
        private Bunifu.Framework.UI.BunifuMaterialTextbox cadConfSenha;
        private Bunifu.Framework.UI.BunifuThinButton2 cadButCadastrar;
        private System.Windows.Forms.Label cadEntrar;
    }
}