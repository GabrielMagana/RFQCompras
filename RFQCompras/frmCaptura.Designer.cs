namespace RFQCompras
{
    partial class frmCaptura
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
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpFechaIns = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtObservaciones = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.cmbSubCategoria = new System.Windows.Forms.ComboBox();
            this.txtProveedorSugerido = new System.Windows.Forms.TextBox();
            this.txtUso = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.dtgCompras = new System.Windows.Forms.DataGridView();
            this.Qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unit = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serialNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Marca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AgregarImagen = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Image = new System.Windows.Forms.DataGridViewImageColumn();
            this.ColNombreDoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreExt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtEmailITSQE = new System.Windows.Forms.TextBox();
            this.txtGerenteITSQE = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cmbArea = new System.Windows.Forms.ComboBox();
            this.txtSolicitante = new System.Windows.Forms.TextBox();
            this.txtEmailSolicitante = new System.Windows.Forms.TextBox();
            this.txtManager = new System.Windows.Forms.TextBox();
            this.txtEmailManager = new System.Windows.Forms.TextBox();
            this.btnRFQ = new System.Windows.Forms.Button();
            this.btnLimpia = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgCompras)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(405, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(325, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Solicitud de Cotización Bien o Producto";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::RFQCompras.Properties.Resources.oficial;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(295, 60);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Fecha de solicitud:";
            // 
            // dtpFechaIns
            // 
            this.dtpFechaIns.CustomFormat = "dd-MM-yyyy";
            this.dtpFechaIns.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaIns.Location = new System.Drawing.Point(121, 94);
            this.dtpFechaIns.Name = "dtpFechaIns";
            this.dtpFechaIns.Size = new System.Drawing.Size(215, 20);
            this.dtpFechaIns.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Correo:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Nombre del solicitante:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Área:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(472, 46);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(169, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Request for Quotation (RFQ)";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(286, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(219, 20);
            this.label8.TabIndex = 9;
            this.label8.Text = "Información del requerimiento";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Location = new System.Drawing.Point(17, 193);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(764, 55);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(190, 36);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(457, 13);
            this.label9.TabIndex = 11;
            this.label9.Text = "Descripción detallada del bien o producto (Tipo de material, medidas, color, text" +
    "ura, formato, etc.)";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtObservaciones);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.cmbSubCategoria);
            this.groupBox2.Controls.Add(this.txtProveedorSugerido);
            this.groupBox2.Controls.Add(this.txtUso);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.dtgCompras);
            this.groupBox2.Location = new System.Drawing.Point(17, 254);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(764, 413);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            // 
            // txtObservaciones
            // 
            this.txtObservaciones.Location = new System.Drawing.Point(478, 269);
            this.txtObservaciones.Multiline = true;
            this.txtObservaciones.Name = "txtObservaciones";
            this.txtObservaciones.Size = new System.Drawing.Size(280, 79);
            this.txtObservaciones.TabIndex = 24;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(475, 251);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(68, 13);
            this.label17.TabIndex = 23;
            this.label17.Text = "Comentarios:";
            // 
            // cmbSubCategoria
            // 
            this.cmbSubCategoria.FormattingEnabled = true;
            this.cmbSubCategoria.Location = new System.Drawing.Point(114, 297);
            this.cmbSubCategoria.Name = "cmbSubCategoria";
            this.cmbSubCategoria.Size = new System.Drawing.Size(268, 21);
            this.cmbSubCategoria.TabIndex = 16;
            this.cmbSubCategoria.SelectedIndexChanged += new System.EventHandler(this.cmbSubCategoria_SelectedIndexChanged);
            // 
            // txtProveedorSugerido
            // 
            this.txtProveedorSugerido.Location = new System.Drawing.Point(114, 335);
            this.txtProveedorSugerido.Multiline = true;
            this.txtProveedorSugerido.Name = "txtProveedorSugerido";
            this.txtProveedorSugerido.Size = new System.Drawing.Size(268, 49);
            this.txtProveedorSugerido.TabIndex = 22;
            // 
            // txtUso
            // 
            this.txtUso.Location = new System.Drawing.Point(114, 237);
            this.txtUso.Multiline = true;
            this.txtUso.Name = "txtUso";
            this.txtUso.Size = new System.Drawing.Size(268, 49);
            this.txtUso.TabIndex = 21;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.Red;
            this.label16.Location = new System.Drawing.Point(6, 387);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(698, 13);
            this.label16.TabIndex = 20;
            this.label16.Text = "Si esta solicitud tiene relación en materia ambiental o Tecnologia IT, debe tener" +
    " aprobación por parte del departamento de SQE o IT adicionalmente. ";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 335);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(102, 13);
            this.label13.TabIndex = 17;
            this.label13.Text = "Proveedor sugerido:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 300);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(76, 13);
            this.label12.TabIndex = 16;
            this.label12.Text = "Sub categoria:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 245);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(36, 13);
            this.label11.TabIndex = 15;
            this.label11.Text = "Titulo:";
            // 
            // dtgCompras
            // 
            this.dtgCompras.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgCompras.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dtgCompras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgCompras.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Qty,
            this.unit,
            this.Description,
            this.serialNumber,
            this.Marca,
            this.AgregarImagen,
            this.Image,
            this.ColNombreDoc,
            this.NombreExt});
            this.dtgCompras.Location = new System.Drawing.Point(6, 19);
            this.dtgCompras.Name = "dtgCompras";
            this.dtgCompras.Size = new System.Drawing.Size(752, 212);
            this.dtgCompras.TabIndex = 0;
            this.dtgCompras.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgCompras_CellContentClick);
            this.dtgCompras.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dtgCompras_CellFormatting);
            this.dtgCompras.CellValidated += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgCompras_CellValidated);
            this.dtgCompras.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dtgCompras_CellValidating);
            // 
            // Qty
            // 
            this.Qty.HeaderText = "Cantidad requerida";
            this.Qty.Name = "Qty";
            // 
            // unit
            // 
            this.unit.HeaderText = "Unidad";
            this.unit.Name = "unit";
            this.unit.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.unit.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Description
            // 
            this.Description.HeaderText = "Descripción";
            this.Description.Name = "Description";
            // 
            // serialNumber
            // 
            this.serialNumber.HeaderText = "Modelo o número de parte";
            this.serialNumber.Name = "serialNumber";
            // 
            // Marca
            // 
            this.Marca.HeaderText = "Marca Sugerida";
            this.Marca.Name = "Marca";
            // 
            // AgregarImagen
            // 
            this.AgregarImagen.HeaderText = "Agregar";
            this.AgregarImagen.Name = "AgregarImagen";
            this.AgregarImagen.UseColumnTextForButtonValue = true;
            // 
            // Image
            // 
            this.Image.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Image.FillWeight = 300F;
            this.Image.HeaderText = "Imagen / fotografia";
            this.Image.Name = "Image";
            // 
            // ColNombreDoc
            // 
            this.ColNombreDoc.HeaderText = "NombreDoc";
            this.ColNombreDoc.Name = "ColNombreDoc";
            this.ColNombreDoc.Visible = false;
            // 
            // NombreExt
            // 
            this.NombreExt.HeaderText = "Extension";
            this.NombreExt.Name = "NombreExt";
            this.NombreExt.Visible = false;
            // 
            // txtEmailITSQE
            // 
            this.txtEmailITSQE.Enabled = false;
            this.txtEmailITSQE.Location = new System.Drawing.Point(539, 167);
            this.txtEmailITSQE.Name = "txtEmailITSQE";
            this.txtEmailITSQE.Size = new System.Drawing.Size(215, 20);
            this.txtEmailITSQE.TabIndex = 28;
            // 
            // txtGerenteITSQE
            // 
            this.txtGerenteITSQE.Enabled = false;
            this.txtGerenteITSQE.Location = new System.Drawing.Point(553, 143);
            this.txtGerenteITSQE.Name = "txtGerenteITSQE";
            this.txtGerenteITSQE.Size = new System.Drawing.Size(201, 20);
            this.txtGerenteITSQE.TabIndex = 27;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(406, 174);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(127, 13);
            this.label15.TabIndex = 19;
            this.label15.Text = "Correo gerente IT o SQE:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(406, 146);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(148, 13);
            this.label14.TabIndex = 18;
            this.label14.Text = "Nombre gerente de IT o SQE:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(406, 101);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(127, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Nombre gerente del área:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(406, 126);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(80, 13);
            this.label10.TabIndex = 14;
            this.label10.Text = "Correo gerente:";
            // 
            // cmbArea
            // 
            this.cmbArea.FormattingEnabled = true;
            this.cmbArea.Location = new System.Drawing.Point(121, 120);
            this.cmbArea.Name = "cmbArea";
            this.cmbArea.Size = new System.Drawing.Size(215, 21);
            this.cmbArea.TabIndex = 15;
            // 
            // txtSolicitante
            // 
            this.txtSolicitante.Enabled = false;
            this.txtSolicitante.Location = new System.Drawing.Point(121, 149);
            this.txtSolicitante.Name = "txtSolicitante";
            this.txtSolicitante.Size = new System.Drawing.Size(215, 20);
            this.txtSolicitante.TabIndex = 23;
            // 
            // txtEmailSolicitante
            // 
            this.txtEmailSolicitante.Enabled = false;
            this.txtEmailSolicitante.Location = new System.Drawing.Point(121, 174);
            this.txtEmailSolicitante.Name = "txtEmailSolicitante";
            this.txtEmailSolicitante.Size = new System.Drawing.Size(215, 20);
            this.txtEmailSolicitante.TabIndex = 24;
            // 
            // txtManager
            // 
            this.txtManager.Enabled = false;
            this.txtManager.Location = new System.Drawing.Point(539, 96);
            this.txtManager.Name = "txtManager";
            this.txtManager.Size = new System.Drawing.Size(215, 20);
            this.txtManager.TabIndex = 25;
            // 
            // txtEmailManager
            // 
            this.txtEmailManager.Enabled = false;
            this.txtEmailManager.Location = new System.Drawing.Point(539, 119);
            this.txtEmailManager.Name = "txtEmailManager";
            this.txtEmailManager.Size = new System.Drawing.Size(215, 20);
            this.txtEmailManager.TabIndex = 26;
            // 
            // btnRFQ
            // 
            this.btnRFQ.Location = new System.Drawing.Point(598, 72);
            this.btnRFQ.Name = "btnRFQ";
            this.btnRFQ.Size = new System.Drawing.Size(75, 23);
            this.btnRFQ.TabIndex = 27;
            this.btnRFQ.Text = "Generar RFQ.";
            this.btnRFQ.UseVisualStyleBackColor = true;
            this.btnRFQ.Click += new System.EventHandler(this.btnRFQ_Click);
            // 
            // btnLimpia
            // 
            this.btnLimpia.Location = new System.Drawing.Point(679, 71);
            this.btnLimpia.Name = "btnLimpia";
            this.btnLimpia.Size = new System.Drawing.Size(75, 23);
            this.btnLimpia.TabIndex = 28;
            this.btnLimpia.Text = "Limpiar";
            this.btnLimpia.UseVisualStyleBackColor = true;
            this.btnLimpia.Click += new System.EventHandler(this.btnLimpia_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // frmCaptura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(793, 689);
            this.Controls.Add(this.txtEmailITSQE);
            this.Controls.Add(this.btnLimpia);
            this.Controls.Add(this.txtGerenteITSQE);
            this.Controls.Add(this.btnRFQ);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtEmailManager);
            this.Controls.Add(this.txtManager);
            this.Controls.Add(this.txtEmailSolicitante);
            this.Controls.Add(this.txtSolicitante);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.cmbArea);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtpFechaIns);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "frmCaptura";
            this.Text = "Captura de RFQ";
            this.Load += new System.EventHandler(this.frmCaptura_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgCompras)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpFechaIns;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridView dtgCompras;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtEmailITSQE;
        private System.Windows.Forms.TextBox txtGerenteITSQE;
        private System.Windows.Forms.ComboBox cmbSubCategoria;
        private System.Windows.Forms.TextBox txtProveedorSugerido;
        private System.Windows.Forms.TextBox txtUso;
        private System.Windows.Forms.ComboBox cmbArea;
        private System.Windows.Forms.TextBox txtSolicitante;
        private System.Windows.Forms.TextBox txtEmailSolicitante;
        private System.Windows.Forms.TextBox txtManager;
        private System.Windows.Forms.TextBox txtEmailManager;
        private System.Windows.Forms.Button btnRFQ;
        private System.Windows.Forms.Button btnLimpia;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox txtObservaciones;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.DataGridViewTextBoxColumn Qty;
        private System.Windows.Forms.DataGridViewComboBoxColumn unit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn serialNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn Marca;
        private System.Windows.Forms.DataGridViewButtonColumn AgregarImagen;
        private System.Windows.Forms.DataGridViewImageColumn Image;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColNombreDoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreExt;
    }
}