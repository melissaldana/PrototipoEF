
namespace CapaVista
{
    partial class frmMovimientosBancarios
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
            this.label2 = new System.Windows.Forms.Label();
            this.cmbBanco = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbActivo = new System.Windows.Forms.RadioButton();
            this.rdbInactivo = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.txtdescripcion = new System.Windows.Forms.TextBox();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.txtCombo = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.navegador1 = new DLL.nav.navegador();
            this.dvgMovimientosBancarios = new System.Windows.Forms.DataGridView();
            this.cmbCuenta = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtComboCuenta = new System.Windows.Forms.TextBox();
            this.cmbMovimiento = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtComboMovimiento = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dateEmision = new System.Windows.Forms.DateTimePicker();
            this.dateVencimiento = new System.Windows.Forms.DateTimePicker();
            this.txtemision = new System.Windows.Forms.TextBox();
            this.txtVence = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgMovimientosBancarios)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(45, 414);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 85;
            this.label2.Text = "Descripcion:";
            // 
            // cmbBanco
            // 
            this.cmbBanco.FormattingEnabled = true;
            this.cmbBanco.Location = new System.Drawing.Point(128, 201);
            this.cmbBanco.Name = "cmbBanco";
            this.cmbBanco.Size = new System.Drawing.Size(121, 21);
            this.cmbBanco.TabIndex = 84;
            this.cmbBanco.SelectedIndexChanged += new System.EventHandler(this.cmbBanco_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.rdbActivo);
            this.groupBox1.Controls.Add(this.rdbInactivo);
            this.groupBox1.Location = new System.Drawing.Point(19, 477);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 99);
            this.groupBox1.TabIndex = 82;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Estado";
            // 
            // rdbActivo
            // 
            this.rdbActivo.AutoSize = true;
            this.rdbActivo.Location = new System.Drawing.Point(23, 29);
            this.rdbActivo.Name = "rdbActivo";
            this.rdbActivo.Size = new System.Drawing.Size(55, 17);
            this.rdbActivo.TabIndex = 46;
            this.rdbActivo.TabStop = true;
            this.rdbActivo.Text = "Activo";
            this.rdbActivo.UseVisualStyleBackColor = true;
            // 
            // rdbInactivo
            // 
            this.rdbInactivo.AutoSize = true;
            this.rdbInactivo.Location = new System.Drawing.Point(23, 62);
            this.rdbInactivo.Name = "rdbInactivo";
            this.rdbInactivo.Size = new System.Drawing.Size(63, 17);
            this.rdbInactivo.TabIndex = 47;
            this.rdbInactivo.TabStop = true;
            this.rdbInactivo.Text = "Inactivo";
            this.rdbInactivo.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(45, 374);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 79;
            this.label6.Text = "Nombre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(43, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(235, 25);
            this.label1.TabIndex = 76;
            this.label1.Text = "Movimientos Bancarios";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.BackColor = System.Drawing.Color.Transparent;
            this.lblNombre.Location = new System.Drawing.Point(54, 208);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(41, 13);
            this.lblNombre.TabIndex = 75;
            this.lblNombre.Text = "Banco:";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.BackColor = System.Drawing.Color.Transparent;
            this.lblID.Location = new System.Drawing.Point(71, 172);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(21, 13);
            this.lblID.TabIndex = 74;
            this.lblID.Tag = "";
            this.lblID.Text = "ID:";
            // 
            // txtEstado
            // 
            this.txtEstado.Location = new System.Drawing.Point(252, 506);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(45, 20);
            this.txtEstado.TabIndex = 83;
            this.txtEstado.Tag = "estado";
            this.txtEstado.Visible = false;
            // 
            // txtdescripcion
            // 
            this.txtdescripcion.Location = new System.Drawing.Point(125, 407);
            this.txtdescripcion.Name = "txtdescripcion";
            this.txtdescripcion.Size = new System.Drawing.Size(121, 20);
            this.txtdescripcion.TabIndex = 86;
            this.txtdescripcion.Tag = "descripcion";
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(125, 367);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(121, 20);
            this.txtnombre.TabIndex = 80;
            this.txtnombre.Tag = "nombre";
            // 
            // txtCombo
            // 
            this.txtCombo.Location = new System.Drawing.Point(265, 201);
            this.txtCombo.Name = "txtCombo";
            this.txtCombo.Size = new System.Drawing.Size(41, 20);
            this.txtCombo.TabIndex = 87;
            this.txtCombo.Visible = false;
            this.txtCombo.TextChanged += new System.EventHandler(this.txtBanco_TextChanged);
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(128, 172);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(121, 20);
            this.txtID.TabIndex = 78;
            this.txtID.Tag = "pkIdMovimientosBancarios";
            // 
            // navegador1
            // 
            this.navegador1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.navegador1.Location = new System.Drawing.Point(-1, 0);
            this.navegador1.Name = "navegador1";
            this.navegador1.Size = new System.Drawing.Size(1189, 87);
            this.navegador1.TabIndex = 81;
            // 
            // dvgMovimientosBancarios
            // 
            this.dvgMovimientosBancarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgMovimientosBancarios.Location = new System.Drawing.Point(396, 129);
            this.dvgMovimientosBancarios.Name = "dvgMovimientosBancarios";
            this.dvgMovimientosBancarios.ReadOnly = true;
            this.dvgMovimientosBancarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dvgMovimientosBancarios.Size = new System.Drawing.Size(735, 448);
            this.dvgMovimientosBancarios.TabIndex = 77;
            // 
            // cmbCuenta
            // 
            this.cmbCuenta.FormattingEnabled = true;
            this.cmbCuenta.Location = new System.Drawing.Point(125, 236);
            this.cmbCuenta.Name = "cmbCuenta";
            this.cmbCuenta.Size = new System.Drawing.Size(121, 21);
            this.cmbCuenta.TabIndex = 89;
            this.cmbCuenta.TextChanged += new System.EventHandler(this.cmbCuenta_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(54, 236);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 88;
            this.label3.Text = "Cuenta:";
            // 
            // txtComboCuenta
            // 
            this.txtComboCuenta.Location = new System.Drawing.Point(265, 236);
            this.txtComboCuenta.Name = "txtComboCuenta";
            this.txtComboCuenta.Size = new System.Drawing.Size(41, 20);
            this.txtComboCuenta.TabIndex = 90;
            this.txtComboCuenta.Visible = false;
            this.txtComboCuenta.TextChanged += new System.EventHandler(this.txtCuenta_TextChanged);
            // 
            // cmbMovimiento
            // 
            this.cmbMovimiento.FormattingEnabled = true;
            this.cmbMovimiento.Location = new System.Drawing.Point(125, 263);
            this.cmbMovimiento.Name = "cmbMovimiento";
            this.cmbMovimiento.Size = new System.Drawing.Size(121, 21);
            this.cmbMovimiento.TabIndex = 92;
            this.cmbMovimiento.TextChanged += new System.EventHandler(this.cmbTipoMov_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(16, 270);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 13);
            this.label4.TabIndex = 91;
            this.label4.Text = "Tipo de Movimiento:";
            // 
            // txtComboMovimiento
            // 
            this.txtComboMovimiento.Location = new System.Drawing.Point(265, 263);
            this.txtComboMovimiento.Name = "txtComboMovimiento";
            this.txtComboMovimiento.Size = new System.Drawing.Size(41, 20);
            this.txtComboMovimiento.TabIndex = 93;
            this.txtComboMovimiento.Visible = false;
            this.txtComboMovimiento.TextChanged += new System.EventHandler(this.txtTipoMov_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(16, 307);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 13);
            this.label5.TabIndex = 94;
            this.label5.Text = "Fecha de Emision:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(3, 330);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(116, 13);
            this.label7.TabIndex = 95;
            this.label7.Text = "Fecha de Vencimiento:";
            // 
            // dateEmision
            // 
            this.dateEmision.Location = new System.Drawing.Point(125, 301);
            this.dateEmision.Name = "dateEmision";
            this.dateEmision.Size = new System.Drawing.Size(200, 20);
            this.dateEmision.TabIndex = 96;
            this.dateEmision.ValueChanged += new System.EventHandler(this.dtFechaEmision_ValueChanged);
            // 
            // dateVencimiento
            // 
            this.dateVencimiento.Location = new System.Drawing.Point(125, 328);
            this.dateVencimiento.Name = "dateVencimiento";
            this.dateVencimiento.Size = new System.Drawing.Size(200, 20);
            this.dateVencimiento.TabIndex = 97;
            this.dateVencimiento.ValueChanged += new System.EventHandler(this.dtVencimiento_ValueChanged);
            // 
            // txtemision
            // 
            this.txtemision.Location = new System.Drawing.Point(349, 301);
            this.txtemision.Name = "txtemision";
            this.txtemision.Size = new System.Drawing.Size(41, 20);
            this.txtemision.TabIndex = 98;
            this.txtemision.Tag = "fechaEmision";
            this.txtemision.Visible = false;
            this.txtemision.TextChanged += new System.EventHandler(this.txtFechaEm_TextChanged);
            // 
            // txtVence
            // 
            this.txtVence.Location = new System.Drawing.Point(349, 331);
            this.txtVence.Name = "txtVence";
            this.txtVence.Size = new System.Drawing.Size(41, 20);
            this.txtVence.TabIndex = 99;
            this.txtVence.Tag = "fechaVencimiento";
            this.txtVence.Visible = false;
            this.txtVence.TextChanged += new System.EventHandler(this.txtVencimientoTextChanged);
            // 
            // frmMovimientosBancarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1188, 620);
            this.Controls.Add(this.dateVencimiento);
            this.Controls.Add(this.dateEmision);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbMovimiento);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtComboMovimiento);
            this.Controls.Add(this.cmbCuenta);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtComboCuenta);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbBanco);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.txtEstado);
            this.Controls.Add(this.txtdescripcion);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.txtemision);
            this.Controls.Add(this.txtVence);
            this.Controls.Add(this.txtCombo);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.navegador1);
            this.Controls.Add(this.dvgMovimientosBancarios);
            this.Name = "frmMovimientosBancarios";
            this.Text = "104 Movimientos Bancarios";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgMovimientosBancarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbBanco;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbActivo;
        private System.Windows.Forms.RadioButton rdbInactivo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.TextBox txtdescripcion;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.TextBox txtCombo;
        private System.Windows.Forms.TextBox txtID;
        private DLL.nav.navegador navegador1;
        private System.Windows.Forms.DataGridView dvgMovimientosBancarios;
        private System.Windows.Forms.ComboBox cmbCuenta;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtComboCuenta;
        private System.Windows.Forms.ComboBox cmbMovimiento;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtComboMovimiento;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dateEmision;
        private System.Windows.Forms.DateTimePicker dateVencimiento;
        private System.Windows.Forms.TextBox txtemision;
        private System.Windows.Forms.TextBox txtVence;
    }
}