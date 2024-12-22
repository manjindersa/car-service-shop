# Car Service Shop Management System

A Windows Forms application for managing car service records and customer information.

## Author
- **Name:** Manjinder Singh
- **GitHub:** [@manjindersa](https://github.com/manjindersa)

## Description

This Car Service Shop Management System is a desktop application built using Windows Forms in C#. It provides a user-friendly interface for managing automotive service records, including customer information, vehicle details, and service operations.

## Features

### Customer Information Management
- Record customer first and last names
- Validate and store phone numbers
- Input validation with detailed error messages

### Vehicle Information
- Comprehensive list of car manufacturers
- Vehicle model tracking
- Year selection (limited to last 20 years)
- Extensive color validation system
- Complete vehicle details storage

### Service Operations
- Multiple service types:
  - Engine Oil Change ($60)
  - Transmission Oil Change ($120)
  - Air Filter Change ($40.50)
- Automatic cost calculation including 13% tax
- Service history tracking

### User Interface Features
- Intuitive form layout
- Real-time cost calculations
- Informative tooltips on all fields
- Comprehensive input validation
- Full CRUD operations:
  - Add new service records
  - Update existing records
  - Remove individual records
  - Clear all records
- ListView display of all service records

## Technical Details

### Prerequisites
- .NET Framework (Latest version recommended)
- Windows OS
- Visual Studio (for development)

### Key Components
- **Form1.cs**: Main application interface and logic
- **Service.cs**: Service class implementation for data management

### Data Validation
- Phone number format validation
- Required field checking
- Color name validation
- Service selection requirement

### Keyboard Shortcuts
- Alt+A: Add new service record
- Alt+N: Clear form
- Alt+U: Update selected record
- Alt+R: Remove selected record
- Alt+M: Remove all records
- Alt+E: Exit application

## Installation

1. Clone the repository:
   ```bash
   git clone https://github.com/manjindersa/car-service-shop.git
   ```
2. Open the solution in Visual Studio
3. Build and run the application

## Usage

1. Enter customer information (name, phone)
2. Select vehicle details (make, model, year, color)
3. Choose required services
4. View automatically calculated total (including tax)
5. Add, update, or remove service records as needed

## Contributing

1. Fork the repository
2. Create your feature branch (`git checkout -b feature/AmazingFeature`)
3. Commit your changes (`git commit -m 'Add some AmazingFeature'`)
4. Push to the branch (`git push origin feature/AmazingFeature`)
5. Open a Pull Request

## License

This project is available for use under standard open-source license terms.

## Acknowledgments

- Built using Windows Forms technology
- Implements modern C# practices
- Uses object-oriented programming principles
