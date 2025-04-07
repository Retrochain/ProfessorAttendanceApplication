using MySql.Data.MySqlClient;

namespace ProfessorAttendanceApplication
{
    public partial class Login : Form
    {
        /*
         * Written by Akshaan Singh on 4/4/2025 for CS 4485.0W1 Senior Project
         * 
         * The login form is the first form/window that the user sees when opening the application.
         * The form is simple and serves one function, to either create or access the user's account. 
         * As such, the form has a 2 input fields: UTD ID and Password. These fields perform the basic
         * checks such as checking if they exist in the database or if the fields are inputted incorrectly.
         * These checks are performed after the login button is pressed, upon which the 
         */

        // We call the drag class that allows us to make our form draggable
        Drag drag = new Drag();

        // The variable cnn is being initialized to contain the connection string for the database
        MySqlConnection cnn = new MySqlConnection(Connection.ConnectionString);

        // The basic controller for our form
        public Login()
        {
            InitializeComponent();
            /*
             * For every control that needs to be made draggable, we need to initialize that control
             * with the Control_MouseDown method which is of type MouseEventHandler. 
             */
            this.MouseDown += new MouseEventHandler(drag.Control_MouseDown);
            this.header.MouseDown += new MouseEventHandler(drag.Control_MouseDown);
            this.logoPanel.MouseDown += new MouseEventHandler(drag.Control_MouseDown);
        }

        // This is a custom close button that exits the application when pressed
        private void closebtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // This method forces the user to only enter digits in the utd id input field
        private void utdIdInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        // This is the first main input button for the login screen, and it tracks if the user exists in the database
        private void loginBtn_Click(object sender, EventArgs e)
        {
            // First we check if the utd id field is empty or the id is less than 10 characters
            if (string.IsNullOrEmpty(utdIdInput.Text) || utdIdInput.Text.Length != 10)
            {
                MessageBox.Show("UTD ID must be 10 characters! \n", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } // We then check if the password field is empty or not
            else if (string.IsNullOrEmpty(passwordInput.Text))
            {
                MessageBox.Show("Password needs to be entered! \n", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } // Otherwise we know that the user entered valid input strings
            else
            {
                // First we open the connection with the database using the connection string
                cnn.Open();

                // We then create our sql command that we want to use for the database access
                // We ask for the utd id and the password from the professor table
                string sql = "SELECT utdID, password FROM professors WHERE utdID = @InputUTDID;";

                /* 
                 * To prevent SQL Injections, we use a parameterized SQL command for inputs, this prevents from
                 * unwanted characters to be entered into the input field and allow a malicous user to access 
                 * private information using sql special characters. We define a sql string and use the special 
                 * MySqlCommand method to pass our string, which contains special parameters that we later define 
                 * and provide the data type of aswell. For our input, we use the command type text and data type 
                 * varchar (as defined in the database) to avoid passing through any special characters. When the 
                 * SQL command is accessed by the database, our specialized SQL command only allows text that is 
                 * 10 characters long and does not contain any special characters. 
                 */
                MySqlCommand cmd = new MySqlCommand(sql, cnn);
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.Add("@InputUTDID", MySqlDbType.VarChar).Value = utdIdInput.Text;

                // We use a try and catch statement here to display errors in a prettier way and not jumpscare the user
                try
                {
                    // Using the mysqldatareader command, we check if the entered UTD ID exists in the database or not
                    MySqlDataReader reader = cmd.ExecuteReader();
                    if (reader.HasRows) // If the user exists, the reader returns a row containing the entire record
                    {
                        /*
                         * And if it does, we then check if the password entered exists or not
                         * 
                         * We can only called reader.Read() if the user utd id exists, as it 
                         * will return row(s) that can be read by the Read() method, otherwise
                         * it throws an exception (which we dont need to catch as this is a 
                         * while loop.
                         */
                        while (reader.Read())
                        {
                            // We get the password of the current user using the reader
                            string? pwd = reader["password"].ToString();

                            // And compare it with the entered password
                            if (pwd == passwordInput.Text)
                            {
                                MessageBox.Show("Login Success! \n", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else // Otherwise we know the password is incorrect
                            {
                                MessageBox.Show("Incorrect Password. \n", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    else // If it doesn't, we display an error message
                    {
                        MessageBox.Show("UTD ID not found. \n", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    // Close the reader as we are done reading the database record
                    reader.Close();
                }
                catch (MySqlException fail) // We then display this error if the connection to the data base has failed
                {
                    MessageBox.Show("Database connection failed. \n" + fail.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                // Always close the connection with the database using our connection string
                cnn.Close();
            }
        }

        // This link opens up the forgot password form and hides the current one
        private void forgotPassBtn_Click(object sender, EventArgs e)
        {
            ForgotPassword forgotpassword = new ForgotPassword();
            forgotpassword.Show();
            this.Hide();
        }

        // This link opens up the registration form and hides the current one
        private void registerLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Register register = new Register();
            register.Show();
            this.Hide();
        }
    }
}
