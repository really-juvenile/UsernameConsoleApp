namespace UsernameConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
          
            Console.WriteLine("Enter your username:");
            string username = Console.ReadLine();
            string filePath = "D:\\aproSCM\\Usernames.txt"; //file path

            // Append u_name;
            File.AppendAllText(filePath, username + "\n"); // this directly appends any word to the file
            Console.WriteLine("Username added successfulllyy.");
           
        }
    }
}
