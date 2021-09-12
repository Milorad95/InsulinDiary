using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Insulin_diary
{
    public partial class Convertor : Form
    {
        public Convertor()
        {
            InitializeComponent();
        }


        private void btnConvert_Click(object sender, EventArgs e)
        {
            if(txtMmol.Text == string.Empty || txtMmol.Text == null)    /* check what value the user wants to convert (mmol --> Mg/Dl or Mg/Dl --> mmol) */
            {
                txtResult.Text = (double.Parse(txtMg.Text) / 18).ToString("F");
            }
            else
            {
                txtResult.Text = (double.Parse(txtMmol.Text) * 18).ToString("F");   /* "F" returns a number with two decimals */
            }
        }

        private void Convertor_FormClosing(object sender, FormClosingEventArgs e)
        {
            var f = new FormInsulinDiary();     /* f instance will show the main form */
            f.Show();
        }
    }
}
