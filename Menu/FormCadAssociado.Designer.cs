namespace Menu
{
    partial class FormCadCliente
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
            this.components = new System.ComponentModel.Container();
            this.TTErro = new System.Windows.Forms.ToolTip(this.components);
            this.CBtipoCota = new System.Windows.Forms.ComboBox();
            this.TTWarning = new System.Windows.Forms.ToolTip(this.components);
            this.LBnome = new System.Windows.Forms.Label();
            this.TBNome = new System.Windows.Forms.TextBox();
            this.LBdataNascimento = new System.Windows.Forms.Label();
            this.LBsexo = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.LBemail = new System.Windows.Forms.Label();
            this.TTBemail = new System.Windows.Forms.TextBox();
            this.LBtipoCota = new System.Windows.Forms.Label();
            this.RBmasculino = new System.Windows.Forms.RadioButton();
            this.RBfeminino = new System.Windows.Forms.RadioButton();
            this.LBsenha1 = new System.Windows.Forms.Label();
            this.TBsenha1 = new System.Windows.Forms.TextBox();
            this.LBsenha2 = new System.Windows.Forms.Label();
            this.TBsenha2 = new System.Windows.Forms.TextBox();
            this.LBMensagemBranco = new System.Windows.Forms.Label();
            this.LBvalor = new System.Windows.Forms.Label();
            this.TBvalor = new System.Windows.Forms.TextBox();
            this.LBusuario = new System.Windows.Forms.Label();
            this.TBusuario = new System.Windows.Forms.TextBox();
            this.BTCancelar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.BTSalvar = new System.Windows.Forms.Button();
            this.TTinfo = new System.Windows.Forms.ToolTip(this.components);
            this.LBtelefone = new System.Windows.Forms.Label();
            this.TBDataNascimento = new System.Windows.Forms.MaskedTextBox();
            this.TBtelefone = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // TTErro
            // 
            this.TTErro.IsBalloon = true;
            this.TTErro.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Error;
            // 
            // CBtipoCota
            // 
            this.CBtipoCota.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBtipoCota.FormattingEnabled = true;
            this.CBtipoCota.Location = new System.Drawing.Point(108, 243);
            this.CBtipoCota.Name = "CBtipoCota";
            this.CBtipoCota.Size = new System.Drawing.Size(361, 33);
            this.CBtipoCota.TabIndex = 14;
            this.CBtipoCota.SelectedIndexChanged += new System.EventHandler(this.CBtipoCota_SelectedIndexChanged);
            // 
            // TTWarning
            // 
            this.TTWarning.BackColor = System.Drawing.Color.LightCoral;
            this.TTWarning.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.TTWarning.IsBalloon = true;
            this.TTWarning.ShowAlways = true;
            this.TTWarning.StripAmpersands = true;
            this.TTWarning.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Warning;
            this.TTWarning.ToolTipTitle = "ATENÇÃO";
            // 
            // LBnome
            // 
            this.LBnome.AutoSize = true;
            this.LBnome.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBnome.Location = new System.Drawing.Point(87, 94);
            this.LBnome.Name = "LBnome";
            this.LBnome.Size = new System.Drawing.Size(74, 24);
            this.LBnome.TabIndex = 0;
            this.LBnome.Text = "Nome *";
            // 
            // TBNome
            // 
            this.TBNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBNome.Location = new System.Drawing.Point(108, 121);
            this.TBNome.Name = "TBNome";
            this.TBNome.Size = new System.Drawing.Size(339, 30);
            this.TBNome.TabIndex = 1;
            this.TTinfo.SetToolTip(this.TBNome, "Informe seu nome completo");
            // 
            // LBdataNascimento
            // 
            this.LBdataNascimento.AutoSize = true;
            this.LBdataNascimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBdataNascimento.Location = new System.Drawing.Point(483, 94);
            this.LBdataNascimento.Name = "LBdataNascimento";
            this.LBdataNascimento.Size = new System.Drawing.Size(191, 24);
            this.LBdataNascimento.TabIndex = 2;
            this.LBdataNascimento.Text = "Data de Nascimento *";
            // 
            // LBsexo
            // 
            this.LBsexo.AutoSize = true;
            this.LBsexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBsexo.Location = new System.Drawing.Point(87, 154);
            this.LBsexo.Name = "LBsexo";
            this.LBsexo.Size = new System.Drawing.Size(66, 24);
            this.LBsexo.TabIndex = 4;
            this.LBsexo.Text = "Sexo *";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(225, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(346, 26);
            this.label4.TabIndex = 9;
            this.label4.Text = "CADASTRO DE ASSOCIADOS";
            // 
            // LBemail
            // 
            this.LBemail.AutoSize = true;
            this.LBemail.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBemail.Location = new System.Drawing.Point(335, 154);
            this.LBemail.Name = "LBemail";
            this.LBemail.Size = new System.Drawing.Size(75, 24);
            this.LBemail.TabIndex = 10;
            this.LBemail.Text = "E-mail *";
            // 
            // TTBemail
            // 
            this.TTBemail.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TTBemail.Location = new System.Drawing.Point(347, 181);
            this.TTBemail.Name = "TTBemail";
            this.TTBemail.Size = new System.Drawing.Size(385, 30);
            this.TTBemail.TabIndex = 11;
            // 
            // LBtipoCota
            // 
            this.LBtipoCota.AutoSize = true;
            this.LBtipoCota.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBtipoCota.Location = new System.Drawing.Point(87, 216);
            this.LBtipoCota.Name = "LBtipoCota";
            this.LBtipoCota.Size = new System.Drawing.Size(127, 24);
            this.LBtipoCota.TabIndex = 13;
            this.LBtipoCota.Text = "Tipo de cota *";
            // 
            // RBmasculino
            // 
            this.RBmasculino.AutoSize = true;
            this.RBmasculino.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RBmasculino.Location = new System.Drawing.Point(106, 181);
            this.RBmasculino.Name = "RBmasculino";
            this.RBmasculino.Size = new System.Drawing.Size(119, 29);
            this.RBmasculino.TabIndex = 15;
            this.RBmasculino.TabStop = true;
            this.RBmasculino.Text = "Masculino";
            this.RBmasculino.UseVisualStyleBackColor = true;
            // 
            // RBfeminino
            // 
            this.RBfeminino.AutoSize = true;
            this.RBfeminino.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RBfeminino.Location = new System.Drawing.Point(231, 181);
            this.RBfeminino.Name = "RBfeminino";
            this.RBfeminino.Size = new System.Drawing.Size(110, 29);
            this.RBfeminino.TabIndex = 16;
            this.RBfeminino.TabStop = true;
            this.RBfeminino.Text = "Feminino";
            this.RBfeminino.UseVisualStyleBackColor = true;
            // 
            // LBsenha1
            // 
            this.LBsenha1.AutoSize = true;
            this.LBsenha1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBsenha1.Location = new System.Drawing.Point(87, 342);
            this.LBsenha1.Name = "LBsenha1";
            this.LBsenha1.Size = new System.Drawing.Size(77, 24);
            this.LBsenha1.TabIndex = 17;
            this.LBsenha1.Text = "Senha *";
            // 
            // TBsenha1
            // 
            this.TBsenha1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBsenha1.Location = new System.Drawing.Point(112, 369);
            this.TBsenha1.Name = "TBsenha1";
            this.TBsenha1.Size = new System.Drawing.Size(305, 30);
            this.TBsenha1.TabIndex = 18;
            this.TTinfo.SetToolTip(this.TBsenha1, "A senha tem que ter 8 dígitos ou mais");
            // 
            // LBsenha2
            // 
            this.LBsenha2.AutoSize = true;
            this.LBsenha2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBsenha2.Location = new System.Drawing.Point(432, 342);
            this.LBsenha2.Name = "LBsenha2";
            this.LBsenha2.Size = new System.Drawing.Size(139, 24);
            this.LBsenha2.TabIndex = 19;
            this.LBsenha2.Text = "Repetir senha *";
            // 
            // TBsenha2
            // 
            this.TBsenha2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBsenha2.Location = new System.Drawing.Point(457, 369);
            this.TBsenha2.Name = "TBsenha2";
            this.TBsenha2.Size = new System.Drawing.Size(275, 30);
            this.TBsenha2.TabIndex = 20;
            this.TTinfo.SetToolTip(this.TBsenha2, "A senha tem que ter 8 dígitos ou mais");
            // 
            // LBMensagemBranco
            // 
            this.LBMensagemBranco.AutoSize = true;
            this.LBMensagemBranco.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBMensagemBranco.Location = new System.Drawing.Point(87, 69);
            this.LBMensagemBranco.Name = "LBMensagemBranco";
            this.LBMensagemBranco.Size = new System.Drawing.Size(192, 13);
            this.LBMensagemBranco.TabIndex = 21;
            this.LBMensagemBranco.Text = "* Campos de preenchimento obrigatório";
            // 
            // LBvalor
            // 
            this.LBvalor.AutoSize = true;
            this.LBvalor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBvalor.Location = new System.Drawing.Point(503, 219);
            this.LBvalor.Name = "LBvalor";
            this.LBvalor.Size = new System.Drawing.Size(132, 24);
            this.LBvalor.TabIndex = 22;
            this.LBvalor.Text = "Valor mensal *";
            // 
            // TBvalor
            // 
            this.TBvalor.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBvalor.Location = new System.Drawing.Point(528, 246);
            this.TBvalor.Name = "TBvalor";
            this.TBvalor.ReadOnly = true;
            this.TBvalor.Size = new System.Drawing.Size(204, 30);
            this.TBvalor.TabIndex = 23;
            // 
            // LBusuario
            // 
            this.LBusuario.AutoSize = true;
            this.LBusuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBusuario.Location = new System.Drawing.Point(350, 279);
            this.LBusuario.Name = "LBusuario";
            this.LBusuario.Size = new System.Drawing.Size(86, 24);
            this.LBusuario.TabIndex = 24;
            this.LBusuario.Text = "Usuario *";
            // 
            // TBusuario
            // 
            this.TBusuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBusuario.Location = new System.Drawing.Point(375, 306);
            this.TBusuario.Name = "TBusuario";
            this.TBusuario.Size = new System.Drawing.Size(357, 30);
            this.TBusuario.TabIndex = 25;
            // 
            // BTCancelar
            // 
            this.BTCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTCancelar.Image = global::Menu.Properties.Resources.sair2;
            this.BTCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BTCancelar.Location = new System.Drawing.Point(691, 9);
            this.BTCancelar.Name = "BTCancelar";
            this.BTCancelar.Size = new System.Drawing.Size(95, 39);
            this.BTCancelar.TabIndex = 7;
            this.BTCancelar.Text = "Sair";
            this.BTCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.TTinfo.SetToolTip(this.BTCancelar, "Sair do sistema");
            this.BTCancelar.UseVisualStyleBackColor = true;
            this.BTCancelar.Click += new System.EventHandler(this.BTCancelar_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::Menu.Properties.Resources.apagar;
            this.button1.Location = new System.Drawing.Point(531, 440);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(143, 39);
            this.button1.TabIndex = 6;
            this.button1.Text = "Limpar";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // BTSalvar
            // 
            this.BTSalvar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Cyan;
            this.BTSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTSalvar.Image = global::Menu.Properties.Resources.save;
            this.BTSalvar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTSalvar.Location = new System.Drawing.Point(170, 440);
            this.BTSalvar.Name = "BTSalvar";
            this.BTSalvar.Size = new System.Drawing.Size(134, 39);
            this.BTSalvar.TabIndex = 5;
            this.BTSalvar.Text = "Salvar";
            this.BTSalvar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BTSalvar.UseVisualStyleBackColor = true;
            this.BTSalvar.Click += new System.EventHandler(this.BTSalvar_Click);
            // 
            // TTinfo
            // 
            this.TTinfo.AutomaticDelay = 100;
            this.TTinfo.AutoPopDelay = 5000;
            this.TTinfo.InitialDelay = 100;
            this.TTinfo.IsBalloon = true;
            this.TTinfo.ReshowDelay = 20;
            this.TTinfo.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // LBtelefone
            // 
            this.LBtelefone.AutoSize = true;
            this.LBtelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBtelefone.Location = new System.Drawing.Point(86, 279);
            this.LBtelefone.Name = "LBtelefone";
            this.LBtelefone.Size = new System.Drawing.Size(97, 24);
            this.LBtelefone.TabIndex = 26;
            this.LBtelefone.Text = "Telefone *";
            // 
            // TBDataNascimento
            // 
            this.TBDataNascimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBDataNascimento.Location = new System.Drawing.Point(487, 121);
            this.TBDataNascimento.Mask = "00/00/0000";
            this.TBDataNascimento.Name = "TBDataNascimento";
            this.TBDataNascimento.Size = new System.Drawing.Size(245, 29);
            this.TBDataNascimento.TabIndex = 28;
            this.TBDataNascimento.ValidatingType = typeof(System.DateTime);
            // 
            // TBtelefone
            // 
            this.TBtelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBtelefone.Location = new System.Drawing.Point(108, 306);
            this.TBtelefone.Mask = "(00) 00000-9999";
            this.TBtelefone.Name = "TBtelefone";
            this.TBtelefone.Size = new System.Drawing.Size(249, 29);
            this.TBtelefone.TabIndex = 29;
            // 
            // FormCadCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 517);
            this.Controls.Add(this.TBtelefone);
            this.Controls.Add(this.TBDataNascimento);
            this.Controls.Add(this.LBtelefone);
            this.Controls.Add(this.TBusuario);
            this.Controls.Add(this.LBusuario);
            this.Controls.Add(this.TBvalor);
            this.Controls.Add(this.LBvalor);
            this.Controls.Add(this.LBMensagemBranco);
            this.Controls.Add(this.TBsenha2);
            this.Controls.Add(this.LBsenha2);
            this.Controls.Add(this.TBsenha1);
            this.Controls.Add(this.LBsenha1);
            this.Controls.Add(this.RBfeminino);
            this.Controls.Add(this.RBmasculino);
            this.Controls.Add(this.CBtipoCota);
            this.Controls.Add(this.LBtipoCota);
            this.Controls.Add(this.TTBemail);
            this.Controls.Add(this.LBemail);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BTCancelar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BTSalvar);
            this.Controls.Add(this.LBsexo);
            this.Controls.Add(this.LBdataNascimento);
            this.Controls.Add(this.TBNome);
            this.Controls.Add(this.LBnome);
            this.Name = "FormCadCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form Cadastro de Clientes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolTip TTErro;
        private System.Windows.Forms.ToolTip TTWarning;
        private System.Windows.Forms.Label LBnome;
        private System.Windows.Forms.TextBox TBNome;
        private System.Windows.Forms.Label LBdataNascimento;
        private System.Windows.Forms.Label LBsexo;
        private System.Windows.Forms.Button BTSalvar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button BTCancelar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label LBemail;
        private System.Windows.Forms.TextBox TTBemail;
        private System.Windows.Forms.Label LBtipoCota;
        private System.Windows.Forms.ComboBox CBtipoCota;
        private System.Windows.Forms.RadioButton RBmasculino;
        private System.Windows.Forms.RadioButton RBfeminino;
        private System.Windows.Forms.Label LBsenha1;
        private System.Windows.Forms.TextBox TBsenha1;
        private System.Windows.Forms.Label LBsenha2;
        private System.Windows.Forms.TextBox TBsenha2;
        private System.Windows.Forms.Label LBMensagemBranco;
        private System.Windows.Forms.Label LBvalor;
        private System.Windows.Forms.TextBox TBvalor;
        private System.Windows.Forms.Label LBusuario;
        private System.Windows.Forms.TextBox TBusuario;
        private System.Windows.Forms.ToolTip TTinfo;
        private System.Windows.Forms.Label LBtelefone;
        private System.Windows.Forms.MaskedTextBox TBDataNascimento;
        private System.Windows.Forms.MaskedTextBox TBtelefone;
    }
}