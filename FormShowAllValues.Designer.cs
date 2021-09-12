
namespace Insulin_diary
{
    partial class FormShowAllValues
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnID = new System.Windows.Forms.ColumnHeader();
            this.columnDate = new System.Windows.Forms.ColumnHeader();
            this.columnTime = new System.Windows.Forms.ColumnHeader();
            this.columnValue = new System.Windows.Forms.ColumnHeader();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblAverageValue = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnID,
            this.columnDate,
            this.columnTime,
            this.columnValue});
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 40);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(450, 310);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnID
            // 
            this.columnID.Text = "ID";
            this.columnID.Width = 70;
            // 
            // columnDate
            // 
            this.columnDate.Text = "Date of measurement";
            this.columnDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnDate.Width = 140;
            // 
            // columnTime
            // 
            this.columnTime.Text = "Time of measurement";
            this.columnTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnTime.Width = 140;
            // 
            // columnValue
            // 
            this.columnValue.Text = "Reference value";
            this.columnValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnValue.Width = 100;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(50, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(384, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "* reference values: 3.9 - 6.1 mmol/L or 70.2 - 109.8 mg/dl";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(489, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(178, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Average value (mmol/L):";
            // 
            // lblAverageValue
            // 
            this.lblAverageValue.AutoSize = true;
            this.lblAverageValue.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblAverageValue.Location = new System.Drawing.Point(560, 198);
            this.lblAverageValue.Name = "lblAverageValue";
            this.lblAverageValue.Size = new System.Drawing.Size(47, 20);
            this.lblAverageValue.TabIndex = 4;
            this.lblAverageValue.Text = "value";
            // 
            // FormShowAllValues
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::Insulin_diary.Properties.Resources.a_step_closer_to_orally_delivered_insulin_for_diabetes_348218;
            this.ClientSize = new System.Drawing.Size(872, 358);
            this.Controls.Add(this.lblAverageValue);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listView1);
            this.Name = "FormShowAllValues";
            this.Text = "FormShowAllValues";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormShowAllValues_FormClosing);
            this.Load += new System.EventHandler(this.FormShowAllValues_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.ColumnHeader columnID;
        public System.Windows.Forms.ColumnHeader columnDate;
        public System.Windows.Forms.ColumnHeader columnTime;
        public System.Windows.Forms.ColumnHeader columnValue;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label lblAverageValue;
        public System.Windows.Forms.ListView listView1;
    }
}