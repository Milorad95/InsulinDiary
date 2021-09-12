using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.SqlTypes;

namespace Insulin_diary
{
    public partial class FormInsulinDiary : Form
    {
        public FormInsulinDiary()
        {
            InitializeComponent();
        }


        /* this button is here for showing all values */
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            var display = new FormShowAllValues();      /* display instance will show form with all values from the database */
            display.Show();
        }

        private void FormInsulinDiary_Load(object sender, EventArgs e)
        {

        }

        private void FormInsulinDiary_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.ExitThread();   /* program will end */
        }

        private void BtnAddNewValue_Click(object sender, EventArgs e)
        {
            this.Hide();
            var f = new FormAddNewValue();      /* f instance will show the form for insert a new value */
            f.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            var f = new Convertor();    /* f instance will show the form for convert values */
            f.Show();
        }
    }
}
