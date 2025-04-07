namespace ProfessorAttendanceApplication
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            header = new Panel();
            closebtn = new Button();
            logoPanel = new Panel();
            label1 = new Label();
            creditLabel = new Label();
            forgotPassBtn = new Button();
            loginBtn = new Button();
            passwordInput = new TextBox();
            passwordLabel = new Label();
            registerLink = new LinkLabel();
            utdIdInput = new TextBox();
            utdIdLabel = new Label();
            loginLabel = new Label();
            discLabel = new Label();
            header.SuspendLayout();
            SuspendLayout();
            // 
            // header
            // 
            header.BackColor = Color.Black;
            header.Controls.Add(closebtn);
            header.Dock = DockStyle.Top;
            header.Location = new Point(0, 0);
            header.Name = "header";
            header.Size = new Size(870, 50);
            header.TabIndex = 1;
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
            // logoPanel
            // 
            logoPanel.BackColor = Color.OrangeRed;
            logoPanel.Dock = DockStyle.Left;
            logoPanel.ForeColor = Color.Black;
            logoPanel.Location = new Point(0, 50);
            logoPanel.Name = "logoPanel";
            logoPanel.Size = new Size(350, 650);
            logoPanel.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Snow;
            label1.Location = new Point(650, 673);
            label1.Name = "label1";
            label1.Size = new Size(211, 20);
            label1.TabIndex = 26;
            label1.Text = "@ 2025 for UTD Senior Project";
            // 
            // creditLabel
            // 
            creditLabel.AutoSize = true;
            creditLabel.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            creditLabel.ForeColor = Color.Snow;
            creditLabel.Location = new Point(363, 653);
            creditLabel.Name = "creditLabel";
            creditLabel.Size = new Size(498, 20);
            creditLabel.TabIndex = 25;
            creditLabel.Text = "Created by Akshaan Singh, Dylan Hua, Daniel Kirfman, and Ricardo Vargas";
            // 
            // forgotPassBtn
            // 
            forgotPassBtn.BackColor = Color.Green;
            forgotPassBtn.FlatStyle = FlatStyle.Popup;
            forgotPassBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            forgotPassBtn.ForeColor = SystemColors.HighlightText;
            forgotPassBtn.Location = new Point(395, 506);
            forgotPassBtn.Name = "forgotPassBtn";
            forgotPassBtn.Size = new Size(181, 73);
            forgotPassBtn.TabIndex = 24;
            forgotPassBtn.Text = "Forgot Password";
            forgotPassBtn.UseVisualStyleBackColor = false;
            forgotPassBtn.Click += forgotPassBtn_Click;
            // 
            // loginBtn
            // 
            loginBtn.BackColor = Color.RoyalBlue;
            loginBtn.FlatStyle = FlatStyle.Popup;
            loginBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            loginBtn.ForeColor = SystemColors.HighlightText;
            loginBtn.Location = new Point(395, 431);
            loginBtn.Name = "loginBtn";
            loginBtn.Size = new Size(123, 51);
            loginBtn.TabIndex = 23;
            loginBtn.Text = "Login";
            loginBtn.UseVisualStyleBackColor = false;
            loginBtn.Click += loginBtn_Click;
            // 
            // passwordInput
            // 
            passwordInput.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            passwordInput.Location = new Point(395, 361);
            passwordInput.Name = "passwordInput";
            passwordInput.Size = new Size(299, 38);
            passwordInput.TabIndex = 22;
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            passwordLabel.ForeColor = Color.Snow;
            passwordLabel.Location = new Point(388, 327);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(172, 31);
            passwordLabel.TabIndex = 20;
            passwordLabel.Text = "Enter Password";
            // 
            // registerLink
            // 
            registerLink.AutoSize = true;
            registerLink.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            registerLink.LinkColor = Color.Lime;
            registerLink.Location = new Point(633, 172);
            registerLink.Name = "registerLink";
            registerLink.Size = new Size(200, 31);
            registerLink.TabIndex = 18;
            registerLink.TabStop = true;
            registerLink.Text = "Create an account";
            registerLink.VisitedLinkColor = Color.Brown;
            registerLink.LinkClicked += registerLink_LinkClicked;
            // 
            // utdIdInput
            // 
            utdIdInput.BorderStyle = BorderStyle.FixedSingle;
            utdIdInput.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            utdIdInput.Location = new Point(395, 258);
            utdIdInput.MaxLength = 10;
            utdIdInput.Name = "utdIdInput";
            utdIdInput.PlaceholderText = "1234567890";
            utdIdInput.Size = new Size(299, 38);
            utdIdInput.TabIndex = 21;
            utdIdInput.KeyPress += utdIdInput_KeyPress;
            // 
            // utdIdLabel
            // 
            utdIdLabel.AutoSize = true;
            utdIdLabel.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            utdIdLabel.ForeColor = Color.Snow;
            utdIdLabel.Location = new Point(388, 224);
            utdIdLabel.Name = "utdIdLabel";
            utdIdLabel.Size = new Size(150, 31);
            utdIdLabel.TabIndex = 19;
            utdIdLabel.Text = "Enter UTD ID";
            // 
            // loginLabel
            // 
            loginLabel.AutoSize = true;
            loginLabel.Font = new Font("Segoe UI", 37.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            loginLabel.ForeColor = Color.Snow;
            loginLabel.Location = new Point(518, 59);
            loginLabel.Name = "loginLabel";
            loginLabel.Size = new Size(192, 85);
            loginLabel.TabIndex = 16;
            loginLabel.Text = "Login";
            // 
            // discLabel
            // 
            discLabel.AutoSize = true;
            discLabel.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            discLabel.ForeColor = Color.Snow;
            discLabel.Location = new Point(388, 172);
            discLabel.Name = "discLabel";
            discLabel.Size = new Size(254, 31);
            discLabel.TabIndex = 17;
            discLabel.Text = "Don't have an account?";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.WindowFrame;
            ClientSize = new Size(870, 700);
            Controls.Add(logoPanel);
            Controls.Add(header);
            Controls.Add(label1);
            Controls.Add(creditLabel);
            Controls.Add(forgotPassBtn);
            Controls.Add(loginBtn);
            Controls.Add(passwordInput);
            Controls.Add(passwordLabel);
            Controls.Add(registerLink);
            Controls.Add(utdIdInput);
            Controls.Add(utdIdLabel);
            Controls.Add(loginLabel);
            Controls.Add(discLabel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            header.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel header;
        private Button closebtn;
        private Panel logoPanel;
        private Label label1;
        private Label creditLabel;
        private Button forgotPassBtn;
        private Button loginBtn;
        private TextBox passwordInput;
        private Label passwordLabel;
        private LinkLabel registerLink;
        private TextBox utdIdInput;
        private Label utdIdLabel;
        private Label loginLabel;
        private Label discLabel;
    }
}