namespace UserRegistrationProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            UserRegistation user = new UserRegistation();
            Console.Write("Enter First Name : ");
            string firstName = Console.ReadLine();
            user.FirstNameAndLastName(firstName);
        }
    }
}