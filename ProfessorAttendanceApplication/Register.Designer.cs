namespace ProfessorAttendanceApplication
{
    partial class Register
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register));
            closebtn = new Button();
            header = new Panel();
            logoPanel = new Panel();
            registerLabel = new Label();
            firstNameInput = new TextBox();
            middleInitialLabel = new Label();
            passwordInput = new TextBox();
            firstNameLabel1 = new Label();
            utdIdInput = new TextBox();
            lastNameLabel = new Label();
            lastNameInput = new TextBox();
            midInitialInput = new TextBox();
            utdIdLabel = new Label();
            passwordLabel = new Label();
            utdEmailLabel = new Label();
            utdEmailInput = new TextBox();
            label6 = new Label();
            creditLabel = new Label();
            registerBtn = new Button();
            header.SuspendLayout();
            SuspendLayout();
            // 
            // closebtn
            // 
            closebtn.BackColor = Color.Red;
            closebtn.BackgroundImage = (Image)resources.GetObject("closebtn.BackgroundImage");
            closebtn.BackgroundImageLayout = ImageLayout.Center;
            closebtn.FlatStyle = FlatStyle.Popup;
            closebtn.Location = new Point(827, 5);
            closebtn.Margin = new Padding(5);
            closebtn.Name = "closebtn";
            closebtn.Size = new Size(40, 40);
            closebtn.TabIndex = 14;
            closebtn.UseVisualStyleBackColor = false;
            closebtn.Click += closebtn_Click;
            // 
            // header
            // 
            header.BackColor = Color.Black;
            header.Controls.Add(closebtn);
            header.Dock = DockStyle.Top;
            header.Location = new Point(0, 0);
            header.Name = "header";
            header.Size = new Size(870, 50);
            header.TabIndex = 2;
            // 
            // logoPanel
            // 
            logoPanel.BackColor = Color.OrangeRed;
            logoPanel.BackgroundImage = (Image)resources.GetObject("logoPanel.BackgroundImage");
            logoPanel.BackgroundImageLayout = ImageLayout.Center;
            logoPanel.Dock = DockStyle.Left;
            logoPanel.ForeColor = Color.Black;
            logoPanel.Location = new Point(0, 50);
            logoPanel.Name = "logoPanel";
            logoPanel.Size = new Size(350, 650);
            logoPanel.TabIndex = 5;
            // 
            // registerLabel
            // 
            registerLabel.AutoSize = true;
            registerLabel.Font = new Font("Segoe UI", 37.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            registerLabel.ForeColor = Color.Snow;
            registerLabel.Location = new Point(487, 98);
            registerLabel.Name = "registerLabel";
            registerLabel.Size = new Size(261, 85);
            registerLabel.TabIndex = 17;
            registerLabel.Text = "Register";
            // 
            // firstNameInput
            // 
            firstNameInput.BorderStyle = BorderStyle.FixedSingle;
            firstNameInput.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            firstNameInput.Location = new Point(402, 235);
            firstNameInput.MaxLength = 10;
            firstNameInput.Name = "firstNameInput";
            firstNameInput.PlaceholderText = " John";
            firstNameInput.Size = new Size(200, 38);
            firstNameInput.TabIndex = 23;
            // 
            // middleInitialLabel
            // 
            middleInitialLabel.AutoSize = true;
            middleInitialLabel.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            middleInitialLabel.ForeColor = Color.Snow;
            middleInitialLabel.Location = new Point(395, 295);
            middleInitialLabel.Name = "middleInitialLabel";
            middleInitialLabel.Size = new Size(151, 31);
            middleInitialLabel.TabIndex = 22;
            middleInitialLabel.Text = "Middle Initial";
            // 
            // passwordInput
            // 
            passwordInput.BorderStyle = BorderStyle.FixedSingle;
            passwordInput.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            passwordInput.Location = new Point(402, 464);
            passwordInput.MaxLength = 10;
            passwordInput.Name = "passwordInput";
            passwordInput.Size = new Size(299, 38);
            passwordInput.TabIndex = 25;
            // 
            // firstNameLabel1
            // 
            firstNameLabel1.AutoSize = true;
            firstNameLabel1.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            firstNameLabel1.ForeColor = Color.Snow;
            firstNameLabel1.Location = new Point(395, 201);
            firstNameLabel1.Name = "firstNameLabel1";
            firstNameLabel1.Size = new Size(127, 31);
            firstNameLabel1.TabIndex = 24;
            firstNameLabel1.Text = "First Name";
            // 
            // utdIdInput
            // 
            utdIdInput.BorderStyle = BorderStyle.FixedSingle;
            utdIdInput.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            utdIdInput.Location = new Point(402, 377);
            utdIdInput.MaxLength = 10;
            utdIdInput.Name = "utdIdInput";
            utdIdInput.PlaceholderText = "1234567890";
            utdIdInput.Size = new Size(134, 38);
            utdIdInput.TabIndex = 27;
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lastNameLabel.ForeColor = Color.Snow;
            lastNameLabel.Location = new Point(621, 201);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new Size(123, 31);
            lastNameLabel.TabIndex = 26;
            lastNameLabel.Text = "Last Name";
            // 
            // lastNameInput
            // 
            lastNameInput.BorderStyle = BorderStyle.FixedSingle;
            lastNameInput.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lastNameInput.Location = new Point(626, 235);
            lastNameInput.MaxLength = 10;
            lastNameInput.Name = "lastNameInput";
            lastNameInput.PlaceholderText = " Doe";
            lastNameInput.Size = new Size(200, 38);
            lastNameInput.TabIndex = 28;
            // 
            // midInitialInput
            // 
            midInitialInput.BorderStyle = BorderStyle.FixedSingle;
            midInitialInput.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            midInitialInput.Location = new Point(552, 293);
            midInitialInput.MaxLength = 10;
            midInitialInput.Name = "midInitialInput";
            midInitialInput.Size = new Size(50, 38);
            midInitialInput.TabIndex = 29;
            // 
            // utdIdLabel
            // 
            utdIdLabel.AutoSize = true;
            utdIdLabel.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            utdIdLabel.ForeColor = Color.Snow;
            utdIdLabel.Location = new Point(395, 343);
            utdIdLabel.Name = "utdIdLabel";
            utdIdLabel.Size = new Size(90, 31);
            utdIdLabel.TabIndex = 30;
            utdIdLabel.Text = "UTD ID";
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            passwordLabel.ForeColor = Color.Snow;
            passwordLabel.Location = new Point(395, 430);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(112, 31);
            passwordLabel.TabIndex = 31;
            passwordLabel.Text = "Password";
            // 
            // utdEmailLabel
            // 
            utdEmailLabel.AutoSize = true;
            utdEmailLabel.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            utdEmailLabel.ForeColor = Color.Snow;
            utdEmailLabel.Location = new Point(552, 343);
            utdEmailLabel.Name = "utdEmailLabel";
            utdEmailLabel.Size = new Size(122, 31);
            utdEmailLabel.TabIndex = 32;
            utdEmailLabel.Text = "UTD Email";
            // 
            // utdEmailInput
            // 
            utdEmailInput.BorderStyle = BorderStyle.FixedSingle;
            utdEmailInput.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            utdEmailInput.Location = new Point(556, 377);
            utdEmailInput.MaxLength = 10;
            utdEmailInput.Name = "utdEmailInput";
            utdEmailInput.PlaceholderText = " jxd567890@utdallas.edu";
            utdEmailInput.Size = new Size(270, 38);
            utdEmailInput.TabIndex = 33;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Snow;
            label6.Location = new Point(650, 673);
            label6.Name = "label6";
            label6.Size = new Size(211, 20);
            label6.TabIndex = 35;
            label6.Text = "@ 2025 for UTD Senior Project";
            // 
            // creditLabel
            // 
            creditLabel.AutoSize = true;
            creditLabel.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            creditLabel.ForeColor = Color.Snow;
            creditLabel.Location = new Point(363, 653);
            creditLabel.Name = "creditLabel";
            creditLabel.Size = new Size(498, 20);
            creditLabel.TabIndex = 34;
            creditLabel.Text = "Created by Akshaan Singh, Dylan Hua, Daniel Kirfman, and Ricardo Vargas";
            // 
            // registerBtn
            // 
            registerBtn.BackColor = Color.Green;
            registerBtn.FlatStyle = FlatStyle.Popup;
            registerBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            registerBtn.ForeColor = SystemColors.HighlightText;
            registerBtn.Location = new Point(402, 528);
            registerBtn.Name = "registerBtn";
            registerBtn.Size = new Size(120, 55);
            registerBtn.TabIndex = 36;
            registerBtn.Text = "Register";
            registerBtn.UseVisualStyleBackColor = false;
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.WindowFrame;
            ClientSize = new Size(870, 700);
            Controls.Add(registerBtn);
            Controls.Add(firstNameLabel1);
            Controls.Add(firstNameInput);
            Controls.Add(lastNameLabel);
            Controls.Add(lastNameInput);
            Controls.Add(middleInitialLabel);
            Controls.Add(midInitialInput);
            Controls.Add(utdIdLabel);
            Controls.Add(utdIdInput);
            Controls.Add(utdEmailLabel);
            Controls.Add(utdEmailInput);
            Controls.Add(passwordLabel);
            Controls.Add(passwordInput);
            Controls.Add(label6);
            Controls.Add(creditLabel);
            Controls.Add(registerLabel);
            Controls.Add(logoPanel);
            Controls.Add(header);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Register";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Register";
            header.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button closebtn;
        private Panel header;
        private Panel logoPanel;
        private Label registerLabel;
        private TextBox firstNameInput;
        private Label middleInitialLabel;
        private TextBox passwordInput;
        private Label firstNameLabel1;
        private TextBox utdIdInput;
        private Label lastNameLabel;
        private TextBox lastNameInput;
        private TextBox midInitialInput;
        private Label utdIdLabel;
        private Label passwordLabel;
        private Label utdEmailLabel;
        private TextBox utdEmailInput;
        private Label label6;
        private Label creditLabel;
        private Button registerBtn;
    }
}