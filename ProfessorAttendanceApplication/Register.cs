using MySql.Data.MySqlClient;

namespace ProfessorAttendanceApplication
{
    public partial class Register : Form
    {
        // We call the drag class that allows us to make our form draggable
        Drag drag = new Drag();

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

        private void closebtn_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Close();
        }
    }
}
