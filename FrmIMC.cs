using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CircodeAppsTDS06
{
    public partial class FrmIMC : Form
    {
        public FrmIMC()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmIMC_Load(object sender, EventArgs e)
        {
            this.ActiveControl = txtAltura;
            txtAltura.Focus();
        }

        private void txtAltura_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != (char)44)
            {
                e.Handled = true;
            }
        }

        private void txtPeso_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != (char)44)
            {
                e.Handled = true;
            }
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            Double peso, altura, resultado;
            if (txtAltura.Text == "" || txtPeso.Text == "")
            {
                MessageBox.Show("Não há cálculos sem valores! Por favor, digite os campos altura e peso!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                altura = Convert.ToDouble(txtAltura.Text);
                peso = Convert.ToDouble(txtPeso.Text);
                resultado = peso / (altura * altura);
                lblIMCResult.Text = resultado.ToString("F");
                txtAltura.Text = "";
                txtPeso.Text = "";
                if (resultado <= 18)
                {
                    lblIMCResultado.Text = "Magreza";
                }
                else if (resultado == 25 && resultado == 29.9)
                {
                    lblIMCResultado.Text = "Normal";
                }
                else if (resultado < 30)
                {
                    lblIMCResultado.Text = "Sobrepeso";
                }
                else if (resultado < 40)
                {
                    lblIMCResultado.Text = "Obesidade";
                }
                else
                {
                    lblIMCResultado.Text = "Obesidade Grave";
                }
            }
        }
    }
}