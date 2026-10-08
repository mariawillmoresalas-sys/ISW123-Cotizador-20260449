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
            txtTarifa = new TextBox();
            nudNoches = new NumericUpDown();
            chcTemporada = new CheckBox();
            btnCalcular = new Button();
            btnLimpiar = new Button();
            btnCopiar = new Button();
            btnNivel1 = new Button();
            lstResultados = new ListBox();
            ((System.ComponentModel.ISupportInitialize)nudNoches).BeginInit();
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
            // btnCopiar
            // 
            btnCopiar.Location = new Point(114, 464);
            btnCopiar.Name = "btnCopiar";
            btnCopiar.Size = new Size(192, 23);
            btnCopiar.TabIndex = 11;
            btnCopiar.Text = "Copiar para whatsapp";
            btnCopiar.UseVisualStyleBackColor = true;
            // 
            // btnNivel1
            // 
            btnNivel1.Location = new Point(23, 160);
            btnNivel1.Name = "btnNivel1";
            btnNivel1.Size = new Size(75, 23);
            btnNivel1.TabIndex = 12;
            btnNivel1.Text = "Nivel1";
            btnNivel1.UseVisualStyleBackColor = true;
            btnNivel1.Click += btnNivel1_Click;
            // 
            // lstResultados
            // 
            lstResultados.FormattingEnabled = true;
            lstResultados.Location = new Point(23, 284);
            lstResultados.Name = "lstResultados";
            lstResultados.Size = new Size(388, 139);
            lstResultados.TabIndex = 13;
            lstResultados.SelectedIndexChanged += lstResultados_SelectedIndexChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(475, 523);
            Controls.Add(lstResultados);
            Controls.Add(btnNivel1);
            Controls.Add(btnCopiar);
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
            Text = "CotizadorVillaCoral-Maria-Teresa-Salas-W:2026-0449";
            ((System.ComponentModel.ISupportInitialize)nudNoches).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblHuesped;
        private Label lblNoches;
        private Label lblTarifa;
        private TextBox txtHues;
        private TextBox txtTarifa;
        private NumericUpDown nudNoches;
        private CheckBox chcTemporada;
        private Button btnCalcular;
        private Button btnLimpiar;
        private Button btnCopiar;
        private Button btnNivel1;
        private ListBox lstResultados;
    }
}
