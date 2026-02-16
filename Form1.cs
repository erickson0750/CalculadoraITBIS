using System;
using System.Windows.Forms;

namespace CalculadoraITBIS
{
    public partial class Form1 : Form
    {
        private TextBox txtMonto;
        private TextBox txtPorcentaje;
        private Button btnCalcular;
        private Label lblResultado;
        private Label lblMonto;
        private Label lblPorcentaje;

        public Form1()
        {
            InitializeComponent();
            CrearControles();
        }

        private void CrearControles()
        {
            this.Text = "Calculadora de ITBIS";
            this.Size = new System.Drawing.Size(400, 250);

            // Label Monto
            lblMonto = new Label();
            lblMonto.Text = "Monto:";
            lblMonto.Location = new System.Drawing.Point(30, 30);
            lblMonto.Size = new System.Drawing.Size(100, 20);
            this.Controls.Add(lblMonto);

            // TextBox Monto
            txtMonto = new TextBox();
            txtMonto.Location = new System.Drawing.Point(150, 30);
            txtMonto.Size = new System.Drawing.Size(200, 20);
            this.Controls.Add(txtMonto);

            // Label Porcentaje
            lblPorcentaje = new Label();
            lblPorcentaje.Text = "Porcentaje ITBIS:";
            lblPorcentaje.Location = new System.Drawing.Point(30, 70);
            lblPorcentaje.Size = new System.Drawing.Size(100, 20);
            this.Controls.Add(lblPorcentaje);

            // TextBox Porcentaje
            txtPorcentaje = new TextBox();
            txtPorcentaje.Location = new System.Drawing.Point(150, 70);
            txtPorcentaje.Size = new System.Drawing.Size(200, 20);
            txtPorcentaje.Text = "18"; // ITBIS por defecto en RD
            this.Controls.Add(txtPorcentaje);

            // Button Calcular
            btnCalcular = new Button();
            btnCalcular.Text = "Calcular";
            btnCalcular.Location = new System.Drawing.Point(150, 110);
            btnCalcular.Size = new System.Drawing.Size(200, 30);
            btnCalcular.Click += BtnCalcular_Click;
            this.Controls.Add(btnCalcular);

            // Label Resultado
            lblResultado = new Label();
            lblResultado.Location = new System.Drawing.Point(30, 160);
            lblResultado.Size = new System.Drawing.Size(320, 40);
            lblResultado.Font = new System.Drawing.Font("Arial", 10, System.Drawing.FontStyle.Bold);
            this.Controls.Add(lblResultado);
        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                decimal monto = decimal.Parse(txtMonto.Text);
                decimal porcentaje = decimal.Parse(txtPorcentaje.Text);

                decimal itbis = monto * (porcentaje / 100);
                decimal total = monto + itbis;

                lblResultado.Text = $"ITBIS: RD${itbis:N2}\nTotal: RD${total:N2}";
            }
            catch
            {
                MessageBox.Show("Por favor ingrese valores numéricos válidos", "Error");
            }
        }
    }
}