using System.Collections.Generic;

namespace EricGhent.FooModels
{
    /// <summary>
    /// Note there are no NServiceBus dependencies in the model classes, this is set in the initializers in your other classes.
    /// This is a new thing in 3.x
    /// </summary>
   public class FooMessage:IFooMessage
    {
       public string FirstName { get; set; }
       public string LastName { get; set; }
       public List<Address> Addresses { get; set; }
    }


    public interface IFooMessage
    {
        string FirstName { get; set; }
        string LastName { get; set; }
        List<Address> Addresses { get; set; }
    }

    public class Address
    {
        public AddressType TypeOfAddress { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
    }

    public enum AddressType
    {
        Home,Work,POBox
    }

  
}
