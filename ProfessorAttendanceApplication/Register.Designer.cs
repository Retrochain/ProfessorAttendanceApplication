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
            temp = new Label();
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
            logoPanel.Dock = DockStyle.Left;
            logoPanel.ForeColor = Color.Black;
            logoPanel.Location = new Point(0, 50);
            logoPanel.Name = "logoPanel";
            logoPanel.Size = new Size(350, 650);
            logoPanel.TabIndex = 5;
            // 
            // temp
            // 
            temp.AutoSize = true;
            temp.Font = new Font("Segoe UI", 37.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            temp.ForeColor = Color.Brown;
            temp.Location = new Point(381, 251);
            temp.Name = "temp";
            temp.Size = new Size(417, 85);
            temp.TabIndex = 17;
            temp.Text = "Register page";
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(870, 700);
            Controls.Add(temp);
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
        private Label temp;
    }
}