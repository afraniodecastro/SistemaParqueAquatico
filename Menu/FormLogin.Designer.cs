namespace Menu
{
    partial class FLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FLogin));
            this.label1 = new System.Windows.Forms.Label();
            this.TBUser = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TBSenha = new System.Windows.Forms.TextBox();
            this.LBErroAutenticacao = new System.Windows.Forms.Label();
            this.LBusuario = new System.Windows.Forms.Label();
            this.LBsenha = new System.Windows.Forms.Label();
            this.BTSair = new System.Windows.Forms.Button();
            this.BTlimpar = new System.Windows.Forms.Button();
            this.BTLogin = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.erroConexao = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Name = "label1";
            // 
            // TBUser
            // 
            resources.ApplyResources(this.TBUser, "TBUser");
            this.TBUser.Name = "TBUser";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label3.ForeColor = System.Drawing.Color.Navy;
            this.label3.Name = "label3";
            // 
            // TBSenha
            // 
            resources.ApplyResources(this.TBSenha, "TBSenha");
            this.TBSenha.Name = "TBSenha";
            // 
            // LBErroAutenticacao
            // 
            resources.ApplyResources(this.LBErroAutenticacao, "LBErroAutenticacao");
            this.LBErroAutenticacao.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.LBErroAutenticacao.Name = "LBErroAutenticacao";
            // 
            // LBusuario
            // 
            resources.ApplyResources(this.LBusuario, "LBusuario");
            this.LBusuario.Name = "LBusuario";
            // 
            // LBsenha
            // 
            resources.ApplyResources(this.LBsenha, "LBsenha");
            this.LBsenha.Name = "LBsenha";
            // 
            // BTSair
            // 
            resources.ApplyResources(this.BTSair, "BTSair");
            this.BTSair.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.BTSair.Image = global::Menu.Properties.Resources.sair2;
            this.BTSair.Name = "BTSair";
            this.BTSair.UseVisualStyleBackColor = true;
            this.BTSair.Click += new System.EventHandler(this.BTSair_Click);
            // 
            // BTlimpar
            // 
            resources.ApplyResources(this.BTlimpar, "BTlimpar");
            this.BTlimpar.Image = global::Menu.Properties.Resources.apagar;
            this.BTlimpar.Name = "BTlimpar";
            this.BTlimpar.UseVisualStyleBackColor = true;
            this.BTlimpar.Click += new System.EventHandler(this.BTlimpar_Click);
            // 
            // BTLogin
            // 
            this.BTLogin.FlatAppearance.BorderColor = System.Drawing.Color.Navy;
            resources.ApplyResources(this.BTLogin, "BTLogin");
            this.BTLogin.Image = global::Menu.Properties.Resources.desbloquear;
            this.BTLogin.Name = "BTLogin";
            this.BTLogin.UseVisualStyleBackColor = true;
            this.BTLogin.Click += new System.EventHandler(this.BTLogin_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox1.Image = global::Menu.Properties.Resources.parque;
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label4.Name = "label4";
            // 
            // erroConexao
            // 
            resources.ApplyResources(this.erroConexao, "erroConexao");
            this.erroConexao.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.erroConexao.Name = "erroConexao";
            // 
            // FLogin
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Controls.Add(this.erroConexao);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BTSair);
            this.Controls.Add(this.BTlimpar);
            this.Controls.Add(this.LBsenha);
            this.Controls.Add(this.LBusuario);
            this.Controls.Add(this.LBErroAutenticacao);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BTLogin);
            this.Controls.Add(this.TBSenha);
            this.Controls.Add(this.TBUser);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FLogin";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TBUser;
        private System.Windows.Forms.Button BTLogin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TBSenha;
        private System.Windows.Forms.Label LBErroAutenticacao;
        private System.Windows.Forms.Label LBusuario;
        private System.Windows.Forms.Label LBsenha;
        private System.Windows.Forms.Button BTlimpar;
        private System.Windows.Forms.Button BTSair;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label erroConexao;
    }
}