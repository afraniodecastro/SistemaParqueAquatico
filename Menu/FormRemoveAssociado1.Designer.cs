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
            this.components = new System.ComponentModel.Container();
            this.LVdados = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label4 = new System.Windows.Forms.Label();
            this.TBbuscar = new System.Windows.Forms.TextBox();
            this.BTCancelar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.BTRemover = new System.Windows.Forms.Button();
            this.BTbuscar = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LVdados
            // 
            this.LVdados.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.LVdados.ContextMenuStrip = this.contextMenuStrip1;
            this.LVdados.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LVdados.HideSelection = false;
            this.LVdados.Location = new System.Drawing.Point(13, 129);
            this.LVdados.Name = "LVdados";
            this.LVdados.Size = new System.Drawing.Size(911, 441);
            this.LVdados.TabIndex = 53;
            this.LVdados.UseCompatibleStateImageBehavior = false;
            this.LVdados.SelectedIndexChanged += new System.EventHandler(this.LVdados_SelectedIndexChanged);
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
            this.label4.Location = new System.Drawing.Point(368, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(279, 26);
            this.label4.TabIndex = 52;
            this.label4.Text = "REMOVER ASSOCIADO";
            // 
            // TBbuscar
            // 
            this.TBbuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBbuscar.Location = new System.Drawing.Point(13, 90);
            this.TBbuscar.Name = "TBbuscar";
            this.TBbuscar.Size = new System.Drawing.Size(771, 32);
            this.TBbuscar.TabIndex = 54;
            // 
            // BTCancelar
            // 
            this.BTCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTCancelar.Image = global::Menu.Properties.Resources.sair2;
            this.BTCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BTCancelar.Location = new System.Drawing.Point(829, 16);
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
            this.button1.Location = new System.Drawing.Point(641, 597);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(143, 39);
            this.button1.TabIndex = 57;
            this.button1.Text = "Limpar";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // BTRemover
            // 
            this.BTRemover.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Cyan;
            this.BTRemover.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTRemover.Image = global::Menu.Properties.Resources.cancelar;
            this.BTRemover.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTRemover.Location = new System.Drawing.Point(215, 597);
            this.BTRemover.Name = "BTRemover";
            this.BTRemover.Size = new System.Drawing.Size(134, 39);
            this.BTRemover.TabIndex = 56;
            this.BTRemover.Text = "Remover";
            this.BTRemover.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BTRemover.UseCompatibleTextRendering = true;
            this.BTRemover.UseVisualStyleBackColor = true;
            this.BTRemover.Click += new System.EventHandler(this.BTRemover_Click);
            // 
            // BTbuscar
            // 
            this.BTbuscar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Cyan;
            this.BTbuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTbuscar.Image = global::Menu.Properties.Resources.lupa;
            this.BTbuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTbuscar.Location = new System.Drawing.Point(790, 86);
            this.BTbuscar.Name = "BTbuscar";
            this.BTbuscar.Size = new System.Drawing.Size(134, 39);
            this.BTbuscar.TabIndex = 55;
            this.BTbuscar.Text = "Buscar";
            this.BTbuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BTbuscar.UseVisualStyleBackColor = true;
            this.BTbuscar.Click += new System.EventHandler(this.BTbuscar_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(110, 26);
            this.contextMenuStrip1.Click += new System.EventHandler(this.contextMenuStrip1_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem1.Text = "Excluir";
            // 
            // FormRemoveAssociado1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(936, 668);
            this.Controls.Add(this.LVdados);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BTCancelar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BTRemover);
            this.Controls.Add(this.BTbuscar);
            this.Controls.Add(this.TBbuscar);
            this.Name = "FormRemoveAssociado1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "REMOVER ASSOCIADO";
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView LVdados;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BTCancelar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button BTRemover;
        private System.Windows.Forms.Button BTbuscar;
        private System.Windows.Forms.TextBox TBbuscar;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
    }
}