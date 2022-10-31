namespace Menu
{
    partial class FmostraDados
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BTCancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(110, 270);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(583, 31);
            this.label4.TabIndex = 10;
            this.label4.Text = "CADASTRADO REALIZADO  COM SUCESSO";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Menu.Properties.Resources.feito;
            this.pictureBox1.Location = new System.Drawing.Point(328, 110);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(127, 143);
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // BTCancelar
            // 
            this.BTCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTCancelar.Image = global::Menu.Properties.Resources.sair2;
            this.BTCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BTCancelar.Location = new System.Drawing.Point(658, 12);
            this.BTCancelar.Name = "BTCancelar";
            this.BTCancelar.Size = new System.Drawing.Size(95, 39);
            this.BTCancelar.TabIndex = 20;
            this.BTCancelar.Text = "Sair";
            this.BTCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.BTCancelar.UseVisualStyleBackColor = true;
            this.BTCancelar.Click += new System.EventHandler(this.BTCancelar_Click);
            // 
            // FmostraDados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 517);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BTCancelar);
            this.Controls.Add(this.label4);
            this.MaximizeBox = false;
            this.Name = "FmostraDados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mostra dados";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BTCancelar;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}