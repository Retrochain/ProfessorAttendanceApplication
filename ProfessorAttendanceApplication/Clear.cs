namespace ProfessorAttendanceApplication
{
    /*
     * Written by Akshaan Singh on 04/06/2025
     * 
     * The main purpose of this class is to clear all textboxes in a form
     */
    class Clear
    {
        // This function clears the text content of all the textboxes in the form
        public void ClearAllText(Control ctrl)
        {
            // For each control in the current form (or control in this instance)
            foreach (Control c in ctrl.Controls)
            {
                // If the current control is a textbox, clear that control
                if (c is TextBox)
                {
                    ((TextBox)c).Clear();
                }
                else // Otherwise move on to the next control
                {
                    ClearAllText(c);
                }
            }
        }
    }
}
