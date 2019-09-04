namespace TN1WinForm
{
    partial class Form1
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
            this.text_name = new System.Windows.Forms.TextBox();
            this.text_age = new System.Windows.Forms.TextBox();
            this.text_ird = new System.Windows.Forms.TextBox();
            this.text_bank = new System.Windows.Forms.TextBox();
            this.text_pay = new System.Windows.Forms.TextBox();
            this.text_hr = new System.Windows.Forms.TextBox();
            this.lbl_ird = new System.Windows.Forms.Label();
            this.lbl_pay = new System.Windows.Forms.Label();
            this.lbl_hr = new System.Windows.Forms.Label();
            this.lbl_name = new System.Windows.Forms.Label();
            this.lbl_age = new System.Windows.Forms.Label();
            this.lbl_bank = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.GroupBox = new System.Windows.Forms.GroupBox();
            this.details = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // text_name
            // 
            this.text_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.text_name.Location = new System.Drawing.Point(24, 188);
            this.text_name.Name = "text_name";
            this.text_name.Size = new System.Drawing.Size(245, 32);
            this.text_name.TabIndex = 0;
            this.text_name.TextChanged += new System.EventHandler(this.text_name_TextChanged);
            // 
            // text_age
            // 
            this.text_age.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.text_age.Location = new System.Drawing.Point(24, 249);
            this.text_age.Name = "text_age";
            this.text_age.Size = new System.Drawing.Size(245, 32);
            this.text_age.TabIndex = 1;
            this.text_age.TextChanged += new System.EventHandler(this.text_age_TextChanged);
            // 
            // text_ird
            // 
            this.text_ird.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.text_ird.Location = new System.Drawing.Point(24, 310);
            this.text_ird.Name = "text_ird";
            this.text_ird.Size = new System.Drawing.Size(245, 32);
            this.text_ird.TabIndex = 2;
            this.text_ird.TextChanged += new System.EventHandler(this.text_ird_TextChanged);
            // 
            // text_bank
            // 
            this.text_bank.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.text_bank.Location = new System.Drawing.Point(24, 372);
            this.text_bank.Name = "text_bank";
            this.text_bank.Size = new System.Drawing.Size(245, 32);
            this.text_bank.TabIndex = 3;
            this.text_bank.TextChanged += new System.EventHandler(this.text_bank_TextChanged);
            // 
            // text_pay
            // 
            this.text_pay.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.text_pay.Location = new System.Drawing.Point(24, 433);
            this.text_pay.Name = "text_pay";
            this.text_pay.Size = new System.Drawing.Size(245, 32);
            this.text_pay.TabIndex = 4;
            this.text_pay.TextChanged += new System.EventHandler(this.text_pay_TextChanged);
            // 
            // text_hr
            // 
            this.text_hr.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.text_hr.Location = new System.Drawing.Point(24, 499);
            this.text_hr.Name = "text_hr";
            this.text_hr.Size = new System.Drawing.Size(245, 32);
            this.text_hr.TabIndex = 5;
            this.text_hr.TextChanged += new System.EventHandler(this.text_hr_TextChanged);
            // 
            // lbl_ird
            // 
            this.lbl_ird.AutoSize = true;
            this.lbl_ird.Location = new System.Drawing.Point(27, 294);
            this.lbl_ird.Name = "lbl_ird";
            this.lbl_ird.Size = new System.Drawing.Size(26, 13);
            this.lbl_ird.TabIndex = 7;
            this.lbl_ird.Text = "IRD";
            // 
            // lbl_pay
            // 
            this.lbl_pay.AutoSize = true;
            this.lbl_pay.Location = new System.Drawing.Point(27, 417);
            this.lbl_pay.Name = "lbl_pay";
            this.lbl_pay.Size = new System.Drawing.Size(25, 13);
            this.lbl_pay.TabIndex = 8;
            this.lbl_pay.Text = "Pay";
            // 
            // lbl_hr
            // 
            this.lbl_hr.AutoSize = true;
            this.lbl_hr.Location = new System.Drawing.Point(27, 483);
            this.lbl_hr.Name = "lbl_hr";
            this.lbl_hr.Size = new System.Drawing.Size(35, 13);
            this.lbl_hr.TabIndex = 9;
            this.lbl_hr.Text = "Hours";
            this.lbl_hr.Click += new System.EventHandler(this.label4_Click);
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Location = new System.Drawing.Point(27, 168);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(35, 13);
            this.lbl_name.TabIndex = 10;
            this.lbl_name.Text = "Name";
            // 
            // lbl_age
            // 
            this.lbl_age.AutoSize = true;
            this.lbl_age.Location = new System.Drawing.Point(27, 233);
            this.lbl_age.Name = "lbl_age";
            this.lbl_age.Size = new System.Drawing.Size(26, 13);
            this.lbl_age.TabIndex = 11;
            this.lbl_age.Text = "Age";
            // 
            // lbl_bank
            // 
            this.lbl_bank.AutoSize = true;
            this.lbl_bank.Location = new System.Drawing.Point(27, 356);
            this.lbl_bank.Name = "lbl_bank";
            this.lbl_bank.Size = new System.Drawing.Size(32, 13);
            this.lbl_bank.TabIndex = 6;
            this.lbl_bank.Text = "Bank";
            this.lbl_bank.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(24, 550);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 34);
            this.button1.TabIndex = 12;
            this.button1.Text = "SUBMIT";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // GroupBox
            // 
            this.GroupBox.Location = new System.Drawing.Point(14, 127);
            this.GroupBox.Name = "GroupBox";
            this.GroupBox.Size = new System.Drawing.Size(287, 472);
            this.GroupBox.TabIndex = 13;
            this.GroupBox.TabStop = false;
            this.GroupBox.Text = "FORM APPLICATION";
            this.GroupBox.Enter += new System.EventHandler(this.GroupBox_Enter);
            // 
            // details
            // 
            this.details.AutoSize = true;
            this.details.Location = new System.Drawing.Point(507, 188);
            this.details.Name = "details";
            this.details.Size = new System.Drawing.Size(35, 13);
            this.details.TabIndex = 14;
            this.details.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1111, 627);
            this.Controls.Add(this.details);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbl_age);
            this.Controls.Add(this.lbl_name);
            this.Controls.Add(this.lbl_hr);
            this.Controls.Add(this.lbl_pay);
            this.Controls.Add(this.lbl_ird);
            this.Controls.Add(this.lbl_bank);
            this.Controls.Add(this.text_hr);
            this.Controls.Add(this.text_pay);
            this.Controls.Add(this.text_bank);
            this.Controls.Add(this.text_ird);
            this.Controls.Add(this.text_age);
            this.Controls.Add(this.text_name);
            this.Controls.Add(this.GroupBox);
            this.Name = "Form1";
            this.Text = "TeamName1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox text_name;
        private System.Windows.Forms.TextBox text_age;
        private System.Windows.Forms.TextBox text_ird;
        private System.Windows.Forms.TextBox text_bank;
        private System.Windows.Forms.TextBox text_pay;
        private System.Windows.Forms.TextBox text_hr;
        private System.Windows.Forms.Label lbl_ird;
        private System.Windows.Forms.Label lbl_pay;
        private System.Windows.Forms.Label lbl_hr;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Label lbl_age;
        private System.Windows.Forms.Label lbl_bank;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox GroupBox;
        private System.Windows.Forms.Label details;
    }
}

