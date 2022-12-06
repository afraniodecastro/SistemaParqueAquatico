namespace Menu
{
    partial class Faltera
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
            this.label4 = new System.Windows.Forms.Label();
            this.LVdados = new System.Windows.Forms.ListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TBbuscar = new System.Windows.Forms.TextBox();
            this.BTCancelar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.BTAlterar = new System.Windows.Forms.Button();
            this.BTbuscar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(236, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(284, 26);
            this.label4.TabIndex = 35;
            this.label4.Text = "ALTERAR ASSOCIADOS";
            // 
            // LVdados
            // 
            this.LVdados.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader1});
            this.LVdados.HideSelection = false;
            this.LVdados.Location = new System.Drawing.Point(12, 122);
            this.LVdados.MultiSelect = false;
            this.LVdados.Name = "LVdados";
            this.LVdados.Size = new System.Drawing.Size(775, 251);
            this.LVdados.TabIndex = 36;
            this.LVdados.UseCompatibleStateImageBehavior = false;
            this.LVdados.SelectedIndexChanged += new System.EventHandler(this.LVdados_SelectedIndexChanged);
            // 
            // ID
            // 
            this.ID.Text = "ID";
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
            // TBbuscar
            // 
            this.TBbuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBbuscar.Location = new System.Drawing.Point(12, 87);
            this.TBbuscar.Name = "TBbuscar";
            this.TBbuscar.Size = new System.Drawing.Size(635, 27);
            this.TBbuscar.TabIndex = 37;
            // 
            // BTCancelar
            // 
            this.BTCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTCancelar.Image = global::Menu.Properties.Resources.sair2;
            this.BTCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BTCancelar.Location = new System.Drawing.Point(692, 9);
            this.BTCancelar.Name = "BTCancelar";
            this.BTCancelar.Size = new System.Drawing.Size(95, 39);
            this.BTCancelar.TabIndex = 51;
            this.BTCancelar.Text = "Sair";
            this.BTCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.BTCancelar.UseVisualStyleBackColor = true;
            this.BTCancelar.Click += new System.EventHandler(this.BTCancelar_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::Menu.Properties.Resources.apagar;
            this.button1.Location = new System.Drawing.Point(491, 389);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(143, 39);
            this.button1.TabIndex = 50;
            this.button1.Text = "Limpar";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // BTAlterar
            // 
            this.BTAlterar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Cyan;
            this.BTAlterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTAlterar.Image = global::Menu.Properties.Resources.lapis;
            this.BTAlterar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTAlterar.Location = new System.Drawing.Point(130, 389);
            this.BTAlterar.Name = "BTAlterar";
            this.BTAlterar.Size = new System.Drawing.Size(134, 39);
            this.BTAlterar.TabIndex = 49;
            this.BTAlterar.Text = "Alterar";
            this.BTAlterar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BTAlterar.UseVisualStyleBackColor = true;
            this.BTAlterar.Click += new System.EventHandler(this.BTAlterar_Click);
            // 
            // BTbuscar
            // 
            this.BTbuscar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Cyan;
            this.BTbuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTbuscar.Image = global::Menu.Properties.Resources.lupa;
            this.BTbuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTbuscar.Location = new System.Drawing.Point(653, 79);
            this.BTbuscar.Name = "BTbuscar";
            this.BTbuscar.Size = new System.Drawing.Size(134, 39);
            this.BTbuscar.TabIndex = 48;
            this.BTbuscar.Text = "Buscar";
            this.BTbuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BTbuscar.UseVisualStyleBackColor = true;
            this.BTbuscar.Click += new System.EventHandler(this.BTbuscar_Click);
            // 
            // Faltera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BTCancelar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BTAlterar);
            this.Controls.Add(this.BTbuscar);
            this.Controls.Add(this.TBbuscar);
            this.Controls.Add(this.LVdados);
            this.Controls.Add(this.label4);
            this.MaximizeBox = false;
            this.Name = "Faltera";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "+";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListView LVdados;
        private System.Windows.Forms.TextBox TBbuscar;
        private System.Windows.Forms.Button BTbuscar;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button BTAlterar;
        private System.Windows.Forms.Button BTCancelar;
        private System.Windows.Forms.ColumnHeader columnHeader1;
    }
}