using MySql.Data.MySqlClient;

namespace ProfessorAttendanceApplication
{
    public partial class ForgotPassword : Form
    {
        // We call the drag class that allows us to make our form draggable
        Drag drag = new Drag();

        // We call the clear class that allows us to clear all textbox inputs in our form
        Clear clear = new Clear();

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

        private void closebtn_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Close();
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            clear.ClearAllText(this);
        }

        private void confirmBtn_Click(object sender, EventArgs e)
        {
            // Once password is reset, close this form and reopen the login form
            Login login = new Login();
            login.Show();
            this.Close();
        }
    }
}
