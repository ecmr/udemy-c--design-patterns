using System;

namespace Prototype
{
    public abstract class User: ICloneable
    {

        public String FirstName {get; set;}
        public String LastName { get; set; }
        public String UserName { get; set; }
        public String Password { get; set; }
        public Address HomeAddress { get; set; }
        public Address BusinessAddress { get; set; }

        public abstract object Clone();
        public abstract User DeepClone();
    }
}