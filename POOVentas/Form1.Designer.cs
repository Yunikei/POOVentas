namespace POOVentas
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnVentaCredito = new Button();
            btnVentaContado = new Button();
            btnVentaCortesia = new Button();
            SuspendLayout();
            // 
            // btnVentaCredito
            // 
            btnVentaCredito.BackColor = SystemColors.ControlText;
            btnVentaCredito.ForeColor = SystemColors.ButtonHighlight;
            btnVentaCredito.Location = new Point(145, 79);
            btnVentaCredito.Margin = new Padding(3, 2, 3, 2);
            btnVentaCredito.Name = "btnVentaCredito";
            btnVentaCredito.Size = new Size(107, 58);
            btnVentaCredito.TabIndex = 0;
            btnVentaCredito.Text = "VentaCrédito";
            btnVentaCredito.UseVisualStyleBackColor = false;
            btnVentaCredito.Click += btnVentaCredito_Click;
            // 
            // btnVentaContado
            // 
            btnVentaContado.BackColor = SystemColors.ActiveCaptionText;
            btnVentaContado.ForeColor = SystemColors.ButtonHighlight;
            btnVentaContado.Location = new Point(417, 79);
            btnVentaContado.Margin = new Padding(3, 2, 3, 2);
            btnVentaContado.Name = "btnVentaContado";
            btnVentaContado.Size = new Size(106, 58);
            btnVentaContado.TabIndex = 1;
            btnVentaContado.Text = "VentaContado";
            btnVentaContado.UseVisualStyleBackColor = false;
            btnVentaContado.Click += btnVentaContado_Click;
            // 
            // btnVentaCortesia
            // 
            btnVentaCortesia.BackColor = SystemColors.ControlText;
            btnVentaCortesia.ForeColor = SystemColors.ButtonHighlight;
            btnVentaCortesia.Location = new Point(283, 263);
            btnVentaCortesia.Margin = new Padding(3, 2, 3, 2);
            btnVentaCortesia.Name = "btnVentaCortesia";
            btnVentaCortesia.Size = new Size(107, 58);
            btnVentaCortesia.TabIndex = 2;
            btnVentaCortesia.Text = "VentaCortesía";
            btnVentaCortesia.UseVisualStyleBackColor = false;
            btnVentaCortesia.Click += btnVentaCortesia_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Moo_Deng;
            ClientSize = new Size(700, 396);
            Controls.Add(btnVentaCortesia);
            Controls.Add(btnVentaContado);
            Controls.Add(btnVentaCredito);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button btnVentaCredito;
        private Button btnVentaContado;
        private Button btnVentaCortesia;
    }
}
