namespace Menu
{
    partial class FormRemoveAssociado1
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label4 = new System.Windows.Forms.Label();
            this.TBpesquisaAssociado = new System.Windows.Forms.TextBox();
            this.BTCancelar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.BTSalvar = new System.Windows.Forms.Button();
            this.BTbuscar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(13, 129);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(775, 251);
            this.listView1.TabIndex = 53;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Nome";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Sexo";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Email";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Data de Nascimento";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Usuario";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(237, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(279, 26);
            this.label4.TabIndex = 52;
            this.label4.Text = "REMOVER ASSOCIADO";
            // 
            // TBpesquisaAssociado
            // 
            this.TBpesquisaAssociado.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBpesquisaAssociado.Location = new System.Drawing.Point(13, 90);
            this.TBpesquisaAssociado.Name = "TBpesquisaAssociado";
            this.TBpesquisaAssociado.Size = new System.Drawing.Size(635, 32);
            this.TBpesquisaAssociado.TabIndex = 54;
            // 
            // BTCancelar
            // 
            this.BTCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTCancelar.Image = global::Menu.Properties.Resources.sair2;
            this.BTCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BTCancelar.Location = new System.Drawing.Point(693, 16);
            this.BTCancelar.Name = "BTCancelar";
            this.BTCancelar.Size = new System.Drawing.Size(95, 39);
            this.BTCancelar.TabIndex = 58;
            this.BTCancelar.Text = "Sair";
            this.BTCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.BTCancelar.UseVisualStyleBackColor = true;
            this.BTCancelar.Click += new System.EventHandler(this.BTCancelar_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::Menu.Properties.Resources.apagar;
            this.button1.Location = new System.Drawing.Point(492, 396);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(143, 39);
            this.button1.TabIndex = 57;
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
            this.BTSalvar.Location = new System.Drawing.Point(131, 396);
            this.BTSalvar.Name = "BTSalvar";
            this.BTSalvar.Size = new System.Drawing.Size(134, 39);
            this.BTSalvar.TabIndex = 56;
            this.BTSalvar.Text = "Salvar";
            this.BTSalvar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BTSalvar.UseVisualStyleBackColor = true;
            // 
            // BTbuscar
            // 
            this.BTbuscar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Cyan;
            this.BTbuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTbuscar.Image = global::Menu.Properties.Resources.lupa;
            this.BTbuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTbuscar.Location = new System.Drawing.Point(654, 86);
            this.BTbuscar.Name = "BTbuscar";
            this.BTbuscar.Size = new System.Drawing.Size(134, 39);
            this.BTbuscar.TabIndex = 55;
            this.BTbuscar.Text = "Buscar";
            this.BTbuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BTbuscar.UseVisualStyleBackColor = true;
            // 
            // FormRemoveAssociado1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BTCancelar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BTSalvar);
            this.Controls.Add(this.BTbuscar);
            this.Controls.Add(this.TBpesquisaAssociado);
            this.Name = "FormRemoveAssociado1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "REMOVER ASSOCIADO";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BTCancelar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button BTSalvar;
        private System.Windows.Forms.Button BTbuscar;
        private System.Windows.Forms.TextBox TBpesquisaAssociado;
    }
}