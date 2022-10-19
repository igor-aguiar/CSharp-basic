using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewApplication
{
    public partial class Form1 : Form
    {
        private int idadeJoao = 10;
        private int idadeMaria = 25;
        private int idadeEu = 30;
        private double pi = (int)3.14;
        private double valorDaNotaFiscal = 1000;
        private string message = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void calcularIdades(object sender, EventArgs e)
        {
            Double media = (idadeJoao + idadeEu + idadeMaria) / 3;
            MessageBox.Show("A média é " + media);
        }



        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Account acc = new Account("Igor", 400.0);
        
            Account acc2 = new Account("Lala", 300.0);
            acc.transfer(acc2, 200);
            MessageBox.Show("Accounts Balance\n"+ acc.Name + " Balance: " + acc.Balance + "\n" + acc2.Name + " Balance: " + acc2.Balance);
        }

        private double fatorial(int i)
        {
            if (i == 1)
            {
                return 1;
            }else
            {
                return i * fatorial(i - 1);
            }
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
        }
    }
}
