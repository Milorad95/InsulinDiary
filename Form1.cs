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

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            var display = new FormShowAllValues();
            display.Show();
        }

        private void FormInsulinDiary_Load(object sender, EventArgs e)
        {

        }

        private void FormInsulinDiary_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void BtnAddNewValue_Click(object sender, EventArgs e)
        {
            this.Hide();
            var f = new FormAddNewValue();
            f.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            var f = new Convertor();
            f.Show();
        }
    }
}
