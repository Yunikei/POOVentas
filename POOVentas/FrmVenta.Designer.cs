namespace POOVentas
{
    partial class FrmVenta
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
            label1 = new Label();
            label2 = new Label();
            DgvConceptos = new DataGridView();
            btnAgregar = new Button();
            TxtCantidad = new TextBox();
            TxtDescripcion = new TextBox();
            label3 = new Label();
            TxtValorUnitario = new TextBox();
            TxtTotal = new TextBox();
            BtnEfectivo = new Button();
            BtnTarjeta = new Button();
            label4 = new Label();
            TxtCortesia = new TextBox();
            ((System.ComponentModel.ISupportInitialize)DgvConceptos).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveCaption;
            label1.Location = new Point(36, 30);
            label1.Name = "label1";
            label1.Size = new Size(55, 15);
            label1.TabIndex = 0;
            label1.Text = "Cantidad";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.GradientInactiveCaption;
            label2.Location = new Point(36, 69);
            label2.Name = "label2";
            label2.Size = new Size(69, 15);
            label2.TabIndex = 1;
            label2.Text = "Descripción";
            label2.Click += label2_Click;
            // 
            // DgvConceptos
            // 
            DgvConceptos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvConceptos.Location = new Point(36, 190);
            DgvConceptos.Margin = new Padding(3, 2, 3, 2);
            DgvConceptos.Name = "DgvConceptos";
            DgvConceptos.RowHeadersWidth = 51;
            DgvConceptos.Size = new Size(547, 237);
            DgvConceptos.TabIndex = 2;
            DgvConceptos.TabStop = false;
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = SystemColors.ActiveCaption;
            btnAgregar.Location = new Point(501, 127);
            btnAgregar.Margin = new Padding(3, 2, 3, 2);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(82, 29);
            btnAgregar.TabIndex = 3;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // TxtCantidad
            // 
            TxtCantidad.Location = new Point(123, 27);
            TxtCantidad.Margin = new Padding(3, 2, 3, 2);
            TxtCantidad.Name = "TxtCantidad";
            TxtCantidad.Size = new Size(110, 23);
            TxtCantidad.TabIndex = 0;
            // 
            // TxtDescripcion
            // 
            TxtDescripcion.Location = new Point(123, 69);
            TxtDescripcion.Margin = new Padding(3, 2, 3, 2);
            TxtDescripcion.Multiline = true;
            TxtDescripcion.Name = "TxtDescripcion";
            TxtDescripcion.Size = new Size(254, 26);
            TxtDescripcion.TabIndex = 1;
            TxtDescripcion.TextChanged += TxtDescripcion_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.GradientActiveCaption;
            label3.Location = new Point(36, 116);
            label3.Name = "label3";
            label3.Size = new Size(78, 15);
            label3.TabIndex = 0;
            label3.Text = "Valor Unitario";
            // 
            // TxtValorUnitario
            // 
            TxtValorUnitario.Location = new Point(123, 116);
            TxtValorUnitario.Margin = new Padding(3, 2, 3, 2);
            TxtValorUnitario.Name = "TxtValorUnitario";
            TxtValorUnitario.Size = new Size(110, 23);
            TxtValorUnitario.TabIndex = 2;
            // 
            // TxtTotal
            // 
            TxtTotal.Location = new Point(473, 438);
            TxtTotal.Margin = new Padding(3, 2, 3, 2);
            TxtTotal.Name = "TxtTotal";
            TxtTotal.ReadOnly = true;
            TxtTotal.Size = new Size(110, 23);
            TxtTotal.TabIndex = 4;
            TxtTotal.Text = "0.00";
            TxtTotal.TextAlign = HorizontalAlignment.Center;
            // 
            // BtnEfectivo
            // 
            BtnEfectivo.BackColor = SystemColors.InfoText;
            BtnEfectivo.ForeColor = SystemColors.ButtonHighlight;
            BtnEfectivo.Location = new Point(270, 439);
            BtnEfectivo.Margin = new Padding(3, 2, 3, 2);
            BtnEfectivo.Name = "BtnEfectivo";
            BtnEfectivo.Size = new Size(82, 22);
            BtnEfectivo.TabIndex = 5;
            BtnEfectivo.Text = "Efectivo";
            BtnEfectivo.UseVisualStyleBackColor = false;
            BtnEfectivo.Click += BtnEfectivo_Click;
            // 
            // BtnTarjeta
            // 
            BtnTarjeta.BackColor = SystemColors.InfoText;
            BtnTarjeta.ForeColor = SystemColors.ButtonHighlight;
            BtnTarjeta.Location = new Point(370, 439);
            BtnTarjeta.Margin = new Padding(3, 2, 3, 2);
            BtnTarjeta.Name = "BtnTarjeta";
            BtnTarjeta.Size = new Size(82, 22);
            BtnTarjeta.TabIndex = 6;
            BtnTarjeta.Text = "Tarjeta";
            BtnTarjeta.UseVisualStyleBackColor = false;
            BtnTarjeta.Click += BtnTarjeta_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.ActiveCaption;
            label4.Location = new Point(41, 442);
            label4.Name = "label4";
            label4.Size = new Size(50, 15);
            label4.TabIndex = 7;
            label4.Text = "Cortesía";
            label4.Click += label4_Click;
            // 
            // TxtCortesia
            // 
            TxtCortesia.Location = new Point(97, 439);
            TxtCortesia.Margin = new Padding(3, 2, 3, 2);
            TxtCortesia.Name = "TxtCortesia";
            TxtCortesia.Size = new Size(110, 23);
            TxtCortesia.TabIndex = 8;
            TxtCortesia.TextChanged += TxtCortesia_TextChanged;
            // 
            // FrmVenta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.mi_amiga_y_yo;
            ClientSize = new Size(626, 476);
            Controls.Add(TxtCortesia);
            Controls.Add(label4);
            Controls.Add(BtnTarjeta);
            Controls.Add(BtnEfectivo);
            Controls.Add(TxtTotal);
            Controls.Add(TxtDescripcion);
            Controls.Add(TxtValorUnitario);
            Controls.Add(TxtCantidad);
            Controls.Add(btnAgregar);
            Controls.Add(DgvConceptos);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FrmVenta";
            Text = "FrmVenta";
            Load += FrmVenta_Load;
            ((System.ComponentModel.ISupportInitialize)DgvConceptos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private DataGridView DgvConceptos;
        private Button btnAgregar;
        private TextBox TxtCantidad;
        private TextBox TxtDescripcion;
        private Label label3;
        private TextBox TxtValorUnitario;
        private TextBox TxtTotal;
        private Button BtnEfectivo;
        private Button BtnTarjeta;
        private Label label4;
        private TextBox TxtCortesia;
    }
}