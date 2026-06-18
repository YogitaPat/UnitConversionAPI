# Unit Conversion API

## Overview

This project is an ASP.NET Core Web API that converts values between different units of measurement.

Supported conversion categories:

* Length
* Weight/Mass
* Temperature
* Volume

The API accepts a value, source unit, destination unit, and conversion category, then returns the converted result.

---

## Technologies Used

* ASP.NET Core (.NET 10)
* Swagger / OpenAPI
* Dependency Injection
* C#
* xUnit (Unit Testing)

---

## Features

* Convert values between different units
* Support for Length, Weight, Temperature, and Volume conversions
* Input validation and error handling
* Swagger UI for API testing and documentation
* Unit tests for core conversion functionality
* Extensible design for adding new conversion categories and units

---

## Project Structure

* Controllers – API endpoints
* Services – Business logic orchestration
* Converters – Category-specific conversion logic
* Models – Request and response models
* Tests – Unit tests for conversion functionality

---

## Prerequisites

Before running the application, ensure the following is installed:

* .NET 10 SDK

---

## Running the Application

### Clone the Repository

git clone <https://github.com/YogitaPat/UnitConversionAPI>

### Navigate to the Project

cd UnitConversionAPI

### Restore Dependencies

dotnet restore

### Build the Project

dotnet build

### Run the Application

dotnet run

### Access Swagger UI


http://localhost:<Xxxx>/swagger/index.html
---

## Running Tests

To execute all unit tests:

dotnet test

Current test coverage includes:

* Meter to Feet conversion
* Kilogram to Pound conversion
* Celsius to Fahrenheit conversion


## Sample Run Test output
PS C:\Users\User\UnitConversionAPI> dotnet test
Restore complete (1.2s)
  UnitConversionAPI net10.0 succeeded (0.9s) → UnitConversionAPI\bin\Debug\net10.0\UnitConversionAPI.dll
  UnitConversionAPI.Tests net10.0 succeeded (3.9s) → UnitConversionAPI.Tests\bin\Debug\net10.0\UnitConversionAPI.Tests.dll     
[xUnit.net 00:00:00.00] xUnit.net VSTest Adapter v3.1.4+50e68bbb8b (64-bit .NET 10.0.9)
[xUnit.net 00:00:01.67]   Discovering: UnitConversionAPI.Tests
[xUnit.net 00:00:01.78]   Discovered:  UnitConversionAPI.Tests
[xUnit.net 00:00:01.82]   Starting:    UnitConversionAPI.Tests
[xUnit.net 00:00:02.65]   Finished:    UnitConversionAPI.Tests
  UnitConversionAPI.Tests test net10.0 succeeded (8.8s)

Test summary: total: 3, failed: 0,  succeeded: 3, skipped: 0, duration: 8.7s
Build succeeded in 15.5s
---

## Sample Request

POST /api/conversion

```json
{
  "category": "length",
  "fromUnit": "meter",
  "toUnit": "feet",
  "value": 10
}
```

---

## Sample Response

```json
{
  "category": "length",
  "originalValue": 10,
  "fromUnit": "meter",
  "toUnit": "feet",
  "convertedValue": 32.8084
}
```

---

## Design Decisions

* Conversion logic is separated into dedicated converter classes.
* Dependency Injection is used for service registration.
* Unit definitions and conversion factors are currently hardcoded to satisfy the assignment requirements.
* Unit tests have been added to validate core conversion functionality.
* The solution is designed to be extensible and can support additional conversion categories and units with minimal changes.
* Conversion factors can be moved to a database or configuration source in the future to support hundreds of units.

---

## Future Enhancements

* Database-backed unit configuration
* Additional conversion categories
* Global exception handling middleware
* API versioning
* Authentication and authorization
* Logging and monitoring

---

## Assumptions

* Unit definitions and conversion factors are hardcoded as per the current requirements.
* The application focuses on demonstrating clean architecture, maintainability, and extensibility.
* The API is intended to be run locally for development and evaluation purposes.
