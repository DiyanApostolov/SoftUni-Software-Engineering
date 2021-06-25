namespace CarShop.Models.Users
{
    public class RegisterFormModel
    {
        public string Username { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public string ConfirmPassword { get; set; }

        public string UserType { get; set; }
    }
}
