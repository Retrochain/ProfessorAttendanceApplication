namespace ProfessorAttendanceApplication
{
    partial class ForgotPassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ForgotPassword));
            closebtn = new Button();
            logoPanel = new Panel();
            header = new Panel();
            registerLabel = new Label();
            newPasswordInput = new TextBox();
            newPasswordLabel = new Label();
            utdIdInput = new TextBox();
            utdIdLabel = new Label();
            confirmPasswordInput = new TextBox();
            confirmPasswordLabel = new Label();
            label6 = new Label();
            creditLabel = new Label();
            confirmBtn = new Button();
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
            logoPanel.TabIndex = 6;
            // 
            // header
            // 
            header.BackColor = Color.Black;
            header.Controls.Add(closebtn);
            header.Dock = DockStyle.Top;
            header.Location = new Point(0, 0);
            header.Name = "header";
            header.Size = new Size(870, 50);
            header.TabIndex = 5;
            // 
            // registerLabel
            // 
            registerLabel.AutoSize = true;
            registerLabel.Font = new Font("Segoe UI", 37.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            registerLabel.ForeColor = Color.Snow;
            registerLabel.Location = new Point(470, 64);
            registerLabel.Name = "registerLabel";
            registerLabel.Size = new Size(315, 170);
            registerLabel.TabIndex = 18;
            registerLabel.Text = "Password \r\nReset";
            registerLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // newPasswordInput
            // 
            newPasswordInput.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            newPasswordInput.Location = new Point(394, 370);
            newPasswordInput.Name = "newPasswordInput";
            newPasswordInput.PasswordChar = '*';
            newPasswordInput.Size = new Size(299, 38);
            newPasswordInput.TabIndex = 26;
            // 
            // newPasswordLabel
            // 
            newPasswordLabel.AutoSize = true;
            newPasswordLabel.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            newPasswordLabel.ForeColor = Color.Snow;
            newPasswordLabel.Location = new Point(387, 336);
            newPasswordLabel.Name = "newPasswordLabel";
            newPasswordLabel.Size = new Size(225, 31);
            newPasswordLabel.TabIndex = 24;
            newPasswordLabel.Text = "Enter New Password";
            // 
            // utdIdInput
            // 
            utdIdInput.AutoCompleteMode = AutoCompleteMode.Suggest;
            utdIdInput.BorderStyle = BorderStyle.FixedSingle;
            utdIdInput.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            utdIdInput.Location = new Point(394, 282);
            utdIdInput.MaxLength = 10;
            utdIdInput.Name = "utdIdInput";
            utdIdInput.PlaceholderText = "1234567890";
            utdIdInput.Size = new Size(299, 38);
            utdIdInput.TabIndex = 25;
            // 
            // utdIdLabel
            // 
            utdIdLabel.AutoSize = true;
            utdIdLabel.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            utdIdLabel.ForeColor = Color.Snow;
            utdIdLabel.Location = new Point(387, 248);
            utdIdLabel.Name = "utdIdLabel";
            utdIdLabel.Size = new Size(150, 31);
            utdIdLabel.TabIndex = 23;
            utdIdLabel.Text = "Enter UTD ID";
            // 
            // confirmPasswordInput
            // 
            confirmPasswordInput.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            confirmPasswordInput.Location = new Point(394, 462);
            confirmPasswordInput.Name = "confirmPasswordInput";
            confirmPasswordInput.PasswordChar = '*';
            confirmPasswordInput.Size = new Size(299, 38);
            confirmPasswordInput.TabIndex = 28;
            // 
            // confirmPasswordLabel
            // 
            confirmPasswordLabel.AutoSize = true;
            confirmPasswordLabel.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            confirmPasswordLabel.ForeColor = Color.Snow;
            confirmPasswordLabel.Location = new Point(387, 428);
            confirmPasswordLabel.Name = "confirmPasswordLabel";
            confirmPasswordLabel.Size = new Size(202, 31);
            confirmPasswordLabel.TabIndex = 27;
            confirmPasswordLabel.Text = "Confirm Password";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Snow;
            label6.Location = new Point(650, 673);
            label6.Name = "label6";
            label6.Size = new Size(211, 20);
            label6.TabIndex = 37;
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
            creditLabel.TabIndex = 36;
            creditLabel.Text = "Created by Akshaan Singh, Dylan Hua, Daniel Kirfman, and Ricardo Vargas";
            // 
            // confirmBtn
            // 
            confirmBtn.BackColor = Color.Green;
            confirmBtn.FlatStyle = FlatStyle.Popup;
            confirmBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            confirmBtn.ForeColor = SystemColors.HighlightText;
            confirmBtn.Location = new Point(394, 523);
            confirmBtn.Name = "confirmBtn";
            confirmBtn.Size = new Size(120, 55);
            confirmBtn.TabIndex = 38;
            confirmBtn.Text = "Confirm";
            confirmBtn.UseVisualStyleBackColor = false;
            // 
            // ForgotPassword
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.WindowFrame;
            ClientSize = new Size(870, 700);
            Controls.Add(confirmBtn);
            Controls.Add(label6);
            Controls.Add(creditLabel);
            Controls.Add(confirmPasswordInput);
            Controls.Add(confirmPasswordLabel);
            Controls.Add(newPasswordInput);
            Controls.Add(newPasswordLabel);
            Controls.Add(utdIdInput);
            Controls.Add(utdIdLabel);
            Controls.Add(registerLabel);
            Controls.Add(logoPanel);
            Controls.Add(header);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ForgotPassword";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ForgotPassword";
            header.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button closebtn;
        private Panel logoPanel;
        private Panel header;
        private Label registerLabel;
        private TextBox newPasswordInput;
        private Label newPasswordLabel;
        private TextBox utdIdInput;
        private Label utdIdLabel;
        private TextBox confirmPasswordInput;
        private Label confirmPasswordLabel;
        private Label label6;
        private Label creditLabel;
        private Button confirmBtn;
    }
}