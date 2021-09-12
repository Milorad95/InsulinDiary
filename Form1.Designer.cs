
namespace Insulin_diary
{
    partial class FormInsulinDiary
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInsulinDiary));
            this.btnShowAllValues = new System.Windows.Forms.Button();
            this.btnAddNewValue = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnShowAllValues
            // 
            this.btnShowAllValues.BackColor = System.Drawing.Color.White;
            this.btnShowAllValues.Location = new System.Drawing.Point(34, 37);
            this.btnShowAllValues.Name = "btnShowAllValues";
            this.btnShowAllValues.Size = new System.Drawing.Size(160, 39);
            this.btnShowAllValues.TabIndex = 0;
            this.btnShowAllValues.Text = "Show all values";
            this.btnShowAllValues.UseVisualStyleBackColor = false;
            this.btnShowAllValues.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnAddNewValue
            // 
            this.btnAddNewValue.BackColor = System.Drawing.Color.White;
            this.btnAddNewValue.Location = new System.Drawing.Point(34, 169);
            this.btnAddNewValue.Name = "btnAddNewValue";
            this.btnAddNewValue.Size = new System.Drawing.Size(160, 39);
            this.btnAddNewValue.TabIndex = 1;
            this.btnAddNewValue.Text = "Add new value";
            this.btnAddNewValue.UseVisualStyleBackColor = false;
            this.btnAddNewValue.Click += new System.EventHandler(this.BtnAddNewValue_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(34, 303);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(160, 39);
            this.button3.TabIndex = 2;
            this.button3.Text = "Convertor mmol/L - mg/dL";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // FormInsulinDiary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(743, 383);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnAddNewValue);
            this.Controls.Add(this.btnShowAllValues);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "FormInsulinDiary";
            this.Text = "Insulin diary";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormInsulinDiary_FormClosing);
            this.Load += new System.EventHandler(this.FormInsulinDiary_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnShowAllValues;
        private System.Windows.Forms.Button button3;
        public System.Windows.Forms.Button btnAddNewValue;
    }
}

