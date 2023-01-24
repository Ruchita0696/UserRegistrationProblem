namespace UserRegistrationProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            UserRegistation user = new UserRegistation();
            user.UserInputName();
            user.Email();
            user.MobileNumber();
            user.PassWord();
           
        }
    }
}