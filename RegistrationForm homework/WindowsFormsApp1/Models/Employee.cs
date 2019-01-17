namespace WindowsFormsApp1.Models
{
    public class Employee
    {
        public Employee()
        {
            CommonInfo = new CommonInfo();
            ContactInfo = new ContactInfo();
            AddressInfo = new AddressInfo();

        }

        public CommonInfo CommonInfo { get; set; }
        public ContactInfo ContactInfo { get; set; }

        public AddressInfo AddressInfo { get; set; }

        public bool IsValid()
        {
            return CommonInfo.IsValid() && ContactInfo.IsValid() && AddressInfo.IsValid();
        }
    }
}
