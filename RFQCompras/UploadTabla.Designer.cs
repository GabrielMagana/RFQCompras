
namespace RFQCompras
{
    partial class UploadTabla
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnGuardarDoc = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIdrfq = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGuardarDoc
            // 
            this.btnGuardarDoc.Location = new System.Drawing.Point(39, 188);
            this.btnGuardarDoc.Name = "btnGuardarDoc";
            this.btnGuardarDoc.Size = new System.Drawing.Size(63, 23);
            this.btnGuardarDoc.TabIndex = 0;
            this.btnGuardarDoc.Text = "Guardar";
            this.btnGuardarDoc.UseVisualStyleBackColor = true;
            this.btnGuardarDoc.Click += new System.EventHandler(this.btnGuardarDoc_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Id RFQ:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Descripción:";
            // 
            // txtIdrfq
            // 
            this.txtIdrfq.Enabled = false;
            this.txtIdrfq.Location = new System.Drawing.Point(91, 72);
            this.txtIdrfq.Name = "txtIdrfq";
            this.txtIdrfq.Size = new System.Drawing.Size(128, 20);
            this.txtIdrfq.TabIndex = 4;
            // 
            // txtDescription
            // 
            this.txtDescription.Enabled = false;
            this.txtDescription.Location = new System.Drawing.Point(91, 105);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(128, 50);
            this.txtDescription.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = global::RFQCompras.Properties.Resources.oficial;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(222, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(123, 188);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(63, 23);
            this.btnCancelar.TabIndex = 8;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // UploadTabla
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.txtIdrfq);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGuardarDoc);
            this.Name = "UploadTabla";
            this.Size = new System.Drawing.Size(222, 262);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button btnGuardarDoc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIdrfq;
        private System.Windows.Forms.TextBox txtDescription;
        protected System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Button btnCancelar;
    }
}
