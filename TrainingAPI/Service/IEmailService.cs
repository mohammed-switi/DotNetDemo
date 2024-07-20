namespace TrainingAPI.Service
{
    public interface IEmailService
    {

        public string SendEmail(string email);
    }


    public class EmailService : IEmailService
    {
       public string SendEmail(string email)
        {
            return email;
        }
    }
}
