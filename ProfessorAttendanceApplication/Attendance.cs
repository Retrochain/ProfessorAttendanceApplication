using MySql.Data.MySqlClient;

namespace ProfessorAttendanceApplication
{
    public partial class Attendance : Form
    {
        MySqlConnection cnn = new MySqlConnection(Connection.ConnectionString);
        private string studentId;

        public Attendance(string studentId)
        {
            InitializeComponent();
            this.studentId = studentId;
        }

        // This is a custom close button that exits the application when pressed
        private void closebtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        // Fires when the form is loaded
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            LoadStudentAttendance();
        }

        private void LoadStudentAttendance()
        {
            try
            {
                cnn.Open();

                // Get student info
                string studentQuery = @"SELECT s.Name, s.StudentID, c.CourseName
                                        FROM Students s
                                        JOIN Courses c ON s.CourseID = c.CourseID
                                        WHERE s.StudentID = @studentId";

                using (MySqlCommand cmd = new MySqlCommand(studentQuery, cnn))
                {
                    cmd.Parameters.AddWithValue("@studentId", studentId);
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            StdntName.Text = reader.GetString("Name");
                            ID.Text = "ID: " + reader.GetString("StudentID");
                            courseInfo.Text = reader.GetString("CourseName");
                        }
                    }
                }

                // Get attendance records
                string attendanceQuery = @"SELECT Date, Status, Points, IPAddress, Time 
                                           FROM AttendanceRecords 
                                           WHERE StudentID = @studentId 
                                           ORDER BY Date DESC";

                using (MySqlCommand cmd = new MySqlCommand(attendanceQuery, cnn))
                {
                    cmd.Parameters.AddWithValue("@studentId", studentId);
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        dgvAttendance.Rows.Clear();
                        int total = 0, present = 0, excused = 0, late = 0;

                        while (reader.Read())
                        {
                            string date = reader["Date"].ToString();
                            string status = reader["Status"].ToString();
                            string points = reader["Points"].ToString();
                            string ip = reader["IPAddress"].ToString();
                            string time = reader["Time"].ToString();

                            AddAttendanceRow(date, status, points, ip, time);

                            total++;
                            if (status == "Present") present++;
                            else if (status == "Excused") excused++;
                            else if (status == "Late") late++;
                        }

                        totalAttendance.Text = $"Total Attendance: {present + late + excused}/{total}";
                        attendancePercentage.Text = $"Attendance Percentage: {(total > 0 ? (present * 100 / total).ToString() : "0")}%";
                        excusedAbsence.Text = $"Excused Absences: {excused}";
                        lateAttendance.Text = $"Late Attendance: {late}";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading attendance: " + ex.Message);
            }
            finally
            {
                cnn.Close();
            }
        }

        private void AddAttendanceRow(string date, string status, string points, string ip, string time)
        {
            int rowIdx = dgvAttendance.Rows.Add(date, status, points, ip, time, "Mark Excused", "Mark Late");

            var row = dgvAttendance.Rows[rowIdx];

            // Color coding for attendance status
            if (status == "Present")
                row.DefaultCellStyle.ForeColor = Color.Green;
            else if (status == "Absent")
                row.DefaultCellStyle.ForeColor = Color.Red;
        }

        private void dgvAttendance_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            string date = dgvAttendance.Rows[e.RowIndex].Cells[0].Value.ToString();

            if (dgvAttendance.Columns[e.ColumnIndex].HeaderText == "Mark Excused")
            {
                UpdateStatus(date, "Excused");
            }
            else if (dgvAttendance.Columns[e.ColumnIndex].HeaderText == "Mark Late")
            {
                UpdateStatus(date, "Late");
            }

            LoadStudentAttendance(); // Refresh data
        }

        private void UpdateStatus(string date, string newStatus)
        {
            try
            {
                cnn.Open();
                string query = @"UPDATE AttendanceRecords 
                                 SET Status = @status 
                                 WHERE StudentID = @studentId AND Date = @date";

                using (MySqlCommand cmd = new MySqlCommand(query, cnn))
                {
                    cmd.Parameters.AddWithValue("@status", newStatus);
                    cmd.Parameters.AddWithValue("@studentId", studentId);
                    cmd.Parameters.AddWithValue("@date", date);

                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to update attendance: " + ex.Message);
            }
            finally
            {
                cnn.Close();
            }
        }
    }
}
