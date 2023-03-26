using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hesapMakinesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbOperation_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            /*  double number1 = double.Parse(txtNumber1.Text);
              double number2 = double.Parse(txtNumber2.Text);
              string operation = cmbOperation.SelectedItem.ToString();
              double result = 0;*/

            if (string.IsNullOrEmpty(txtNumber1.Text) && string.IsNullOrEmpty(txtNumber2.Text))
            {
                MessageBox.Show("Lütfen tüm alanları doldurun.");
                return;
            }


            double number1 = double.Parse(txtNumber1.Text);
            double number2 = double.Parse(txtNumber2.Text);
            string operation = cmbOperation.SelectedItem.ToString();
            double result = 0;

            switch (operation)
            {
                case "Topla":
                    result = number1 + number2;
                    break;
                case "Çıkar":
                    result = number1 - number2;
                    break;
                case "Çarp":
                    result = number1 * number2;
                    break;
                case "Böl":
                    if (cmbOperation.SelectedItem.ToString() == "Böl" && txtNumber2.Text == "0")
                    {
                        label1.Text = "Sıfıra Bölme Hatası";
                        return;
                    }
                    result = number1 / number2;
                    break;
                default:
                    break;
            }
           
            label1.Text = result.ToString();
        }
    }
}
