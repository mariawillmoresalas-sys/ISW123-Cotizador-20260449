using System;
using System.Windows.Forms;
using System.Drawing;

namespace Maria_2026_0449
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // Event handler placeholder; actualizar según la lógica de la aplicación




        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {

        }

        private void btnNivel1_Click(object sender, EventArgs e)
        {
            int a = 10;
            int b = 3;
            int r = a / b;
            lstResultados.Items.Add($"1.1  r = {r}");

            decimal r2 = 10 / 4m;
            lstResultados.Items.Add($"1.2  r = {r2}");

            int x = 5;
            x = x + 2;
            x = x * 3;
            lstResultados.Items.Add($"1.3  x = {x}");

            decimal p = 200m;
            decimal r4 = p * 0.18m;
            lstResultados.Items.Add($"1.4  r = {r4}");

            int n = 7;
            decimal d = 0m;
            if (n > 7)
            {
                d = 50m;
            }
            lstResultados.Items.Add($"1.5  d = {d}");

            bool larga = n >= 7;
            lstResultados.Items.Add($"1.6  larga = {larga}");

            string s = "Villa" + "Coral";
            lstResultados.Items.Add($"1.7  s = {s}");

            int n8 = 4;
            decimal t8 = 100m;
            decimal total = n8 * t8 * 1.28m;
            lstResultados.Items.Add($"1.8  total = {total}");

            decimal t = 120m;
            t = t + t * 0.25m;
            lstResultados.Items.Add($"1.9  t = {t}");

            int noches = (int)8.9m;
            lstResultados.Items.Add($"1.10 noches = {noches}");
        }

        private void lstResultados_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
