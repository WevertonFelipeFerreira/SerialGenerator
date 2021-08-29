
namespace SerialGenerator
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAll = new System.Windows.Forms.Button();
            this.CheckLower = new System.Windows.Forms.CheckBox();
            this.CheckUpper = new System.Windows.Forms.CheckBox();
            this.CheckNumber = new System.Windows.Forms.CheckBox();
            this.ComboBoxDivisor = new System.Windows.Forms.ComboBox();
            this.ComboBoxSize = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtWithDivider = new System.Windows.Forms.TextBox();
            this.txtWithoutDivider = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(391, 57);
            this.label1.TabIndex = 0;
            this.label1.Text = "SERIAL GENERATOR";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAll);
            this.groupBox1.Controls.Add(this.CheckLower);
            this.groupBox1.Controls.Add(this.CheckUpper);
            this.groupBox1.Controls.Add(this.CheckNumber);
            this.groupBox1.Controls.Add(this.ComboBoxDivisor);
            this.groupBox1.Controls.Add(this.ComboBoxSize);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(12, 69);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(435, 486);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // btnAll
            // 
            this.btnAll.Location = new System.Drawing.Point(6, 202);
            this.btnAll.Name = "btnAll";
            this.btnAll.Size = new System.Drawing.Size(40, 29);
            this.btnAll.TabIndex = 12;
            this.btnAll.Text = "All";
            this.btnAll.UseVisualStyleBackColor = true;
            this.btnAll.Click += new System.EventHandler(this.btnAll_Click);
            // 
            // CheckLower
            // 
            this.CheckLower.AutoSize = true;
            this.CheckLower.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CheckLower.Location = new System.Drawing.Point(162, 170);
            this.CheckLower.Name = "CheckLower";
            this.CheckLower.Size = new System.Drawing.Size(146, 29);
            this.CheckLower.TabIndex = 11;
            this.CheckLower.Text = "Lower Letters";
            this.CheckLower.UseVisualStyleBackColor = true;
            // 
            // CheckUpper
            // 
            this.CheckUpper.AutoSize = true;
            this.CheckUpper.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CheckUpper.Location = new System.Drawing.Point(9, 168);
            this.CheckUpper.Name = "CheckUpper";
            this.CheckUpper.Size = new System.Drawing.Size(147, 29);
            this.CheckUpper.TabIndex = 10;
            this.CheckUpper.Text = "Upper Letters";
            this.CheckUpper.UseVisualStyleBackColor = true;
            // 
            // CheckNumber
            // 
            this.CheckNumber.AutoSize = true;
            this.CheckNumber.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CheckNumber.Location = new System.Drawing.Point(314, 170);
            this.CheckNumber.Name = "CheckNumber";
            this.CheckNumber.Size = new System.Drawing.Size(111, 29);
            this.CheckNumber.TabIndex = 9;
            this.CheckNumber.Text = "Numbers";
            this.CheckNumber.UseVisualStyleBackColor = true;
            // 
            // ComboBoxDivisor
            // 
            this.ComboBoxDivisor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ComboBoxDivisor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxDivisor.FormattingEnabled = true;
            this.ComboBoxDivisor.Items.AddRange(new object[] {
            "None",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.ComboBoxDivisor.Location = new System.Drawing.Point(205, 79);
            this.ComboBoxDivisor.Name = "ComboBoxDivisor";
            this.ComboBoxDivisor.Size = new System.Drawing.Size(74, 28);
            this.ComboBoxDivisor.TabIndex = 7;
            // 
            // ComboBoxSize
            // 
            this.ComboBoxSize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ComboBoxSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxSize.FormattingEnabled = true;
            this.ComboBoxSize.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.ComboBoxSize.Location = new System.Drawing.Point(205, 33);
            this.ComboBoxSize.Name = "ComboBoxSize";
            this.ComboBoxSize.Size = new System.Drawing.Size(44, 28);
            this.ComboBoxSize.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(159, 126);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 30);
            this.label6.TabIndex = 5;
            this.label6.Text = "Type";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(7, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(196, 30);
            this.label5.TabIndex = 5;
            this.label5.Text = "How many divisors";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(7, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(192, 30);
            this.label4.TabIndex = 5;
            this.label4.Text = "String size per box";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtWithDivider);
            this.groupBox2.Controls.Add(this.txtWithoutDivider);
            this.groupBox2.Enabled = false;
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.Location = new System.Drawing.Point(6, 257);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(423, 214);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Result";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(99, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(217, 28);
            this.label3.TabIndex = 3;
            this.label3.Text = "Serial without divider";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(112, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(185, 28);
            this.label2.TabIndex = 3;
            this.label2.Text = "Serial with divider";
            // 
            // txtWithDivider
            // 
            this.txtWithDivider.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtWithDivider.Location = new System.Drawing.Point(14, 68);
            this.txtWithDivider.Name = "txtWithDivider";
            this.txtWithDivider.ReadOnly = true;
            this.txtWithDivider.Size = new System.Drawing.Size(389, 32);
            this.txtWithDivider.TabIndex = 1;
            this.txtWithDivider.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtWithoutDivider
            // 
            this.txtWithoutDivider.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtWithoutDivider.Location = new System.Drawing.Point(14, 151);
            this.txtWithoutDivider.Name = "txtWithoutDivider";
            this.txtWithoutDivider.ReadOnly = true;
            this.txtWithoutDivider.Size = new System.Drawing.Size(389, 32);
            this.txtWithoutDivider.TabIndex = 2;
            this.txtWithoutDivider.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(126, 212);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(153, 45);
            this.button1.TabIndex = 0;
            this.button1.Text = "GENERATE";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 547);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Serial Generator";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtWithDivider;
        private System.Windows.Forms.TextBox txtWithoutDivider;
        private System.Windows.Forms.ComboBox ComboBoxSize;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox CheckNumber;
        private System.Windows.Forms.ComboBox ComboBoxDivisor;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox CheckLower;
        private System.Windows.Forms.CheckBox CheckUpper;
        private System.Windows.Forms.Button btnAll;
    }
}

