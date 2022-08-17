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
        }

        private void button_GetNumber_Click(object sender, EventArgs e)
        {
            Remainder remainder = new Remainder();
            int num = remainder.GetRand();
            textBox_Random.Text = num.ToString();
        }
    }
}
