using MySql.Data.MySqlClient;
using System.Text.RegularExpressions;

namespace ProfessorAttendanceApplication
{
    /*
     * Written By Akshaan Singh on 04/06/2025 for UTD Senior Project
     * 
     * The purpose of this form is to allow professors to create a new
     * account in the database
     */
    public partial class Register : Form
    {
        // We call the drag class that allows us to make our form draggable
        Drag drag = new Drag();

        // We call the clear class that allows us to clear all textbox inputs in our form
        Clear clear = new Clear();

        // We call the hashing class that allows us to hash our passwords using BCrypt
        Hashing hash = new Hashing();

        // The variable cnn is being initialized to contain the connection string for the database
        MySqlConnection cnn = new MySqlConnection(Connection.ConnectionString);

        public Register()
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

        // The close button closes this form and shows the login form again
        private void closebtn_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Close();
        }

        // On press, clear all textbox contents in this form
        private void clearBtn_Click(object sender, EventArgs e)
        {
            clear.ClearAllText(this);
        }

        // Upon clicking the Register button, the professor's information should be saved into the database.
        // We will add input checks and parameterized SQL statements to insert the information to the database.
        private void registerBtn_Click(object sender, EventArgs e)
        {
            // First we check if any of the input fields are empty or not
            if (!(string.IsNullOrEmpty(firstNameInput.Text) || string.IsNullOrEmpty(lastNameInput.Text) || string.IsNullOrEmpty(utdIdInput.Text) || string.IsNullOrEmpty(passwordInput.Text)))
            {
                /*
                 * The first thing we need to do is to split the entered email so we can store the username.
                 * The first part of the email (before the @) is the user name of the professor (which consists
                 * of the first initials of the first, middle, and last name, followed by a 6 digit number.). 
                 * The username is stored in the database in the username field and for now, doesn't offer much.
                 */

                // Have to check if the UTD Email input is null/empty or not
                if (!string.IsNullOrEmpty(utdEmailInput.Text))
                {
                    string emailInput = utdEmailInput.Text;

                    // We first check if the email format is correct: abc123456@utdallas.edu using regex
                    if (Regex.IsMatch(emailInput, @"^[a-z]{3}\d{6}@utdallas\.edu$"))
                    {
                        /* 
                         * To split the email into two parts, we will use the string.Split() method to split the string
                         * at the '@' character, giving us 2 strings, one that contains the username and the other that
                         * contains the email domain name (utdallas.edu). We will store the first substring for later use.
                         */

                        string[] emailSplit = emailInput.Split('@');
                        string username = emailSplit[0];

                        // Next we check if the input password match
                        if (!(passwordInput.Text == confirmPasswordInput.Text))
                        {
                            MessageBox.Show("Password must match!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            /*
                             * We follow the same steps are the login form, so we first open the connection with the database.
                             * Then we write our parameterized SQL statement, set the MySQL command type, set the parameters 
                             * along with their types, and then execute the query, displaying a success or error message accordingly.
                             */

                            // Open the connection with the database
                            cnn.Open();

                            // Create our SQL statement with parameterized variables
                            string sql = "INSERT INTO professors (utdID, firstName, middleInit, lastName, email, userName, password) " +
                                         "VALUES (@ProfessorUTDID, @ProfessorFirstName, @ProfessorMiddleName, @ProfessorLastName, @ProfessorEmail, @ProfessorUserName, @ProfessorPassword)";

                            // Connect the sql query with the connection string, and define the sql statement type (text)
                            MySqlCommand cmd = new MySqlCommand(sql, cnn);
                            cmd.CommandType = System.Data.CommandType.Text;

                            // Set the Parameterized variables
                            cmd.Parameters.Add("@ProfessorUTDID", MySqlDbType.String).Value = utdIdInput.Text;
                            cmd.Parameters.Add("@ProfessorFirstName", MySqlDbType.VarChar).Value = firstNameInput.Text;
                            cmd.Parameters.Add("@ProfessorMiddleName", MySqlDbType.String).Value = midInitialInput.Text;
                            cmd.Parameters.Add("@ProfessorLastName", MySqlDbType.VarChar).Value = lastNameInput.Text;
                            cmd.Parameters.Add("@ProfessorEmail", MySqlDbType.VarChar).Value = utdEmailInput.Text;
                            cmd.Parameters.Add("@ProfessorUserName", MySqlDbType.VarChar).Value = username;
                            // We must hash our passwords when we store them in our database
                            cmd.Parameters.Add("@ProfessorPassword", MySqlDbType.VarChar).Value = hash.HashPassword(passwordInput.Text);

                            // We use a try and catch statement to catch any SQL errors
                            try
                            {
                                // Execute the non query to add the user into the database, and display a success message
                                cmd.ExecuteNonQuery();
                                MessageBox.Show("You are successfully registered! \n", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                // Upon registration, just close this form and open the login screen again
                                Login login = new Login();
                                login.Show();
                                this.Close();
                            }
                            catch (MySqlException fail) // Display appropriate error message
                            {
                                if (fail.Number == 1062) // MySql has different codes for error messages, and 1062 is the code for duplicate enteries in a UNIQUE field
                                {
                                    MessageBox.Show("User already exists!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                                else
                                {
                                    MessageBox.Show("Database connection failed. \n" + fail.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }

                            // Close the connection with the database
                            cnn.Close();
                        }
                    }
                    else // Display error message for incorrect email format
                    {
                        MessageBox.Show("Email must be in correct format: abc123456@utdallas.edu", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else // Otherwise we prompt an error
                {
                    MessageBox.Show("Please enter all the required information! \n", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else // If even a single field is empty, we prompt an error
            {
                MessageBox.Show("Please enter all the required information! \n", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
