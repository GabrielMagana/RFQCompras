
namespace RFQCompras
{
    partial class frmPrincipal
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lnkTabla = new System.Windows.Forms.LinkLabel();
            this.lnkRFQ = new System.Windows.Forms.LinkLabel();
            this.dtCotizacion = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIdRFQ = new System.Windows.Forms.TextBox();
            this.cmbcomprador2 = new System.Windows.Forms.ComboBox();
            this.cmbestatus = new System.Windows.Forms.ComboBox();
            this.btnCambiaEstatus = new System.Windows.Forms.Button();
            this.btnCambiar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.dtFechaTabla = new System.Windows.Forms.DateTimePicker();
            this.label13 = new System.Windows.Forms.Label();
            this.txtObservaciones = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtMonto = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtDiasTabla = new System.Windows.Forms.TextBox();
            this.txtDiasTotales = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dtFechasolicitan = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.txtdescription = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbtipo = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtsolicitante = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dtfecha = new System.Windows.Forms.DateTimePicker();
            this.label14 = new System.Windows.Forms.Label();
            this.btnHistorial = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.cmbComprador = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ucDetails1 = new RFQCompras.ucDetails();
            this.flowLayoutPanel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.ucListado1);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 68);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(254, 382);
            this.flowLayoutPanel1.TabIndex = 2;
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
            this.ucListado1.Size = new System.Drawing.Size(241, 118);
            this.ucListado1.Solicitante = null;
            this.ucListado1.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.AutoSize = true;
            this.groupBox2.Controls.Add(this.lnkTabla);
            this.groupBox2.Controls.Add(this.lnkRFQ);
            this.groupBox2.Controls.Add(this.dtCotizacion);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtIdRFQ);
            this.groupBox2.Controls.Add(this.cmbcomprador2);
            this.groupBox2.Controls.Add(this.cmbestatus);
            this.groupBox2.Controls.Add(this.btnCambiaEstatus);
            this.groupBox2.Controls.Add(this.btnCambiar);
            this.groupBox2.Controls.Add(this.btnCancelar);
            this.groupBox2.Controls.Add(this.dtFechaTabla);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.txtObservaciones);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.txtMonto);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.txtDiasTabla);
            this.groupBox2.Controls.Add(this.txtDiasTotales);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.dtFechasolicitan);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtdescription);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.cmbtipo);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtsolicitante);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox2.Location = new System.Drawing.Point(278, 68);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(522, 382);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Detalles";
            // 
            // lnkTabla
            // 
            this.lnkTabla.AutoSize = true;
            this.lnkTabla.Location = new System.Drawing.Point(4, 321);
            this.lnkTabla.Name = "lnkTabla";
            this.lnkTabla.Size = new System.Drawing.Size(99, 13);
            this.lnkTabla.TabIndex = 30;
            this.lnkTabla.TabStop = true;
            this.lnkTabla.Text = "Tabla Comparativa.";
            this.lnkTabla.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkTabla_LinkClicked);
            // 
            // lnkRFQ
            // 
            this.lnkRFQ.AutoSize = true;
            this.lnkRFQ.Location = new System.Drawing.Point(4, 292);
            this.lnkRFQ.Name = "lnkRFQ";
            this.lnkRFQ.Size = new System.Drawing.Size(29, 13);
            this.lnkRFQ.TabIndex = 29;
            this.lnkRFQ.TabStop = true;
            this.lnkRFQ.Text = "RFQ";
            this.lnkRFQ.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkRFQ_LinkClicked);
            // 
            // dtCotizacion
            // 
            this.dtCotizacion.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtCotizacion.Location = new System.Drawing.Point(158, 154);
            this.dtCotizacion.Name = "dtCotizacion";
            this.dtCotizacion.Size = new System.Drawing.Size(145, 20);
            this.dtCotizacion.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(155, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 27;
            this.label1.Text = "Fecha Cotización:";
            // 
            // txtIdRFQ
            // 
            this.txtIdRFQ.Enabled = false;
            this.txtIdRFQ.Location = new System.Drawing.Point(37, 19);
            this.txtIdRFQ.Name = "txtIdRFQ";
            this.txtIdRFQ.Size = new System.Drawing.Size(100, 20);
            this.txtIdRFQ.TabIndex = 26;
            this.txtIdRFQ.Visible = false;
            // 
            // cmbcomprador2
            // 
            this.cmbcomprador2.FormattingEnabled = true;
            this.cmbcomprador2.Location = new System.Drawing.Point(158, 55);
            this.cmbcomprador2.Name = "cmbcomprador2";
            this.cmbcomprador2.Size = new System.Drawing.Size(145, 21);
            this.cmbcomprador2.TabIndex = 6;
            // 
            // cmbestatus
            // 
            this.cmbestatus.FormattingEnabled = true;
            this.cmbestatus.Location = new System.Drawing.Point(309, 55);
            this.cmbestatus.Name = "cmbestatus";
            this.cmbestatus.Size = new System.Drawing.Size(115, 21);
            this.cmbestatus.TabIndex = 25;
            // 
            // btnCambiaEstatus
            // 
            this.btnCambiaEstatus.Location = new System.Drawing.Point(92, 337);
            this.btnCambiaEstatus.Name = "btnCambiaEstatus";
            this.btnCambiaEstatus.Size = new System.Drawing.Size(137, 30);
            this.btnCambiaEstatus.TabIndex = 24;
            this.btnCambiaEstatus.UseVisualStyleBackColor = true;
            this.btnCambiaEstatus.Click += new System.EventHandler(this.btnCambiaEstatus_Click);
            // 
            // btnCambiar
            // 
            this.btnCambiar.Location = new System.Drawing.Point(235, 337);
            this.btnCambiar.Name = "btnCambiar";
            this.btnCambiar.Size = new System.Drawing.Size(137, 30);
            this.btnCambiar.TabIndex = 23;
            this.btnCambiar.Text = "Cambiar RFQ";
            this.btnCambiar.UseVisualStyleBackColor = true;
            this.btnCambiar.Click += new System.EventHandler(this.btnCambiar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(378, 337);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(137, 30);
            this.btnCancelar.TabIndex = 22;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // dtFechaTabla
            // 
            this.dtFechaTabla.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtFechaTabla.Location = new System.Drawing.Point(7, 195);
            this.dtFechaTabla.Name = "dtFechaTabla";
            this.dtFechaTabla.Size = new System.Drawing.Size(145, 20);
            this.dtFechaTabla.TabIndex = 21;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 177);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(131, 13);
            this.label13.TabIndex = 20;
            this.label13.Text = "Fecha Tabla comparativa:";
            // 
            // txtObservaciones
            // 
            this.txtObservaciones.Location = new System.Drawing.Point(7, 245);
            this.txtObservaciones.Multiline = true;
            this.txtObservaciones.Name = "txtObservaciones";
            this.txtObservaciones.Size = new System.Drawing.Size(509, 31);
            this.txtObservaciones.TabIndex = 19;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(7, 222);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(81, 13);
            this.label12.TabIndex = 18;
            this.label12.Text = "Observaciones:";
            // 
            // txtMonto
            // 
            this.txtMonto.Location = new System.Drawing.Point(309, 154);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Size = new System.Drawing.Size(86, 20);
            this.txtMonto.TabIndex = 17;
            this.txtMonto.TextChanged += new System.EventHandler(this.txtMonto_TextChanged);
            this.txtMonto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMonto_KeyPress);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(306, 136);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(55, 13);
            this.label11.TabIndex = 16;
            this.label11.Text = "Monto ($):";
            // 
            // txtDiasTabla
            // 
            this.txtDiasTabla.Location = new System.Drawing.Point(418, 195);
            this.txtDiasTabla.Name = "txtDiasTabla";
            this.txtDiasTabla.Size = new System.Drawing.Size(86, 20);
            this.txtDiasTabla.TabIndex = 15;
            // 
            // txtDiasTotales
            // 
            this.txtDiasTotales.Location = new System.Drawing.Point(416, 154);
            this.txtDiasTotales.Name = "txtDiasTotales";
            this.txtDiasTotales.Size = new System.Drawing.Size(86, 20);
            this.txtDiasTotales.TabIndex = 14;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(415, 177);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 13);
            this.label10.TabIndex = 13;
            this.label10.Text = "Dias Tabla:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(415, 136);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = "Dias Totales:";
            // 
            // dtFechasolicitan
            // 
            this.dtFechasolicitan.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFechasolicitan.Location = new System.Drawing.Point(7, 154);
            this.dtFechasolicitan.Name = "dtFechasolicitan";
            this.dtFechasolicitan.Size = new System.Drawing.Size(145, 20);
            this.dtFechasolicitan.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 136);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "Fecha solicitud:";
            // 
            // txtdescription
            // 
            this.txtdescription.Location = new System.Drawing.Point(7, 94);
            this.txtdescription.Multiline = true;
            this.txtdescription.Name = "txtdescription";
            this.txtdescription.Size = new System.Drawing.Size(509, 35);
            this.txtdescription.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 78);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Descripción:";
            // 
            // cmbtipo
            // 
            this.cmbtipo.FormattingEnabled = true;
            this.cmbtipo.Location = new System.Drawing.Point(430, 55);
            this.cmbtipo.Name = "cmbtipo";
            this.cmbtipo.Size = new System.Drawing.Size(86, 21);
            this.cmbtipo.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(427, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Tipo";
            // 
            // txtsolicitante
            // 
            this.txtsolicitante.Location = new System.Drawing.Point(7, 55);
            this.txtsolicitante.Name = "txtsolicitante";
            this.txtsolicitante.Size = new System.Drawing.Size(145, 20);
            this.txtsolicitante.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(306, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Estatus";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(155, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Comprador";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Solicitante";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.LightGray;
            this.groupBox3.Controls.Add(this.dtfecha);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.btnHistorial);
            this.groupBox3.Controls.Add(this.btnActualizar);
            this.groupBox3.Controls.Add(this.cmbComprador);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.pictureBox1);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox3.Location = new System.Drawing.Point(0, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(800, 68);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            // 
            // dtfecha
            // 
            this.dtfecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtfecha.Location = new System.Drawing.Point(361, 40);
            this.dtfecha.Name = "dtfecha";
            this.dtfecha.Size = new System.Drawing.Size(200, 20);
            this.dtfecha.TabIndex = 5;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(294, 44);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(40, 13);
            this.label14.TabIndex = 4;
            this.label14.Text = "Fecha:";
            // 
            // btnHistorial
            // 
            this.btnHistorial.Image = global::RFQCompras.Properties.Resources.Managerfiles_historyfiles_administradordearchivos_6225;
            this.btnHistorial.Location = new System.Drawing.Point(738, 7);
            this.btnHistorial.Name = "btnHistorial";
            this.btnHistorial.Size = new System.Drawing.Size(50, 53);
            this.btnHistorial.TabIndex = 2;
            this.btnHistorial.UseVisualStyleBackColor = true;
            this.btnHistorial.Click += new System.EventHandler(this.btnHistorial_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnActualizar.BackColor = System.Drawing.Color.Transparent;
            this.btnActualizar.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.btnActualizar.FlatAppearance.BorderSize = 0;
            this.btnActualizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnActualizar.Image = global::RFQCompras.Properties.Resources._1485969921_5_refresh_78908;
            this.btnActualizar.Location = new System.Drawing.Point(690, 12);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(42, 37);
            this.btnActualizar.TabIndex = 3;
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click_1);
            // 
            // cmbComprador
            // 
            this.cmbComprador.FormattingEnabled = true;
            this.cmbComprador.Location = new System.Drawing.Point(361, 12);
            this.cmbComprador.Name = "cmbComprador";
            this.cmbComprador.Size = new System.Drawing.Size(200, 21);
            this.cmbComprador.TabIndex = 0;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(294, 16);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(61, 13);
            this.label15.TabIndex = 1;
            this.label15.Text = "Comprador:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::RFQCompras.Properties.Resources.oficial;
            this.pictureBox1.Location = new System.Drawing.Point(12, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(276, 51);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // ucDetails1
            // 
            this.ucDetails1.Comprador = 0;
            this.ucDetails1.Descripcion = null;
            this.ucDetails1.Estatus = 0;
            this.ucDetails1.FechaSolicitud = new System.DateTime(((long)(0)));
            this.ucDetails1.FechaTabla = new System.DateTime(((long)(0)));
            this.ucDetails1.IDRFQ = 0;
            this.ucDetails1.Location = new System.Drawing.Point(3, 3);
            this.ucDetails1.Monto = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.ucDetails1.Name = "ucDetails1";
            this.ucDetails1.Observaciones = null;
            this.ucDetails1.Size = new System.Drawing.Size(529, 384);
            this.ucDetails1.Solicitante = null;
            this.ucDetails1.TabIndex = 0;
            this.ucDetails1.Tipo = 0;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.groupBox3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPrincipal";
            this.Text = "RFQ";
            this.Load += new System.EventHandler(this.test_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ucDetails ucDetails1;
        private ucListado ucListado1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtIdRFQ;
        private System.Windows.Forms.ComboBox cmbcomprador2;
        private System.Windows.Forms.ComboBox cmbestatus;
        private System.Windows.Forms.Button btnCambiaEstatus;
        private System.Windows.Forms.Button btnCambiar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.DateTimePicker dtFechaTabla;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtObservaciones;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtMonto;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtDiasTabla;
        private System.Windows.Forms.TextBox txtDiasTotales;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dtFechasolicitan;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtdescription;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbtipo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtsolicitante;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DateTimePicker dtfecha;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnHistorial;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.ComboBox cmbComprador;
        private System.Windows.Forms.Label label15;
        protected System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DateTimePicker dtCotizacion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel lnkTabla;
        private System.Windows.Forms.LinkLabel lnkRFQ;
    }
}