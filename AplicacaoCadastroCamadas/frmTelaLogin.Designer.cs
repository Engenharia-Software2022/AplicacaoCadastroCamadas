namespace AplicacaoCadastroCamadas
{
    partial class frmTelaLogin
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
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.cbFechar = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.btnLogin = new Guna.UI2.WinForms.Guna2Button();
            this.cbMinimizar = new Guna.UI2.WinForms.Guna2ControlBox();
            this.txbSenha = new Guna.UI2.WinForms.Guna2TextBox();
            this.txbUsuario = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Panel1.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(58, 413);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Não tem conta? ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(158, 413);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 16);
            this.label4.TabIndex = 20;
            this.label4.Text = "Inscrever-se";
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.cbMinimizar);
            this.guna2Panel1.Controls.Add(this.cbFechar);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(306, 41);
            this.guna2Panel1.TabIndex = 21;
            // 
            // cbFechar
            // 
            this.cbFechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbFechar.BackColor = System.Drawing.Color.White;
            this.cbFechar.BorderColor = System.Drawing.Color.DimGray;
            this.cbFechar.FillColor = System.Drawing.Color.White;
            this.cbFechar.HoverState.BorderColor = System.Drawing.Color.Black;
            this.cbFechar.HoverState.FillColor = System.Drawing.Color.Teal;
            this.cbFechar.HoverState.IconColor = System.Drawing.Color.White;
            this.cbFechar.HoverState.Parent = this.cbFechar;
            this.cbFechar.IconColor = System.Drawing.Color.DimGray;
            this.cbFechar.Location = new System.Drawing.Point(258, 6);
            this.cbFechar.Name = "cbFechar";
            this.cbFechar.PressedColor = System.Drawing.Color.White;
            this.cbFechar.ShadowDecoration.Color = System.Drawing.Color.White;
            this.cbFechar.ShadowDecoration.Parent = this.cbFechar;
            this.cbFechar.Size = new System.Drawing.Size(45, 29);
            this.cbFechar.TabIndex = 22;
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.Controls.Add(this.label3);
            this.guna2Panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel2.Location = new System.Drawing.Point(0, 41);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.ShadowDecoration.Parent = this.guna2Panel2;
            this.guna2Panel2.Size = new System.Drawing.Size(306, 112);
            this.guna2Panel2.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(106, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 39);
            this.label3.TabIndex = 23;
            this.label3.Text = "Login";
            // 
            // btnLogin
            // 
            this.btnLogin.BorderRadius = 20;
            this.btnLogin.CheckedState.Parent = this.btnLogin;
            this.btnLogin.CustomImages.Parent = this.btnLogin;
            this.btnLogin.FillColor = System.Drawing.Color.Teal;
            this.btnLogin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.HoverState.Parent = this.btnLogin;
            this.btnLogin.Location = new System.Drawing.Point(61, 335);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.ShadowDecoration.Parent = this.btnLogin;
            this.btnLogin.Size = new System.Drawing.Size(180, 45);
            this.btnLogin.TabIndex = 24;
            this.btnLogin.Text = "Login";
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // cbMinimizar
            // 
            this.cbMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbMinimizar.BackColor = System.Drawing.Color.White;
            this.cbMinimizar.BorderColor = System.Drawing.Color.DimGray;
            this.cbMinimizar.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.cbMinimizar.FillColor = System.Drawing.Color.White;
            this.cbMinimizar.HoverState.BorderColor = System.Drawing.Color.Black;
            this.cbMinimizar.HoverState.FillColor = System.Drawing.Color.Teal;
            this.cbMinimizar.HoverState.IconColor = System.Drawing.Color.White;
            this.cbMinimizar.HoverState.Parent = this.cbMinimizar;
            this.cbMinimizar.IconColor = System.Drawing.Color.DimGray;
            this.cbMinimizar.Location = new System.Drawing.Point(207, 6);
            this.cbMinimizar.Name = "cbMinimizar";
            this.cbMinimizar.PressedColor = System.Drawing.Color.White;
            this.cbMinimizar.ShadowDecoration.Color = System.Drawing.Color.White;
            this.cbMinimizar.ShadowDecoration.Parent = this.cbMinimizar;
            this.cbMinimizar.Size = new System.Drawing.Size(45, 29);
            this.cbMinimizar.TabIndex = 23;
            // 
            // txbSenha
            // 
            this.txbSenha.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txbSenha.BorderColor = System.Drawing.Color.Teal;
            this.txbSenha.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbSenha.DefaultText = "";
            this.txbSenha.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txbSenha.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txbSenha.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txbSenha.DisabledState.Parent = this.txbSenha;
            this.txbSenha.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txbSenha.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txbSenha.FocusedState.Parent = this.txbSenha;
            this.txbSenha.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txbSenha.HoverState.Parent = this.txbSenha;
            this.txbSenha.IconLeft = global::AplicacaoCadastroCamadas.Properties.Resources.icons8_lock_50__1_;
            this.txbSenha.IconLeftSize = new System.Drawing.Size(30, 30);
            this.txbSenha.Location = new System.Drawing.Point(32, 256);
            this.txbSenha.Name = "txbSenha";
            this.txbSenha.PasswordChar = '*';
            this.txbSenha.PlaceholderText = "   Digite sua senha";
            this.txbSenha.SelectedText = "";
            this.txbSenha.ShadowDecoration.Parent = this.txbSenha;
            this.txbSenha.Size = new System.Drawing.Size(237, 36);
            this.txbSenha.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txbSenha.TabIndex = 23;
            // 
            // txbUsuario
            // 
            this.txbUsuario.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txbUsuario.BorderColor = System.Drawing.Color.Teal;
            this.txbUsuario.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbUsuario.DefaultText = "";
            this.txbUsuario.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txbUsuario.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txbUsuario.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txbUsuario.DisabledState.Parent = this.txbUsuario;
            this.txbUsuario.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txbUsuario.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txbUsuario.FocusedState.Parent = this.txbUsuario;
            this.txbUsuario.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txbUsuario.HoverState.Parent = this.txbUsuario;
            this.txbUsuario.IconLeft = global::AplicacaoCadastroCamadas.Properties.Resources.icons8_user_50;
            this.txbUsuario.IconLeftSize = new System.Drawing.Size(35, 35);
            this.txbUsuario.Location = new System.Drawing.Point(32, 186);
            this.txbUsuario.Name = "txbUsuario";
            this.txbUsuario.PasswordChar = '\0';
            this.txbUsuario.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txbUsuario.PlaceholderText = "   Digite seu usuario";
            this.txbUsuario.SelectedText = "";
            this.txbUsuario.ShadowDecoration.Parent = this.txbUsuario;
            this.txbUsuario.Size = new System.Drawing.Size(237, 36);
            this.txbUsuario.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txbUsuario.TabIndex = 8;
            // 
            // frmTelaLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(306, 471);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txbSenha);
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txbUsuario);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmTelaLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmTelaLogin_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox txbUsuario;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2ControlBox cbFechar;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox txbSenha;
        private Guna.UI2.WinForms.Guna2Button btnLogin;
        private Guna.UI2.WinForms.Guna2ControlBox cbMinimizar;
    }
}

