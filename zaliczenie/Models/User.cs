namespace zaliczenie.Models
{
    public class User
    {
        public int Id { get; set; }
        public required string Email { get; set; }
        public required string Role {
            get { return Role ?? "User"; }
            set { }
        }
    }
}
