namespace ParkingLotManagementSystem.Domain.Models
{
    public abstract class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public DateOnly DOB { get; set; }
        public BloodGroup BloodGroup { get; set; }
        public Address Address { get; set; }
    }
}
