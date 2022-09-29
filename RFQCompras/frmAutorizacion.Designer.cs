namespace RFQCompras
{
    partial class frmAutorizacion
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
            this.ucListado1 = new RFQCompras.ucListado();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtGerentealternoCla = new System.Windows.Forms.TextBox();
            this.txtsubCategoria = new System.Windows.Forms.TextBox();
            this.txtEstatus = new System.Windows.Forms.TextBox();
            this.txtComprador = new System.Windows.Forms.TextBox();
            this.dtgProductosRFQ = new System.Windows.Forms.DataGridView();
            this.txtemailGerentealterno = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtGerentealterno = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtProvSugerido = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIdRFQ = new System.Windows.Forms.TextBox();
            this.btnAutoriza = new System.Windows.Forms.Button();
            this.btnRechazar = new System.Windows.Forms.Button();
            this.txtObservaciones = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.dtFechasolicitan = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.txtdescription = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtsolicitante = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgProductosRFQ)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Controls.Add(this.ucListado1);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(8, 127);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(276, 512);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // ucListado1
            // 
            this.ucListado1.Area = null;
            this.ucListado1.BackColor = System.Drawing.Color.Gainsboro;
            this.ucListado1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ucListado1.Descripcion = null;
            this.ucListado1.Estatus = null;
            this.ucListado1.IDRFQ = 0;
            this.ucListado1.Location = new System.Drawing.Point(3, 3);
            this.ucListado1.Name = "ucListado1";
            this.ucListado1.Size = new System.Drawing.Size(257, 118);
            this.ucListado1.Solicitante = null;
            this.ucListado1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox1.Image = global::RFQCompras.Properties.Resources.oficial;
            this.pictureBox1.Location = new System.Drawing.Point(8, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(276, 59);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // dtpFecha
            // 
            this.dtpFecha.CustomFormat = "dd-MM-yyyy";
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFecha.Location = new System.Drawing.Point(49, 85);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(235, 20);
            this.dtpFecha.TabIndex = 5;
            this.dtpFecha.ValueChanged += new System.EventHandler(this.dtpFecha_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Fecha:";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.AutoSize = true;
            this.groupBox2.Controls.Add(this.txtGerentealternoCla);
            this.groupBox2.Controls.Add(this.txtsubCategoria);
            this.groupBox2.Controls.Add(this.txtEstatus);
            this.groupBox2.Controls.Add(this.txtComprador);
            this.groupBox2.Controls.Add(this.dtgProductosRFQ);
            this.groupBox2.Controls.Add(this.txtemailGerentealterno);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.txtGerentealterno);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtProvSugerido);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtIdRFQ);
            this.groupBox2.Controls.Add(this.btnAutoriza);
            this.groupBox2.Controls.Add(this.btnRechazar);
            this.groupBox2.Controls.Add(this.txtObservaciones);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.dtFechasolicitan);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtdescription);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtsolicitante);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox2.Location = new System.Drawing.Point(290, 35);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(543, 614);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Detalles";
            // 
            // txtGerentealternoCla
            // 
            this.txtGerentealternoCla.Enabled = false;
            this.txtGerentealternoCla.Location = new System.Drawing.Point(292, 119);
            this.txtGerentealternoCla.Name = "txtGerentealternoCla";
            this.txtGerentealternoCla.Size = new System.Drawing.Size(100, 20);
            this.txtGerentealternoCla.TabIndex = 44;
            this.txtGerentealternoCla.Visible = false;
            // 
            // txtsubCategoria
            // 
            this.txtsubCategoria.Enabled = false;
            this.txtsubCategoria.Location = new System.Drawing.Point(292, 77);
            this.txtsubCategoria.Name = "txtsubCategoria";
            this.txtsubCategoria.Size = new System.Drawing.Size(245, 20);
            this.txtsubCategoria.TabIndex = 43;
            // 
            // txtEstatus
            // 
            this.txtEstatus.Enabled = false;
            this.txtEstatus.Location = new System.Drawing.Point(14, 154);
            this.txtEstatus.Name = "txtEstatus";
            this.txtEstatus.Size = new System.Drawing.Size(210, 20);
            this.txtEstatus.TabIndex = 42;
            // 
            // txtComprador
            // 
            this.txtComprador.Enabled = false;
            this.txtComprador.Location = new System.Drawing.Point(14, 105);
            this.txtComprador.Name = "txtComprador";
            this.txtComprador.Size = new System.Drawing.Size(210, 20);
            this.txtComprador.TabIndex = 41;
            // 
            // dtgProductosRFQ
            // 
            this.dtgProductosRFQ.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgProductosRFQ.Location = new System.Drawing.Point(14, 245);
            this.dtgProductosRFQ.Name = "dtgProductosRFQ";
            this.dtgProductosRFQ.Size = new System.Drawing.Size(521, 176);
            this.dtgProductosRFQ.TabIndex = 40;
            // 
            // txtemailGerentealterno
            // 
            this.txtemailGerentealterno.Enabled = false;
            this.txtemailGerentealterno.Location = new System.Drawing.Point(292, 161);
            this.txtemailGerentealterno.Name = "txtemailGerentealterno";
            this.txtemailGerentealterno.Size = new System.Drawing.Size(245, 20);
            this.txtemailGerentealterno.TabIndex = 39;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(289, 142);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(88, 16);
            this.label10.TabIndex = 38;
            this.label10.Text = "Email IT/SQE";
            // 
            // txtGerentealterno
            // 
            this.txtGerentealterno.Enabled = false;
            this.txtGerentealterno.Location = new System.Drawing.Point(292, 119);
            this.txtGerentealterno.Name = "txtGerentealterno";
            this.txtGerentealterno.Size = new System.Drawing.Size(245, 20);
            this.txtGerentealterno.TabIndex = 37;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(289, 100);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(102, 16);
            this.label9.TabIndex = 36;
            this.label9.Text = "Gerente IT/SQE";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(11, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(20, 16);
            this.label6.TabIndex = 35;
            this.label6.Text = "ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(289, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 16);
            this.label3.TabIndex = 33;
            this.label3.Text = "SubCategoria";
            // 
            // txtProvSugerido
            // 
            this.txtProvSugerido.Enabled = false;
            this.txtProvSugerido.Location = new System.Drawing.Point(14, 443);
            this.txtProvSugerido.Multiline = true;
            this.txtProvSugerido.Name = "txtProvSugerido";
            this.txtProvSugerido.Size = new System.Drawing.Size(523, 38);
            this.txtProvSugerido.TabIndex = 32;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 424);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 16);
            this.label2.TabIndex = 31;
            this.label2.Text = "Proveedor Sugerido:";
            // 
            // txtIdRFQ
            // 
            this.txtIdRFQ.Enabled = false;
            this.txtIdRFQ.Location = new System.Drawing.Point(124, 19);
            this.txtIdRFQ.Name = "txtIdRFQ";
            this.txtIdRFQ.Size = new System.Drawing.Size(100, 20);
            this.txtIdRFQ.TabIndex = 26;
            // 
            // btnAutoriza
            // 
            this.btnAutoriza.Location = new System.Drawing.Point(280, 562);
            this.btnAutoriza.Name = "btnAutoriza";
            this.btnAutoriza.Size = new System.Drawing.Size(97, 33);
            this.btnAutoriza.TabIndex = 24;
            this.btnAutoriza.Text = "Autorizar";
            this.btnAutoriza.UseVisualStyleBackColor = true;
            this.btnAutoriza.Click += new System.EventHandler(this.btnAutoriza_Click);
            // 
            // btnRechazar
            // 
            this.btnRechazar.Location = new System.Drawing.Point(400, 562);
            this.btnRechazar.Name = "btnRechazar";
            this.btnRechazar.Size = new System.Drawing.Size(117, 33);
            this.btnRechazar.TabIndex = 23;
            this.btnRechazar.Text = "Rechazar";
            this.btnRechazar.UseVisualStyleBackColor = true;
            this.btnRechazar.Click += new System.EventHandler(this.btnRechazar_Click);
            // 
            // txtObservaciones
            // 
            this.txtObservaciones.Location = new System.Drawing.Point(14, 505);
            this.txtObservaciones.Multiline = true;
            this.txtObservaciones.Name = "txtObservaciones";
            this.txtObservaciones.Size = new System.Drawing.Size(523, 51);
            this.txtObservaciones.TabIndex = 19;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(11, 484);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(112, 18);
            this.label12.TabIndex = 18;
            this.label12.Text = "Observaciones:";
            // 
            // dtFechasolicitan
            // 
            this.dtFechasolicitan.Enabled = false;
            this.dtFechasolicitan.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFechasolicitan.Location = new System.Drawing.Point(292, 30);
            this.dtFechasolicitan.Name = "dtFechasolicitan";
            this.dtFechasolicitan.Size = new System.Drawing.Size(143, 20);
            this.dtFechasolicitan.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(289, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 16);
            this.label8.TabIndex = 10;
            this.label8.Text = "Fecha solicitud:";
            // 
            // txtdescription
            // 
            this.txtdescription.Enabled = false;
            this.txtdescription.Location = new System.Drawing.Point(12, 196);
            this.txtdescription.Multiline = true;
            this.txtdescription.Name = "txtdescription";
            this.txtdescription.Size = new System.Drawing.Size(523, 42);
            this.txtdescription.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(11, 177);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 16);
            this.label7.TabIndex = 8;
            this.label7.Text = "Descripción:";
            // 
            // txtsolicitante
            // 
            this.txtsolicitante.Enabled = false;
            this.txtsolicitante.Location = new System.Drawing.Point(14, 58);
            this.txtsolicitante.Name = "txtsolicitante";
            this.txtsolicitante.Size = new System.Drawing.Size(210, 20);
            this.txtsolicitante.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(11, 134);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 16);
            this.label5.TabIndex = 2;
            this.label5.Text = "Estatus";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(11, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 16);
            this.label4.TabIndex = 1;
            this.label4.Text = "Comprador";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(11, 39);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(69, 16);
            this.label14.TabIndex = 0;
            this.label14.Text = "Solicitante";
            // 
            // frmAutorizacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 642);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "frmAutorizacion";
            this.Text = "Autorización de RFQ´s";
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgProductosRFQ)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private ucListado ucListado1;
        protected System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtProvSugerido;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIdRFQ;
        private System.Windows.Forms.Button btnAutoriza;
        private System.Windows.Forms.Button btnRechazar;
        private System.Windows.Forms.TextBox txtObservaciones;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DateTimePicker dtFechasolicitan;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtdescription;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtsolicitante;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtemailGerentealterno;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtGerentealterno;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dtgProductosRFQ;
        private System.Windows.Forms.TextBox txtsubCategoria;
        private System.Windows.Forms.TextBox txtEstatus;
        private System.Windows.Forms.TextBox txtComprador;
        private System.Windows.Forms.TextBox txtGerentealternoCla;
    }
}