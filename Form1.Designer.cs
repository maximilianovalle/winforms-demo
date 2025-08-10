namespace WinformsDemo_i2winforms
{
    partial class userInfoForm
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
        private void InitializeComponent() {
            submitBtn = new Button();
            firstNameTextBox = new TextBox();
            firstNameLabel = new Label();
            lastNameLabel = new Label();
            lastNameTextBox = new TextBox();
            DOBDateTime = new DateTimePicker();
            DOBLabel = new Label();
            genderOptionMan = new RadioButton();
            genderOptionWoman = new RadioButton();
            genderOptionOther = new RadioButton();
            genderGroupBox = new GroupBox();
            genderGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // submitBtn
            // 
            submitBtn.Location = new Point(311, 353);
            submitBtn.Name = "submitBtn";
            submitBtn.Size = new Size(155, 49);
            submitBtn.TabIndex = 0;
            submitBtn.Text = "Submit";
            submitBtn.UseVisualStyleBackColor = true;
            submitBtn.Click += submitBtn_Click;
            // 
            // firstNameTextBox
            // 
            firstNameTextBox.Location = new Point(257, 65);
            firstNameTextBox.Name = "firstNameTextBox";
            firstNameTextBox.Size = new Size(117, 27);
            firstNameTextBox.TabIndex = 1;
            // 
            // firstNameLabel
            // 
            firstNameLabel.AutoSize = true;
            firstNameLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            firstNameLabel.Location = new Point(254, 42);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new Size(86, 20);
            firstNameLabel.TabIndex = 2;
            firstNameLabel.Text = "First Name";
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lastNameLabel.Location = new Point(399, 42);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new Size(84, 20);
            lastNameLabel.TabIndex = 4;
            lastNameLabel.Text = "Last Name";
            // 
            // lastNameTextBox
            // 
            lastNameTextBox.Location = new Point(402, 65);
            lastNameTextBox.Name = "lastNameTextBox";
            lastNameTextBox.Size = new Size(117, 27);
            lastNameTextBox.TabIndex = 3;
            // 
            // DOBDateTime
            // 
            DOBDateTime.Location = new Point(257, 135);
            DOBDateTime.MinDate = new DateTime(1910, 1, 1, 0, 0, 0, 0);
            DOBDateTime.Name = "DOBDateTime";
            DOBDateTime.Size = new Size(262, 27);
            DOBDateTime.TabIndex = 5;
            DOBDateTime.Value = new DateTime(2025, 8, 10, 0, 0, 0, 0);
            // 
            // DOBLabel
            // 
            DOBLabel.AutoSize = true;
            DOBLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DOBLabel.Location = new Point(254, 112);
            DOBLabel.Name = "DOBLabel";
            DOBLabel.Size = new Size(100, 20);
            DOBLabel.TabIndex = 6;
            DOBLabel.Text = "Date of Birth";
            // 
            // genderOptionMan
            // 
            genderOptionMan.AutoSize = true;
            genderOptionMan.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            genderOptionMan.Location = new Point(25, 26);
            genderOptionMan.Name = "genderOptionMan";
            genderOptionMan.Size = new Size(59, 24);
            genderOptionMan.TabIndex = 9;
            genderOptionMan.Text = "Man";
            genderOptionMan.UseVisualStyleBackColor = true;
            // 
            // genderOptionWoman
            // 
            genderOptionWoman.AutoSize = true;
            genderOptionWoman.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            genderOptionWoman.Location = new Point(25, 56);
            genderOptionWoman.Name = "genderOptionWoman";
            genderOptionWoman.Size = new Size(81, 24);
            genderOptionWoman.TabIndex = 10;
            genderOptionWoman.Text = "Woman";
            genderOptionWoman.UseVisualStyleBackColor = true;
            // 
            // genderOptionOther
            // 
            genderOptionOther.AutoSize = true;
            genderOptionOther.Checked = true;
            genderOptionOther.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            genderOptionOther.Location = new Point(25, 86);
            genderOptionOther.Name = "genderOptionOther";
            genderOptionOther.Size = new Size(67, 24);
            genderOptionOther.TabIndex = 11;
            genderOptionOther.TabStop = true;
            genderOptionOther.Text = "Other";
            genderOptionOther.UseVisualStyleBackColor = true;
            // 
            // genderGroupBox
            // 
            genderGroupBox.Controls.Add(genderOptionMan);
            genderGroupBox.Controls.Add(genderOptionOther);
            genderGroupBox.Controls.Add(genderOptionWoman);
            genderGroupBox.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            genderGroupBox.Location = new Point(257, 188);
            genderGroupBox.Name = "genderGroupBox";
            genderGroupBox.Size = new Size(262, 125);
            genderGroupBox.TabIndex = 12;
            genderGroupBox.TabStop = false;
            genderGroupBox.Text = "Gender";
            // 
            // userInfoForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(genderGroupBox);
            Controls.Add(DOBLabel);
            Controls.Add(DOBDateTime);
            Controls.Add(lastNameLabel);
            Controls.Add(lastNameTextBox);
            Controls.Add(firstNameLabel);
            Controls.Add(firstNameTextBox);
            Controls.Add(submitBtn);
            Name = "userInfoForm";
            Text = "User Info";
            genderGroupBox.ResumeLayout(false);
            genderGroupBox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button submitBtn;
        private TextBox firstNameTextBox;
        private Label firstNameLabel;
        private Label lastNameLabel;
        private TextBox lastNameTextBox;
        private DateTimePicker DOBDateTime;
        private Label DOBLabel;
        private RadioButton genderOptionMan;
        private RadioButton genderOptionWoman;
        private RadioButton genderOptionOther;
        private GroupBox genderGroupBox;
    }
}
