using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Math_For_Video_Games
{
    public partial class Ch1Remainders : Form
    {
        public Ch1Remainders()
        {
            InitializeComponent();
            button_GetNumber_Click(this, new EventArgs());
            textBox_Denominador.Text = 30.ToString();
        }

        private void button_GetNumber_Click(object sender, EventArgs e)
        {
            Remainder remainder = new Remainder();
            int num = remainder.GetRand();
            textBox_Num.Text = num.ToString();
        }

        private void button_Ok_Click(object sender, EventArgs e)
        {
            try
            {
                Remainder remainder = new Remainder();
                label_Result.Text = remainder.GetResult(int.Parse(textBox_Num.Text), int.Parse(textBox_Denominador.Text)).ToString();
                label_Remainder.Text = remainder.GetRemainder(int.Parse(textBox_Num.Text), int.Parse(textBox_Denominador.Text)).ToString();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void textBox_Num_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox_Denominador_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
