using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Service_Shop
{
    internal class Service
    {
        private static int serviceCount = 0;
        private readonly int identificationNumber;

        // Private fields with initialization to handle nullable warnings
        private string _firstName = string.Empty;
        private string _lastName = string.Empty;
        private string _phoneNumber = string.Empty;
        private string _make = string.Empty;
        private string _model = string.Empty;
        private string _colour = string.Empty;
        private int _year;
        private bool _engOilChange;
        private bool _transOilChange;
        private bool _airFilterChange;
        private decimal _price;

        // Read-only property for total count of service objects
        public static int Count
        {
            get { return serviceCount; }
        }

        // Read-only property for unique identifier
        public int IdentificationNumber
        {
            get { return identificationNumber; }
        }

        // Properties as specified in requirements
        public string firstName
        {
            get { return _firstName; }
            set { _firstName = value ?? string.Empty; }
        }

        public string lastName
        {
            get { return _lastName; }
            set { _lastName = value ?? string.Empty; }
        }

        public string phoneNumber
        {
            get { return _phoneNumber; }
            set { _phoneNumber = value ?? string.Empty; }
        }

        public string Make
        {
            get { return _make; }
            set { _make = value ?? string.Empty; }
        }

        public string Model
        {
            get { return _model; }
            set { _model = value ?? string.Empty; }
        }

        public string Colour
        {
            get { return _colour; }
            set { _colour = value ?? string.Empty; }
        }

        public int Year
        {
            get { return _year; }
            set { _year = value; }
        }

        public bool EngOilChange
        {
            get { return _engOilChange; }
            set { _engOilChange = value; }
        }

        public bool TransOilChange
        {
            get { return _transOilChange; }
            set { _transOilChange = value; }
        }

        public bool AirFilterChange
        {
            get { return _airFilterChange; }
            set { _airFilterChange = value; }
        }

        public decimal Price
        {
            get { return _price; }
            set { _price = value; }
        }

        // Default constructor with proper initialization
        public Service()
        {
            serviceCount++;
            identificationNumber = serviceCount;

            // Initialize numeric and boolean properties
            _year = DateTime.Now.Year;
            _engOilChange = false;
            _transOilChange = false;
            _airFilterChange = false;
            _price = 0.0m;
        }

        // Parameterized constructor
        public Service(string firstName, string lastName, string phoneNumber,
                      string make, string model, int year, string colour,
                      bool engOilChange, bool transOilChange, bool airFilterChange,
                      decimal price)
        {
            serviceCount++;
            identificationNumber = serviceCount;

            this._firstName = firstName ?? string.Empty;
            this._lastName = lastName ?? string.Empty;
            this._phoneNumber = phoneNumber ?? string.Empty;
            this._make = make ?? string.Empty;
            this._model = model ?? string.Empty;
            this._colour = colour ?? string.Empty;
            this._year = year;
            this._engOilChange = engOilChange;
            this._transOilChange = transOilChange;
            this._airFilterChange = airFilterChange;
            this._price = price;
        }

        // Method to get service data as string
        public string GetServiceData()
        {
            var services = new List<string>();
            if (EngOilChange) services.Add("Engine Oil Change");
            if (TransOilChange) services.Add("Transmission Oil Change");
            if (AirFilterChange) services.Add("Air Filter Change");

            return $"ID: {IdentificationNumber}\n" +
                   $"Customer: {firstName} {lastName}\n" +
                   $"Phone: {phoneNumber}\n" +
                   $"Vehicle: {Year} {Make} {Model}\n" +
                   $"Colour: {Colour}\n" +
                   $"Services: {string.Join(", ", services)}\n" +
                   $"Total Cost: {Price:C2}";
        }
    }
}
