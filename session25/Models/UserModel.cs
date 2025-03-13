using System.ComponentModel.DataAnnotations;

public class UserModel{
    [Required(ErrorMessage = "Please input UserName")]
    [StringLength(50, MinimumLength = 6, ErrorMessage = "UserName must be between 6 and 50 characters")]
    public string UserName { get; set;}= string.Empty;

    [Required(ErrorMessage = "Please input Password")]
    [MinLength(8, ErrorMessage = "Password must be at least 8 characters")]
    public string Password { get; set;}= string.Empty;
    public string FullName { get; set;}= string.Empty;
    public string Gender { get; set;}= "Male";
    public string Country { get; set;}= "VietNam";

    [Required(ErrorMessage = "Please input Phone")]
    [RegularExpression(@"^0\d{9,10}$", ErrorMessage = "Phone must be 10 or 11 digits and start with 0")]
    public string Phone { get; set;}= string.Empty;
}