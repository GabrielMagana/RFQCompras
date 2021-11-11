
namespace RFQCompras
{
    partial class ucListado
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
            this.txtIdrfq = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtsolicitante = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtarea = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtestatus = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtIdrfq
            // 
            this.txtIdrfq.Enabled = false;
            this.txtIdrfq.Location = new System.Drawing.Point(36, 3);
            this.txtIdrfq.Name = "txtIdrfq";
            this.txtIdrfq.Size = new System.Drawing.Size(33, 20);
            this.txtIdrfq.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Descripcion:";
            // 
            // txtDescription
            // 
            this.txtDescription.Enabled = false;
            this.txtDescription.Location = new System.Drawing.Point(78, 29);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(152, 38);
            this.txtDescription.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Solicitante:";
            // 
            // txtsolicitante
            // 
            this.txtsolicitante.Enabled = false;
            this.txtsolicitante.Location = new System.Drawing.Point(78, 70);
            this.txtsolicitante.Multiline = true;
            this.txtsolicitante.Name = "txtsolicitante";
            this.txtsolicitante.Size = new System.Drawing.Size(152, 17);
            this.txtsolicitante.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Área:";
            // 
            // txtarea
            // 
            this.txtarea.Enabled = false;
            this.txtarea.Location = new System.Drawing.Point(78, 93);
            this.txtarea.Multiline = true;
            this.txtarea.Name = "txtarea";
            this.txtarea.Size = new System.Drawing.Size(152, 21);
            this.txtarea.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(88, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Estatus:";
            // 
            // txtestatus
            // 
            this.txtestatus.Enabled = false;
            this.txtestatus.Location = new System.Drawing.Point(150, 3);
            this.txtestatus.Name = "txtestatus";
            this.txtestatus.Size = new System.Drawing.Size(80, 20);
            this.txtestatus.TabIndex = 9;
            // 
            // ucListado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.txtestatus);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtarea);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtsolicitante);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtIdrfq);
            this.Name = "ucListado";
            this.Size = new System.Drawing.Size(238, 118);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtIdrfq;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtsolicitante;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtarea;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtestatus;
    }
}
