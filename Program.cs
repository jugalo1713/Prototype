// Example using ICloneable interface (not recommended)

using Prototype;

var person1 = new PersonICloneable { Name = "John", LastName = "Doe" };
var person2 = (PersonICloneable)person1.Clone();




// Example using custom Clone method (recommended)

var person3 = new PersonCustomShallow { Name = "Jane", LastName = "Smith" };
var person4 = person3.ShallowClone();


// Example using a custom deep copy

var person5 = new PersonDeepCopy
{
    Name = "Julian",
    LastName = "Gallo",
    Address = new Address
    {
        Street = "carrera 48",
        Building = "My building"
    }
};

var person6 = person4.ShallowClone();