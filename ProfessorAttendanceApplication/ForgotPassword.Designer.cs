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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
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
            confirmPasswordInput.TabIndex = 27;
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
            confirmBtn.TabIndex = 28;
            confirmBtn.Text = "Confirm";
            confirmBtn.UseVisualStyleBackColor = false;
            confirmBtn.Click += confirmBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(533, 242);
            label1.Name = "label1";
            label1.Size = new Size(29, 38);
            label1.TabIndex = 38;
            label1.Text = "*";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Red;
            label2.Location = new Point(608, 323);
            label2.Name = "label2";
            label2.Size = new Size(29, 38);
            label2.TabIndex = 39;
            label2.Text = "*";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Red;
            label3.Location = new Point(583, 421);
            label3.Name = "label3";
            label3.Size = new Size(29, 38);
            label3.TabIndex = 40;
            label3.Text = "*";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // clearBtn
            // 
            clearBtn.BackColor = Color.DarkOrange;
            clearBtn.FlatStyle = FlatStyle.Popup;
            clearBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            clearBtn.ForeColor = SystemColors.HighlightText;
            clearBtn.Location = new Point(533, 523);
            clearBtn.Name = "clearBtn";
            clearBtn.Size = new Size(120, 55);
            clearBtn.TabIndex = 41;
            clearBtn.Text = "Clear";
            clearBtn.UseVisualStyleBackColor = false;
            clearBtn.Click += clearBtn_Click;
            // 
            // ForgotPassword
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.WindowFrame;
            ClientSize = new Size(870, 700);
            Controls.Add(clearBtn);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
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
            Icon = (Icon)resources.GetObject("$this.Icon");
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
        private Label label1;
        private Label label2;
        private Label label3;
        private Button clearBtn;
    }
}