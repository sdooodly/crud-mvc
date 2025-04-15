// here we define a BLUEPRINT/CLASS for a person
// and this class has properties like id and name etc
// this is PUBLIC
namespace crud_mvc.Models
{
    public class Person
    {
        // public : access modifier
        // string : data type
        // Name - property is named in PascalCase way
        // get and set are accessors of this property, getter and setter
        // empty intitalises an empty value in the beginning. this ensures it will always have a default value
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string PhoneNumber { get; set; } = string.Empty;
    }
}