namespace Domain.Users;
public class UsersEntity
{
    public Guid UserId { get; set; }
    public required string UserName { get; set; }
    public required string Email { get; set; }
    public required string PassWord { get; set; }
    public required string FirstName { get; set; }
    public required string LastName { get; set; }
    public required string Address { get; set; }
    public required string PhoneNumber { get; set; }
    public required string RegistrationDate { get; set; }
}
