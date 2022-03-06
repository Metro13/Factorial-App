using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Factorial
{
    public partial class Form1 : Form
    {
        Factorial factorial = new Factorial();
        public Form1()
        {
            InitializeComponent();
        }

        private void CmdCalculate_Click(object sender, EventArgs e)
        {
            factorial.Number = int.Parse(TxtNumber.Text);

            factorial.CalculateFactorial();

            MessageBox.Show("The Factorial of " + factorial.Number + " is " + factorial.Factor);
                
        }
    }
}
