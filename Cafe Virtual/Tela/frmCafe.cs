using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cafe_Virtual.Tela
{
    public partial class frmCafe : Form
    {
        public frmCafe()
        {
            InitializeComponent();
        }

        private void btnComprar_Click(object sender, EventArgs e)
        {
            try
            {                
                Model.CafeModel cafe = new Model.CafeModel();

                cafe.moeda1Real = chk1Real.Checked;
                cafe.moeda50Centavos = chk50Centavos.Checked;
                cafe.moeda25Centavos = chk25Centavos.Checked;
                cafe.moeda10Centavos = chk10Centavos.Checked;

                cafe.quantidade1Real = nud1Real.Value;
                cafe.quantidade50Centavos = nud50Centavos.Value;
                cafe.quantidade25Centavos = nud25Centavos.Value;
                cafe.quantidade10Centavos = nud10Centavos.Value;
                cafe.quantidade5Centavos = nud5Centavos.Value;
                cafe.quantidade1Centavo = nud1Centavo.Value;

                cafe.cafe = rdnCafe.Checked;
                cafe.cafeComLeite = rdnCafeComLeite.Checked;
                cafe.cappuccino = rdnCappuccino.Checked;
                cafe.mocha = rdnMocha.Checked;

                Business.CafeBusiness business = new Business.CafeBusiness();
                business.Validacao(cafe);                
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);

                if (nud1Centavo.Value != 0 || nud5Centavos.Value != 0)
                {
                    chk5Centavos.Checked = false;
                    chk1Centavo.Checked = false;
                }               
            }
            catch (Exception)
            {
                MessageBox.Show("Erro!");
            }           
        }

        private void chk1Real_CheckedChanged(object sender, EventArgs e)
        {
            if (chk1Real.Checked == true)
            {
                nud1Real.Enabled = true;
            }
            else
            {
                nud1Real.Value = 0;
                nud1Real.Enabled = false;
            }
        }

        private void chk50Centavos_CheckedChanged(object sender, EventArgs e)
        {
            if (chk50Centavos.Checked == true)
            {
                nud50Centavos.Enabled = true;
            }
            else
            {
                nud50Centavos.Value = 0;
                nud50Centavos.Enabled = false;
            }
        }

        private void chk25Centavos_CheckedChanged(object sender, EventArgs e)
        {
            if (chk25Centavos.Checked == true)
            {
                nud25Centavos.Enabled = true;
            }
            else
            {
                nud25Centavos.Value = 0;
                nud25Centavos.Enabled = false;
            }
        }

        private void chk10Centavos_CheckedChanged(object sender, EventArgs e)
        {
            if (chk10Centavos.Checked == true)
            {
                nud10Centavos.Enabled = true;
            }
            else
            {
                nud10Centavos.Value = 0;
                nud10Centavos.Enabled = false;
            }
        }

        private void chk5Centavos_CheckedChanged(object sender, EventArgs e)
        {
            if (chk5Centavos.Checked == true)
            {
                nud5Centavos.Enabled = true;
            }
            else
            {
                nud5Centavos.Value = 0;
                nud5Centavos.Enabled = false;
            }
        }

        private void chk1Centavo_CheckedChanged(object sender, EventArgs e)
        {
            if (chk1Centavo.Checked == true)
            {
                nud1Centavo.Enabled = true;
            }
            else
            {
                nud1Centavo.Value = 0;
                nud1Centavo.Enabled = false;
            }
        }
    }
}
