namespace RegexEmail_Validate
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter Your Email: ");
            string email = Console.ReadLine();

            RegexProgram regex=new RegexProgram();
            regex.CheckValidate(email);

        }
    }
}