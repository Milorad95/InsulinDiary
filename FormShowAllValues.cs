﻿using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Common;
using System.ComponentModel;
using System.Data;
using System.Configuration;

namespace Insulin_diary
{
    public partial class FormShowAllValues : Form
    {
        public FormShowAllValues()
        {
            InitializeComponent();
        }

        private void FormShowAllValues_Load(object sender, EventArgs e)
        {
            string command = "SELECT * FROM Notes";
            Connection(command);    /* here program calling Connection method with command parameter, for the upload all data into the listview */
        }


        /* this method upload all data from MS SQL database into listview */
        public void Connection(string command)
        {
            var connection = "Data Source=DESKTOP-ELB063I\\SQLEXPRESS01;Initial Catalog=InsulinDiary;Integrated Security=True";
            SqlConnection con = new SqlConnection(connection);
            var uploadList = new List<string>();

            try
            {
                con.Open();
                var c = new SqlCommand(command, con);
                var reader = c.ExecuteReader();
                while (reader.Read())
                {
                    uploadList.Add(reader["ID"].ToString());
                    uploadList.Add(DateTime.Parse(reader["DateOfMeasurement"].ToString()).ToShortDateString());     /* method ToShortDateString() returns to listview just short date format */
                    uploadList.Add(DateTime.Parse(reader["TimeOfMeasurement"].ToString()).ToShortTimeString());     /* method ToShortTimeString() returns to listview just short time format */
                    uploadList.Add(reader["ReferenceValue"].ToString());
                }
                reader.Close();

                string[] data = new string[4];
                double averageValue = 0;    /* this variable sums all the sugar values entered in the database */
                int counter = 0;

                for (int i = 0; i < uploadList.Count - 3; i++)
                {
                    if (i % 4 == 0)
                    {
                        data[0] = uploadList[i].ToString();
                        data[1] = uploadList[i + 1].ToString();
                        data[2] = uploadList[i + 2].ToString();
                        data[3] = uploadList[i + 3].ToString();

                        var items = new ListViewItem(data);
                        foreach (var d in data)
                        {
                            items.SubItems.Add(d);
                        }
                        listView1.Items.Add(items);

                        averageValue += double.Parse(data[3]);
                        counter++;
                    }
                }
                lblAverageValue.Text = (averageValue / counter).ToString("F");      /* "F" returns into form short average value, like 5,74 instead of 5,744444... */
            }
            catch (Exception e)
            {
                MessageBox.Show($"Error: {e.Message}", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void FormShowAllValues_FormClosing(object sender, FormClosingEventArgs e)
        {
            /* when the user chooses to close this form, the f instance will show to the user the main form */
            var f = new FormInsulinDiary();
            f.Show();
        }
    }
}
