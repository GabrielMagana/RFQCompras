
namespace RFQCompras
{
    partial class CargarDocumento
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.uploadTabla1 = new RFQCompras.UploadTabla();
            this.txtruta = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.uploadTabla1);
            this.flowLayoutPanel1.Controls.Add(this.txtruta);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(255, 257);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // uploadTabla1
            // 
            this.uploadTabla1.Descripcion = null;
            this.uploadTabla1.Dock = System.Windows.Forms.DockStyle.Top;
            this.uploadTabla1.IDRFQ = 0;
            this.uploadTabla1.Location = new System.Drawing.Point(3, 3);
            this.uploadTabla1.Name = "uploadTabla1";
            this.uploadTabla1.Size = new System.Drawing.Size(247, 248);
            this.uploadTabla1.TabIndex = 0;
            // 
            // txtruta
            // 
            this.txtruta.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtruta.Enabled = false;
            this.txtruta.Location = new System.Drawing.Point(3, 257);
            this.txtruta.Name = "txtruta";
            this.txtruta.Size = new System.Drawing.Size(100, 20);
            this.txtruta.TabIndex = 1;
            this.txtruta.Visible = false;
            // 
            // CargarDocumento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ClientSize = new System.Drawing.Size(255, 257);
            this.Controls.Add(this.flowLayoutPanel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CargarDocumento";
            this.Text = "Cargar documento";
            this.Load += new System.EventHandler(this.CargarDocumento_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private UploadTabla uploadTabla1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TextBox txtruta;
    }
}