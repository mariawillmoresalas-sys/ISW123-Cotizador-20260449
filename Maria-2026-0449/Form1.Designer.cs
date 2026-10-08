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
            txtHuesped = new TextBox();
            nudNoches = new NumericUpDown();
            btnCalcular = new Button();
            btnLimpiar = new Button();
            btnCopiar = new Button();
            btnNivel1 = new Button();
            lstResultados = new ListBox();
            btnPesos = new Button();
            nudTarifa = new NumericUpDown();
            nudTasa = new NumericUpDown();
            nudPersonas = new NumericUpDown();
            btnPorPersona = new Button();
            lblTasa = new Label();
            lblPersona = new Label();
            btnDeposito = new Button();
            chkFinSemana = new CheckBox();
            btnFinSemana = new Button();
            btnDesglose = new Button();
            btnCuentaTotal = new Button();
            ((System.ComponentModel.ISupportInitialize)nudNoches).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudTarifa).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudTasa).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudPersonas).BeginInit();
            SuspendLayout();
            // 
            // lblHuesped
            // 
            lblHuesped.AutoSize = true;
            lblHuesped.Location = new Point(12, 20);
            lblHuesped.Name = "lblHuesped";
            lblHuesped.Size = new Size(54, 15);
            lblHuesped.TabIndex = 0;
            lblHuesped.Text = "Huesped";
            // 
            // lblNoches
            // 
            lblNoches.AutoSize = true;
            lblNoches.Location = new Point(12, 52);
            lblNoches.Name = "lblNoches";
            lblNoches.Size = new Size(47, 15);
            lblNoches.TabIndex = 1;
            lblNoches.Text = "Noches";
            // 
            // lblTarifa
            // 
            lblTarifa.AutoSize = true;
            lblTarifa.Location = new Point(12, 84);
            lblTarifa.Name = "lblTarifa";
            lblTarifa.Size = new Size(104, 15);
            lblTarifa.TabIndex = 2;
            lblTarifa.Text = "Tarifa/noche(USD)";
            // 
            // txtHuesped
            // 
            txtHuesped.Location = new Point(72, 17);
            txtHuesped.Name = "txtHuesped";
            txtHuesped.Size = new Size(316, 23);
            txtHuesped.TabIndex = 3;
            txtHuesped.TextChanged += textBox1_TextChanged;
            // 
            // nudNoches
            // 
            nudNoches.Location = new Point(72, 46);
            nudNoches.Maximum = new decimal(new int[] { 60, 0, 0, 0 });
            nudNoches.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudNoches.Name = "nudNoches";
            nudNoches.Size = new Size(68, 23);
            nudNoches.TabIndex = 6;
            nudNoches.TextAlign = HorizontalAlignment.Center;
            nudNoches.Value = new decimal(new int[] { 8, 0, 0, 0 });
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(151, 119);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(75, 23);
            btnCalcular.TabIndex = 8;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(151, 148);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(75, 23);
            btnLimpiar.TabIndex = 9;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // btnCopiar
            // 
            btnCopiar.Location = new Point(211, 467);
            btnCopiar.Name = "btnCopiar";
            btnCopiar.Size = new Size(192, 23);
            btnCopiar.TabIndex = 11;
            btnCopiar.Text = "Copiar para whatsapp";
            btnCopiar.UseVisualStyleBackColor = true;
            // 
            // btnNivel1
            // 
            btnNivel1.Location = new Point(242, 148);
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
            lstResultados.Location = new Point(22, 266);
            lstResultados.Name = "lstResultados";
            lstResultados.Size = new Size(572, 169);
            lstResultados.TabIndex = 13;
            lstResultados.SelectedIndexChanged += lstResultados_SelectedIndexChanged;
            // 
            // btnPesos
            // 
            btnPesos.Location = new Point(349, 119);
            btnPesos.Name = "btnPesos";
            btnPesos.Size = new Size(104, 23);
            btnPesos.TabIndex = 14;
            btnPesos.Text = "Total en RD$";
            btnPesos.UseVisualStyleBackColor = true;
            btnPesos.Click += btnPesos_Click;
            // 
            // nudTarifa
            // 
            nudTarifa.Location = new Point(123, 82);
            nudTarifa.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            nudTarifa.Minimum = new decimal(new int[] { 2, 0, 0, 0 });
            nudTarifa.Name = "nudTarifa";
            nudTarifa.Size = new Size(65, 23);
            nudTarifa.TabIndex = 15;
            nudTarifa.TextAlign = HorizontalAlignment.Center;
            nudTarifa.Value = new decimal(new int[] { 2, 0, 0, 0 });
            // 
            // nudTasa
            // 
            nudTasa.Location = new Point(72, 119);
            nudTasa.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            nudTasa.Minimum = new decimal(new int[] { 2, 0, 0, 0 });
            nudTasa.Name = "nudTasa";
            nudTasa.Size = new Size(65, 23);
            nudTasa.TabIndex = 17;
            nudTasa.TextAlign = HorizontalAlignment.Center;
            nudTasa.Value = new decimal(new int[] { 2, 0, 0, 0 });
            nudTasa.ValueChanged += nudTasa_ValueChanged;
            // 
            // nudPersonas
            // 
            nudPersonas.Location = new Point(72, 150);
            nudPersonas.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudPersonas.Name = "nudPersonas";
            nudPersonas.Size = new Size(65, 23);
            nudPersonas.TabIndex = 18;
            nudPersonas.TextAlign = HorizontalAlignment.Center;
            nudPersonas.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // btnPorPersona
            // 
            btnPorPersona.Location = new Point(242, 119);
            btnPorPersona.Name = "btnPorPersona";
            btnPorPersona.Size = new Size(93, 23);
            btnPorPersona.TabIndex = 19;
            btnPorPersona.Text = "Por persona";
            btnPorPersona.UseVisualStyleBackColor = true;
            btnPorPersona.Click += btnPorPersona_Click;
            // 
            // lblTasa
            // 
            lblTasa.AutoSize = true;
            lblTasa.Location = new Point(12, 121);
            lblTasa.Name = "lblTasa";
            lblTasa.Size = new Size(30, 15);
            lblTasa.TabIndex = 20;
            lblTasa.Text = "Tasa";
            // 
            // lblPersona
            // 
            lblPersona.AutoSize = true;
            lblPersona.Location = new Point(12, 150);
            lblPersona.Name = "lblPersona";
            lblPersona.Size = new Size(49, 15);
            lblPersona.TabIndex = 21;
            lblPersona.Text = "Persona";
            // 
            // btnDeposito
            // 
            btnDeposito.Location = new Point(349, 150);
            btnDeposito.Name = "btnDeposito";
            btnDeposito.Size = new Size(104, 23);
            btnDeposito.TabIndex = 22;
            btnDeposito.Text = "Deposito y saldo";
            btnDeposito.UseVisualStyleBackColor = true;
            btnDeposito.Click += btnDeposito_Click;
            // 
            // chkFinSemana
            // 
            chkFinSemana.AutoSize = true;
            chkFinSemana.Location = new Point(12, 191);
            chkFinSemana.Name = "chkFinSemana";
            chkFinSemana.Size = new Size(161, 19);
            chkFinSemana.TabIndex = 25;
            chkFinSemana.Text = "Tarifa por semana (+15%)";
            chkFinSemana.UseVisualStyleBackColor = true;
            // 
            // btnFinSemana
            // 
            btnFinSemana.Location = new Point(472, 121);
            btnFinSemana.Name = "btnFinSemana";
            btnFinSemana.Size = new Size(75, 23);
            btnFinSemana.TabIndex = 0;
            btnFinSemana.Text = "Fin semana";
            btnFinSemana.Click += btnFinSemana_Click;
            // 
            // btnDesglose
            // 
            btnDesglose.Location = new Point(472, 150);
            btnDesglose.Name = "btnDesglose";
            btnDesglose.Size = new Size(75, 23);
            btnDesglose.TabIndex = 26;
            btnDesglose.Text = "Desglose";
            btnDesglose.UseVisualStyleBackColor = true;
            btnDesglose.Click += btnDesglose_Click;
            // 
            // btnCuentaTotal
            // 
            btnCuentaTotal.Location = new Point(568, 121);
            btnCuentaTotal.Name = "btnCuentaTotal";
            btnCuentaTotal.Size = new Size(81, 23);
            btnCuentaTotal.TabIndex = 27;
            btnCuentaTotal.Text = "Cuenta total";
            btnCuentaTotal.UseVisualStyleBackColor = true;
            btnCuentaTotal.Click += btnCuentaTotal_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(709, 523);
            Controls.Add(btnCuentaTotal);
            Controls.Add(btnDesglose);
            Controls.Add(btnFinSemana);
            Controls.Add(chkFinSemana);
            Controls.Add(btnDeposito);
            Controls.Add(lblPersona);
            Controls.Add(lblTasa);
            Controls.Add(btnPorPersona);
            Controls.Add(nudPersonas);
            Controls.Add(nudTasa);
            Controls.Add(nudTarifa);
            Controls.Add(btnPesos);
            Controls.Add(lstResultados);
            Controls.Add(btnNivel1);
            Controls.Add(btnCopiar);
            Controls.Add(btnLimpiar);
            Controls.Add(btnCalcular);
            Controls.Add(nudNoches);
            Controls.Add(txtHuesped);
            Controls.Add(lblTarifa);
            Controls.Add(lblNoches);
            Controls.Add(lblHuesped);
            Name = "Form1";
            Text = "CotizadorVillaCoral-Maria-Teresa-Salas-W:2026-0449";
            ((System.ComponentModel.ISupportInitialize)nudNoches).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudTarifa).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudTasa).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudPersonas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblHuesped;
        private Label lblNoches;
        private Label lblTarifa;
        private TextBox txtHuesped;
        private NumericUpDown nudNoches;
      
        private Button btnCalcular;
        private Button btnLimpiar;
        private Button btnCopiar;
        private Button btnNivel1;
        private ListBox lstResultados;
        private Button btnPesos;
        private NumericUpDown nudTarifa;
        private NumericUpDown nudTasa;
        private NumericUpDown nudPersonas;
        private Button btnPorPersona;
        private Label lblTasa;
        private Label lblPersona;
        private Button btnDeposito;
   
        private CheckBox chkFinSemana;
        private Button btnFinSemana;
        private Button btnDesglose;
        private Button btnCuentaTotal;
    }
}
