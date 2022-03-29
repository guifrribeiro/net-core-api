namespace Order.Domain.Models
{
    public class UserModel
    {
        public string Name { get; set; }
    
        public string Login { get; set; }
    
        public string PasswordHash { get; set; }
    }
}