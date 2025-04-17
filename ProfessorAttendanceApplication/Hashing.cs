namespace ProfessorAttendanceApplication
{/*
     * Written by Akshaan Singh 04/16/2025
     * 
     * This class uses the BCrypt hashing algorithm to hash the input password
     * of a user. The BCrypt hashing algorithm uses the Blowfish cypher and an 
     * automatically generated salt/cost value to hash the provided password 
     * text and stores it as a string of generated characters. There are two 
     * main methods that are used in this class: HashPassword and VerifyPassword,
     * which generate or verify the password respectively. 
     * 
     */
    class Hashing
    {
        // This method uses an automatic cost and salt value to generate a hashed
        // password for the provided input string, and then returns the hashed
        // password.
        public string HashPassword(string input)
        {
            string hashedpass = BCrypt.Net.BCrypt.HashPassword(input);
            return hashedpass;
        }

        // This methods takes in an input string and a stored hashed password
        // to verify if they are the same or not, and returns a boolean result.
        public bool VerifyPassword(string input, string hashedpass)
        {
            bool verify = BCrypt.Net.BCrypt.Verify(input, hashedpass);
            return verify;
        }
    }
}
