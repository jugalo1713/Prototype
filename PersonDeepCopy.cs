namespace Prototype
{
    public class PersonDeepCopy
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public Address Address { get; set; }

        public PersonDeepCopy DeepCopy()
        {
            var newCopy = (PersonDeepCopy)this.MemberwiseClone();
            newCopy.Address = this.Address.DeepCopy();

            return newCopy;
        }
    }

    public class Address
    {
        public string Street { get; set; }
        public string Building { get; set; }

        public Address DeepCopy()
        {
            return (Address)this.MemberwiseClone();
        }
    }
}
