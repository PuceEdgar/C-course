using WindowsFormsApp1.Enums;
using WindowsFormsApp1.Helpers;

namespace WindowsFormsApp1.Models
{
    public class AddressInfo
    {

        public CountryEnum Country { get; set; }

        public string City { get; set; }

        public string Street { get; set; }

        public string ZipCode { get; set; }
        public string FullAddress { get; set; }



        public bool IsValid()
        {
            return Validator.ValidateCity(City) &&
                    Validator.ValidateStreet(Street) &&
                    Validator.ValidateZipCode(ZipCode) &&
                    Country != 0;
        }
    }
}
