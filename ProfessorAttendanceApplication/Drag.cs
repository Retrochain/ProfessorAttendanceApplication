using System.Runtime.InteropServices;

namespace ProfessorAttendanceApplication
{
    /*
     * Written by Akshaan Singh 04/04/2025
     * 
     * This is mostly pre generated Visual Studio code that allows access to System32.
     * System32 access is needed to access mouse clicks and movements outside
     * of the normal control methods. This way, we can make the form draggable
     * even though there is no border visible.
     */
    public class Drag
    {
        // These methods and variables access System32 files
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HTCAPTION = 0x2;

        [DllImport("User32.dll")]
        public static extern bool ReleaseCapture();

        [DllImport("User32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        // This method allows the form to be dragged to the location where the left mouse button is let go. 
        public void DragForm(Form form)
        {
            ReleaseCapture();
            SendMessage(form.Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
        }

        // This method tracks the mouse left click on a provided control and also checks if the control is a form 
        public void Control_MouseDown(object? sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && sender is Control control && control.FindForm() is Form form)
            {
                DragForm(form);
            }
        }
    }
}
