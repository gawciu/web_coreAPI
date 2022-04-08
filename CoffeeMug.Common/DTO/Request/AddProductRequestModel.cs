using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeMug.Common.DTO.Request
{
    public class AddProductRequestModel
    {

        private bool IsValid;
        private string _name;

        public string Name
        {
            get { return _name; }
            set 
            { 
                if(string.IsNullOrEmpty(value))
                {
                    IsValid = false;
                    throw new InvalidDataException("Name cannot be blank");


                }
                else if(value.Length >= 100)
                {
                    IsValid = false;
                    throw new InvalidDataException("Name cannot be longer than 100 chars");

                }
                else
                {
                    IsValid = true; 
                    _name = value;
                }
            }
        }


        public int? Number { get; set; }
        public int? Quantity { get; set; }

        private string _description;

        public string Description
        {
            get { return _description; }
            set 
            {
                if(value.Length >= 200)
                {
                    IsValid = false;
                    throw new InvalidDataException("Description cannot be longer than 200 chars");

                }
                else
                {
                    _description = value;
                }
                
            }
        }
        private decimal _price;

        public decimal Price
        {
            get { return _price; }
            set
            {
                if (value == 0)
                {
                    IsValid = false;
                    throw new InvalidDataException("Price value cannot be zero");
                }
                else
                {
                    _price = value;
                    IsValid = true;
                }

            }
        }

    }
}
