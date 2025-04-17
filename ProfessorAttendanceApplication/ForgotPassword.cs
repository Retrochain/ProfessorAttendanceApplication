using MySql.Data.MySqlClient;

namespace ProfessorAttendanceApplication
{
    /*
     * Written By Akshaan Singh on 04/15/2025 for UTD Senior Project
     * 
     * The purpose of this form is to allow professors to create or 
     * update their password
     */
    public partial class ForgotPassword : Form
    {
        // We call the drag class that allows us to make our form draggable
        Drag drag = new Drag();

        // We call the clear class that allows us to clear all textbox inputs in our form
        Clear clear = new Clear();

        // We call the hashing class that allows us to hash our passwords using BCrypt
        Hashing hash = new Hashing();

        // The variable cnn is being initialized to contain the connection string for the database
        MySqlConnection cnn = new MySqlConnection(Connection.ConnectionString);

        public ForgotPassword()
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


        // Upon clicking the Confirm button, the professor's new password should be saved into the database.
        // We will add input checks and parameterized SQL statements to insert the password to the database.
        private void confirmBtn_Click(object sender, EventArgs e)
        {
            // Firstly, we check if the UTD ID input is empty or not
            if (string.IsNullOrEmpty(utdIdInput.Text))
            {
                MessageBox.Show("Please input the UTD ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } // Then we check if both the password fields are empty or not
            else if (string.IsNullOrEmpty(newPasswordInput.Text) && string.IsNullOrEmpty(confirmPasswordInput.Text))
            {
                MessageBox.Show("Enter the passwords please!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else // Then, we check if the passwords match each other or not
            {
                if (string.Equals(newPasswordInput.Text, confirmPasswordInput.Text))
                {
                    /*
                     * After all the checks have been done, we get the user's record using the UTD ID, and then we insert
                     * the new password from the input field into their record. The password is entered using a parameterized
                     * SQL statement so no SQL injections should take place.
                     */

                    // Open the connection with the database
                    cnn.Open();

                    // We first create a SQL statement to check if the UTD ID exists in the database
                    string checkSql = "SELECT utdID FROM professors WHERE utdID = @ProfessorUTDID";

                    // Connect the sql query with the connection string, and define the sql statement type (text)
                    MySqlCommand cmd = new MySqlCommand(checkSql, cnn);
                    cmd.CommandType = System.Data.CommandType.Text;

                    // Set the Parameterized variables
                    cmd.Parameters.Add("@ProfessorUTDID", MySqlDbType.String).Value = utdIdInput.Text;

                    // We use a try and catch statement to catch any SQL errors
                    try
                    {
                        // Execute the non query using the reader to read the record if the UTD ID exists
                        MySqlDataReader reader = cmd.ExecuteReader();

                        if (reader.HasRows) // Returns true if the UTD ID exists in the database
                        {
                            // Always close the reader when done
                            reader.Close();

                            // Create the SQL string to update the password
                            string updateSql = "UPDATE professors " +
                                               "SET password = @Password " +
                                               "WHERE utdID = @ProfessorUTDID";

                            // Once again, connect the SQL command with the database and set the parameters
                            MySqlCommand upd = new MySqlCommand(updateSql, cnn);
                            upd.CommandType = System.Data.CommandType.Text;

                            upd.Parameters.Add("@ProfessorUTDID", MySqlDbType.String).Value = utdIdInput.Text;

                            // We must hash our passwords when we store them
                            upd.Parameters.Add("@Password", MySqlDbType.String).Value = hash.HashPassword(confirmPasswordInput.Text);

                            // Using another try and catch statement to catch exceptions
                            try
                            {
                                // Execute the query and display success message is successful in updating
                                upd.ExecuteNonQuery();
                                MessageBox.Show("Password Updated Successfully! \n", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                // Once password is reset, close this form and reopen the login form
                                Login login = new Login();
                                login.Show();
                                this.Close();
                            }
                            catch (MySqlException failure) // Display appropriate error message
                            {
                                MessageBox.Show("Database connection while updating failed. \n" + failure.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else // Otherwise display the error message for unfound UTD ID
                        {
                            MessageBox.Show("UTD ID not found. \n", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (MySqlException fail) // Display appropriate error message
                    {
                        MessageBox.Show("Database connection while searcing failed. \n" + fail.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    // Close the connection with the database
                    cnn.Close();
                }
                else // Display error message as the passwords dont match
                {
                    MessageBox.Show("The passwords must match!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
