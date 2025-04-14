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
            setasswordLabel = new Label();
            utdEmailLabel = new Label();
            utdEmailInput = new TextBox();
            label6 = new Label();
            creditLabel = new Label();
            registerBtn = new Button();
            confirmPasswordLabel = new Label();
            confirmPasswordInput = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label7 = new Label();
            clearBtn = new Button();
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
            registerLabel.Location = new Point(493, 53);
            registerLabel.Name = "registerLabel";
            registerLabel.Size = new Size(261, 85);
            registerLabel.TabIndex = 17;
            registerLabel.Text = "Register";
            // 
            // firstNameInput
            // 
            firstNameInput.BorderStyle = BorderStyle.FixedSingle;
            firstNameInput.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            firstNameInput.Location = new Point(402, 180);
            firstNameInput.MaxLength = 0;
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
            middleInitialLabel.Location = new Point(395, 239);
            middleInitialLabel.Name = "middleInitialLabel";
            middleInitialLabel.Size = new Size(151, 31);
            middleInitialLabel.TabIndex = 22;
            middleInitialLabel.Text = "Middle Initial";
            // 
            // passwordInput
            // 
            passwordInput.BorderStyle = BorderStyle.FixedSingle;
            passwordInput.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            passwordInput.Location = new Point(402, 405);
            passwordInput.MaxLength = 16;
            passwordInput.Name = "passwordInput";
            passwordInput.PasswordChar = '*';
            passwordInput.Size = new Size(299, 38);
            passwordInput.TabIndex = 28;
            // 
            // firstNameLabel1
            // 
            firstNameLabel1.AutoSize = true;
            firstNameLabel1.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            firstNameLabel1.ForeColor = Color.Snow;
            firstNameLabel1.Location = new Point(395, 146);
            firstNameLabel1.Name = "firstNameLabel1";
            firstNameLabel1.Size = new Size(127, 31);
            firstNameLabel1.TabIndex = 24;
            firstNameLabel1.Text = "First Name";
            // 
            // utdIdInput
            // 
            utdIdInput.BorderStyle = BorderStyle.FixedSingle;
            utdIdInput.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            utdIdInput.Location = new Point(402, 319);
            utdIdInput.MaxLength = 10;
            utdIdInput.Name = "utdIdInput";
            utdIdInput.PlaceholderText = "1234567890";
            utdIdInput.Size = new Size(134, 38);
            utdIdInput.TabIndex = 26;
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lastNameLabel.ForeColor = Color.Snow;
            lastNameLabel.Location = new Point(621, 146);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new Size(129, 31);
            lastNameLabel.TabIndex = 26;
            lastNameLabel.Text = "Last Name ";
            // 
            // lastNameInput
            // 
            lastNameInput.BorderStyle = BorderStyle.FixedSingle;
            lastNameInput.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lastNameInput.Location = new Point(626, 180);
            lastNameInput.MaxLength = 0;
            lastNameInput.Name = "lastNameInput";
            lastNameInput.PlaceholderText = " Doe";
            lastNameInput.Size = new Size(200, 38);
            lastNameInput.TabIndex = 24;
            // 
            // midInitialInput
            // 
            midInitialInput.BorderStyle = BorderStyle.FixedSingle;
            midInitialInput.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            midInitialInput.Location = new Point(552, 237);
            midInitialInput.MaxLength = 1;
            midInitialInput.Name = "midInitialInput";
            midInitialInput.PlaceholderText = " P";
            midInitialInput.Size = new Size(50, 38);
            midInitialInput.TabIndex = 25;
            // 
            // utdIdLabel
            // 
            utdIdLabel.AutoSize = true;
            utdIdLabel.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            utdIdLabel.ForeColor = Color.Snow;
            utdIdLabel.Location = new Point(395, 285);
            utdIdLabel.Name = "utdIdLabel";
            utdIdLabel.Size = new Size(90, 31);
            utdIdLabel.TabIndex = 30;
            utdIdLabel.Text = "UTD ID";
            // 
            // setasswordLabel
            // 
            setasswordLabel.AutoSize = true;
            setasswordLabel.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            setasswordLabel.ForeColor = Color.Snow;
            setasswordLabel.Location = new Point(395, 371);
            setasswordLabel.Name = "setasswordLabel";
            setasswordLabel.Size = new Size(151, 31);
            setasswordLabel.TabIndex = 31;
            setasswordLabel.Text = "Set Password";
            // 
            // utdEmailLabel
            // 
            utdEmailLabel.AutoSize = true;
            utdEmailLabel.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            utdEmailLabel.ForeColor = Color.Snow;
            utdEmailLabel.Location = new Point(552, 285);
            utdEmailLabel.Name = "utdEmailLabel";
            utdEmailLabel.Size = new Size(122, 31);
            utdEmailLabel.TabIndex = 32;
            utdEmailLabel.Text = "UTD Email";
            // 
            // utdEmailInput
            // 
            utdEmailInput.BorderStyle = BorderStyle.FixedSingle;
            utdEmailInput.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            utdEmailInput.Location = new Point(552, 319);
            utdEmailInput.MaxLength = 0;
            utdEmailInput.Name = "utdEmailInput";
            utdEmailInput.PlaceholderText = " jxd567890@utdallas.edu";
            utdEmailInput.Size = new Size(274, 38);
            utdEmailInput.TabIndex = 27;
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
            registerBtn.Location = new Point(402, 547);
            registerBtn.Name = "registerBtn";
            registerBtn.Size = new Size(120, 55);
            registerBtn.TabIndex = 30;
            registerBtn.Text = "Register";
            registerBtn.UseVisualStyleBackColor = false;
            registerBtn.Click += registerBtn_Click;
            // 
            // confirmPasswordLabel
            // 
            confirmPasswordLabel.AutoSize = true;
            confirmPasswordLabel.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            confirmPasswordLabel.ForeColor = Color.Snow;
            confirmPasswordLabel.Location = new Point(395, 452);
            confirmPasswordLabel.Name = "confirmPasswordLabel";
            confirmPasswordLabel.Size = new Size(202, 31);
            confirmPasswordLabel.TabIndex = 29;
            confirmPasswordLabel.Text = "Confirm Password";
            // 
            // confirmPasswordInput
            // 
            confirmPasswordInput.BorderStyle = BorderStyle.FixedSingle;
            confirmPasswordInput.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            confirmPasswordInput.Location = new Point(402, 486);
            confirmPasswordInput.MaxLength = 16;
            confirmPasswordInput.Name = "confirmPasswordInput";
            confirmPasswordInput.PasswordChar = '*';
            confirmPasswordInput.Size = new Size(299, 38);
            confirmPasswordInput.TabIndex = 29;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(517, 138);
            label1.Name = "label1";
            label1.Size = new Size(29, 38);
            label1.TabIndex = 36;
            label1.Text = "*";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Red;
            label2.Location = new Point(740, 138);
            label2.Name = "label2";
            label2.Size = new Size(29, 38);
            label2.TabIndex = 37;
            label2.Text = "*";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Red;
            label3.Location = new Point(480, 278);
            label3.Name = "label3";
            label3.Size = new Size(29, 38);
            label3.TabIndex = 38;
            label3.Text = "*";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Red;
            label4.Location = new Point(669, 278);
            label4.Name = "label4";
            label4.Size = new Size(29, 38);
            label4.TabIndex = 39;
            label4.Text = "*";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Red;
            label5.Location = new Point(541, 361);
            label5.Name = "label5";
            label5.Size = new Size(29, 38);
            label5.TabIndex = 40;
            label5.Text = "*";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.Red;
            label7.Location = new Point(591, 445);
            label7.Name = "label7";
            label7.Size = new Size(29, 38);
            label7.TabIndex = 41;
            label7.Text = "*";
            label7.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // clearBtn
            // 
            clearBtn.BackColor = Color.DarkOrange;
            clearBtn.FlatStyle = FlatStyle.Popup;
            clearBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            clearBtn.ForeColor = SystemColors.HighlightText;
            clearBtn.Location = new Point(541, 547);
            clearBtn.Name = "clearBtn";
            clearBtn.Size = new Size(120, 55);
            clearBtn.TabIndex = 31;
            clearBtn.Text = "Clear";
            clearBtn.UseVisualStyleBackColor = false;
            clearBtn.Click += clearBtn_Click;
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.WindowFrame;
            ClientSize = new Size(870, 700);
            Controls.Add(clearBtn);
            Controls.Add(label7);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(firstNameLabel1);
            Controls.Add(confirmPasswordLabel);
            Controls.Add(confirmPasswordInput);
            Controls.Add(registerBtn);
            Controls.Add(firstNameInput);
            Controls.Add(lastNameLabel);
            Controls.Add(lastNameInput);
            Controls.Add(middleInitialLabel);
            Controls.Add(midInitialInput);
            Controls.Add(utdIdLabel);
            Controls.Add(utdIdInput);
            Controls.Add(utdEmailLabel);
            Controls.Add(utdEmailInput);
            Controls.Add(setasswordLabel);
            Controls.Add(passwordInput);
            Controls.Add(label6);
            Controls.Add(creditLabel);
            Controls.Add(registerLabel);
            Controls.Add(logoPanel);
            Controls.Add(header);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
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
        private Label setasswordLabel;
        private Label utdEmailLabel;
        private TextBox utdEmailInput;
        private Label label6;
        private Label creditLabel;
        private Button registerBtn;
        private Label confirmPasswordLabel;
        private TextBox confirmPasswordInput;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label7;
        private Button clearBtn;
    }
}