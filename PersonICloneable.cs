namespace Prototype
{
    // This is an implementation using ICloneable, will return an object and we will need to cast it to the correct type, also it is not clear if it is a deep or shallow copy, so it is not recommended to use ICloneable interface,
    // will be better to implement our own Clone method, as we will see in the next example.
    public class PersonICloneable: ICloneable
    {
        public string Name { get; set; }
        public string LastName { get; set; }


        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
