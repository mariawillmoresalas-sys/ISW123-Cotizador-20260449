namespace Maria_2026_0449
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
            lblHuesped = new Label();
            lblNoches = new Label();
            lblTarifa = new Label();
            txtHues = new TextBox();
            lblSubtotal = new Label();
            txtTarifa = new TextBox();
            nudNoches = new NumericUpDown();
            chcTemporada = new CheckBox();
            btnCalcular = new Button();
            btnLimpiar = new Button();
            grpCotizacion = new GroupBox();
            lbl4repuestaTotal = new Label();
            lbl3repuestaServicio = new Label();
            lbl2resultadoItbis = new Label();
            lbl1repuestaDescuento = new Label();
            lblresultadoSubtotal = new Label();
            lblTotal = new Label();
            lblServicio = new Label();
            lblITBIS = new Label();
            lblDescuento = new Label();
            btnCopiar = new Button();
            ((System.ComponentModel.ISupportInitialize)nudNoches).BeginInit();
            grpCotizacion.SuspendLayout();
            SuspendLayout();
            // 
            // lblHuesped
            // 
            lblHuesped.AutoSize = true;
            lblHuesped.Location = new Point(23, 31);
            lblHuesped.Name = "lblHuesped";
            lblHuesped.Size = new Size(54, 15);
            lblHuesped.TabIndex = 0;
            lblHuesped.Text = "Huesped";
            // 
            // lblNoches
            // 
            lblNoches.AutoSize = true;
            lblNoches.Location = new Point(23, 74);
            lblNoches.Name = "lblNoches";
            lblNoches.Size = new Size(47, 15);
            lblNoches.TabIndex = 1;
            lblNoches.Text = "Noches";
            // 
            // lblTarifa
            // 
            lblTarifa.AutoSize = true;
            lblTarifa.Location = new Point(23, 116);
            lblTarifa.Name = "lblTarifa";
            lblTarifa.Size = new Size(104, 15);
            lblTarifa.TabIndex = 2;
            lblTarifa.Text = "Tarifa/noche(USD)";
            // 
            // txtHues
            // 
            txtHues.Location = new Point(95, 31);
            txtHues.Name = "txtHues";
            txtHues.Size = new Size(316, 23);
            txtHues.TabIndex = 3;
            txtHues.TextChanged += textBox1_TextChanged;
            // 
            // lblSubtotal
            // 
            lblSubtotal.AutoSize = true;
            lblSubtotal.Location = new Point(16, 31);
            lblSubtotal.Name = "lblSubtotal";
            lblSubtotal.Size = new Size(51, 15);
            lblSubtotal.TabIndex = 4;
            lblSubtotal.Text = "Subtotal";
            // 
            // txtTarifa
            // 
            txtTarifa.Location = new Point(133, 116);
            txtTarifa.Name = "txtTarifa";
            txtTarifa.Size = new Size(278, 23);
            txtTarifa.TabIndex = 5;
            // 
            // nudNoches
            // 
            nudNoches.Location = new Point(95, 73);
            nudNoches.Maximum = new decimal(new int[] { 60, 0, 0, 0 });
            nudNoches.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudNoches.Name = "nudNoches";
            nudNoches.Size = new Size(68, 23);
            nudNoches.TabIndex = 6;
            nudNoches.TextAlign = HorizontalAlignment.Center;
            nudNoches.Value = new decimal(new int[] { 8, 0, 0, 0 });
            // 
            // chcTemporada
            // 
            chcTemporada.AutoSize = true;
            chcTemporada.Location = new Point(262, 164);
            chcTemporada.Name = "chcTemporada";
            chcTemporada.Size = new Size(149, 19);
            chcTemporada.TabIndex = 7;
            chcTemporada.Text = "Temporada alta (+25%)";
            chcTemporada.UseVisualStyleBackColor = true;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(231, 213);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(75, 23);
            btnCalcular.TabIndex = 8;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(336, 213);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(75, 23);
            btnLimpiar.TabIndex = 9;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // grpCotizacion
            // 
            grpCotizacion.Controls.Add(lbl4repuestaTotal);
            grpCotizacion.Controls.Add(lbl3repuestaServicio);
            grpCotizacion.Controls.Add(lbl2resultadoItbis);
            grpCotizacion.Controls.Add(lbl1repuestaDescuento);
            grpCotizacion.Controls.Add(lblresultadoSubtotal);
            grpCotizacion.Controls.Add(lblTotal);
            grpCotizacion.Controls.Add(lblServicio);
            grpCotizacion.Controls.Add(lblITBIS);
            grpCotizacion.Controls.Add(lblDescuento);
            grpCotizacion.Controls.Add(lblSubtotal);
            grpCotizacion.Location = new Point(23, 261);
            grpCotizacion.Name = "grpCotizacion";
            grpCotizacion.Size = new Size(388, 177);
            grpCotizacion.TabIndex = 10;
            grpCotizacion.TabStop = false;
            grpCotizacion.Text = "Cotización";
            // 
            // lbl4repuestaTotal
            // 
            lbl4repuestaTotal.AutoSize = true;
            lbl4repuestaTotal.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl4repuestaTotal.Location = new Point(343, 148);
            lbl4repuestaTotal.Name = "lbl4repuestaTotal";
            lbl4repuestaTotal.Size = new Size(33, 17);
            lbl4repuestaTotal.TabIndex = 13;
            lbl4repuestaTotal.Text = "0.00";
            // 
            // lbl3repuestaServicio
            // 
            lbl3repuestaServicio.AutoSize = true;
            lbl3repuestaServicio.Location = new Point(343, 115);
            lbl3repuestaServicio.Name = "lbl3repuestaServicio";
            lbl3repuestaServicio.Size = new Size(28, 15);
            lbl3repuestaServicio.TabIndex = 12;
            lbl3repuestaServicio.Text = "0.00";
            // 
            // lbl2resultadoItbis
            // 
            lbl2resultadoItbis.AutoSize = true;
            lbl2resultadoItbis.Location = new Point(343, 86);
            lbl2resultadoItbis.Name = "lbl2resultadoItbis";
            lbl2resultadoItbis.Size = new Size(28, 15);
            lbl2resultadoItbis.TabIndex = 11;
            lbl2resultadoItbis.Text = "0.00";
            // 
            // lbl1repuestaDescuento
            // 
            lbl1repuestaDescuento.AutoSize = true;
            lbl1repuestaDescuento.Location = new Point(343, 58);
            lbl1repuestaDescuento.Name = "lbl1repuestaDescuento";
            lbl1repuestaDescuento.Size = new Size(28, 15);
            lbl1repuestaDescuento.TabIndex = 10;
            lbl1repuestaDescuento.Text = "0.00";
            // 
            // lblresultadoSubtotal
            // 
            lblresultadoSubtotal.AutoSize = true;
            lblresultadoSubtotal.Location = new Point(343, 31);
            lblresultadoSubtotal.Name = "lblresultadoSubtotal";
            lblresultadoSubtotal.Size = new Size(28, 15);
            lblresultadoSubtotal.TabIndex = 9;
            lblresultadoSubtotal.Text = "0.00";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotal.Location = new Point(16, 148);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(78, 17);
            lblTotal.TabIndex = 8;
            lblTotal.Text = "TOTAL USD";
            // 
            // lblServicio
            // 
            lblServicio.AutoSize = true;
            lblServicio.Location = new Point(16, 115);
            lblServicio.Name = "lblServicio";
            lblServicio.Size = new Size(73, 15);
            lblServicio.TabIndex = 7;
            lblServicio.Text = "Servicio 10%";
            // 
            // lblITBIS
            // 
            lblITBIS.AutoSize = true;
            lblITBIS.Location = new Point(16, 86);
            lblITBIS.Name = "lblITBIS";
            lblITBIS.Size = new Size(58, 15);
            lblITBIS.TabIndex = 6;
            lblITBIS.Text = "ITBIS 18%";
            // 
            // lblDescuento
            // 
            lblDescuento.AutoSize = true;
            lblDescuento.Location = new Point(16, 58);
            lblDescuento.Name = "lblDescuento";
            lblDescuento.Size = new Size(63, 15);
            lblDescuento.TabIndex = 5;
            lblDescuento.Text = "Descuento";
            // 
            // btnCopiar
            // 
            btnCopiar.Location = new Point(114, 464);
            btnCopiar.Name = "btnCopiar";
            btnCopiar.Size = new Size(192, 23);
            btnCopiar.TabIndex = 11;
            btnCopiar.Text = "Copiar para whatsapp";
            btnCopiar.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(475, 523);
            Controls.Add(btnCopiar);
            Controls.Add(grpCotizacion);
            Controls.Add(btnLimpiar);
            Controls.Add(btnCalcular);
            Controls.Add(chcTemporada);
            Controls.Add(nudNoches);
            Controls.Add(txtTarifa);
            Controls.Add(txtHues);
            Controls.Add(lblTarifa);
            Controls.Add(lblNoches);
            Controls.Add(lblHuesped);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)nudNoches).EndInit();
            grpCotizacion.ResumeLayout(false);
            grpCotizacion.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblHuesped;
        private Label lblNoches;
        private Label lblTarifa;
        private TextBox txtHues;
        private Label lblSubtotal;
        private TextBox txtTarifa;
        private NumericUpDown nudNoches;
        private CheckBox chcTemporada;
        private Button btnCalcular;
        private Button btnLimpiar;
        private GroupBox grpCotizacion;
        private Button btnCopiar;
        private Label lblITBIS;
        private Label lblDescuento;
        private Label lblresultadoSubtotal;
        private Label lblTotal;
        private Label lblServicio;
        private Label lbl3repuestaServicio;
        private Label lbl2resultadoItbis;
        private Label lbl1repuestaDescuento;
        private Label lbl4repuestaTotal;
    }
}
