using MySql.Data.MySqlClient;

namespace ProfessorAttendanceApplication
{
    partial class Attendance
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
            header = new Panel();
            closebtn = new Button();
            logoutBtn = new Button();
            StdntName = new Label();
            ID = new Label();
            recordLabel = new Label();
            totalAttendance = new Label();
            attendancePercentage = new Label();
            excusedAbsence = new Label();
            lateAttendance = new Label();
            courseInfo = new Label();
            dgvAttendance = new DataGridView();

            // Columns
            var colDate = new DataGridViewTextBoxColumn { HeaderText = "Date" };
            var colStatus = new DataGridViewTextBoxColumn { HeaderText = "Attendance" };
            var colPoints = new DataGridViewTextBoxColumn { HeaderText = "Points" };
            var colIP = new DataGridViewTextBoxColumn { HeaderText = "IP" };
            var colTime = new DataGridViewTextBoxColumn { HeaderText = "Time" };
            var colExcused = new DataGridViewLinkColumn { HeaderText = "Mark Excused", Text = "Mark Excused", UseColumnTextForLinkValue = true };
            var colLate = new DataGridViewLinkColumn { HeaderText = "Mark Late", Text = "Mark Late", UseColumnTextForLinkValue = true };

            ((System.ComponentModel.ISupportInitialize)(dgvAttendance)).BeginInit();
            SuspendLayout();

            // Header panel
            header.BackColor = Color.FromArgb(159, 75, 1);
            header.Location = new Point(0, 0);
            header.Name = "header";
            header.Size = new Size(761, 38);
            header.TabIndex = 1;

            // Close button
            closebtn.BackColor = Color.Red;
            closebtn.FlatStyle = FlatStyle.Popup;
            closebtn.Location = new Point(724, 4);
            closebtn.Size = new Size(35, 30);
            closebtn.Click += closebtn_Click;

            // Logout button
            logoutBtn.BackColor = Color.Transparent;
            logoutBtn.Font = new Font("Segoe UI", 8.25F);
            logoutBtn.ForeColor = Color.Black;
            logoutBtn.Location = new Point(697, 50);
            logoutBtn.Size = new Size(57, 22);
            logoutBtn.Text = "Logout";
            logoutBtn.UseVisualStyleBackColor = false;
            logoutBtn.Click += logoutBtn_Click;

            // Student Name label
            StdntName.Location = new Point(40, 50);
            StdntName.Size = new Size(250, 20);
            StdntName.Font = new Font("Segoe UI", 10F, FontStyle.Bold);

            // ID label
            ID.Location = new Point(300, 50);
            ID.Size = new Size(200, 20);
            ID.Font = new Font("Segoe UI", 10F);

            // Attendance Record
            recordLabel.Location = new Point(40, 80);
            recordLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            recordLabel.ForeColor = Color.DimGray;
            recordLabel.Text = "Attendance Record";

            // Stats
            totalAttendance.Location = new Point(40, 100);
            totalAttendance.Size = new Size(200, 16);

            attendancePercentage.Location = new Point(40, 120);
            attendancePercentage.Size = new Size(200, 16);

            excusedAbsence.Location = new Point(40, 140);
            excusedAbsence.Size = new Size(200, 16);

            lateAttendance.Location = new Point(40, 160);
            lateAttendance.Size = new Size(200, 16);

            // Course Info
            courseInfo.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            courseInfo.Location = new Point(250, 185);
            courseInfo.Size = new Size(300, 25);
            courseInfo.TextAlign = ContentAlignment.MiddleCenter;

            // DataGridView setup
            dgvAttendance.AllowUserToAddRows = false;
            dgvAttendance.AllowUserToDeleteRows = false;
            dgvAttendance.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAttendance.Location = new Point(40, 220);
            dgvAttendance.Name = "dgvAttendance";
            dgvAttendance.ReadOnly = true;
            dgvAttendance.RowHeadersVisible = false;
            dgvAttendance.Size = new Size(680, 250);
            dgvAttendance.Columns.AddRange(new DataGridViewColumn[]
            {
                colDate, colStatus, colPoints, colIP, colTime, colExcused, colLate
            });
            dgvAttendance.CellContentClick += dgvAttendance_CellContentClick;

            // Attendance Form
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(217, 217, 217);
            ClientSize = new Size(761, 525);
            Controls.Add(header);
            Controls.Add(closebtn);
            Controls.Add(logoutBtn);
            Controls.Add(StdntName);
            Controls.Add(ID);
            Controls.Add(recordLabel);
            Controls.Add(totalAttendance);
            Controls.Add(attendancePercentage);
            Controls.Add(excusedAbsence);
            Controls.Add(lateAttendance);
            Controls.Add(courseInfo);
            Controls.Add(dgvAttendance);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Attendance";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Attendance";
            ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(dgvAttendance)).EndInit();
        }

        #endregion

        private Panel header;
        private Button closebtn;
        private Button logoutBtn;
        private Label StdntName;
        private Label ID;
        private Label recordLabel;
        private Label totalAttendance;
        private Label attendancePercentage;
        private Label excusedAbsence;
        private Label lateAttendance;
        private Label courseInfo;
        private DataGridView dgvAttendance;

    }
}