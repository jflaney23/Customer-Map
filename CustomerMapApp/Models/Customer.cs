namespace CustomerMapApp.Models
{
    public class Customer
    {
        public int Id {get; set;}
        public required string FirstName {get; set;}
        
        public required string LastName {get; set;}

        public string? PhoneNumber {get; set;}

        public bool OnFacebook {get; set;}

        public string? Email {get; set;}

        public string? StreetAddress {get; set;}

        public string? City {get; set;}

        public string? State {get; set;}

        public string? ZipCode {get; set;}

        public string? Country {get; set;}
    }
}