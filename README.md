# Circle Class and InvalidRadiusException

This repository contains a C# implementation of a `Circle` class and an `InvalidRadiusException` class. The `Circle` class has an attribute `Radius` of type `double` and methods to set the radius and display the circle object information. The `InvalidRadiusException` class has constructors to handle exceptions when the radius is not valid.

## Circle Class

The `Circle` class has the following attributes and methods:

- `Radius`: A private attribute of type `double` representing the radius of the circle.
- `SetRadius(double radius)`: A method that checks if the radius is greater than zero. If the radius is greater than zero, it sets it. If the radius is equal to or less than zero, the method throws the `InvalidRadiusException`.
- `ToString()`: A method that displays all circle object information (radius).

## InvalidRadiusException Class

The `InvalidRadiusException` class has the following constructors:

- `InvalidRadiusException()`: A no argument constructor that prints a message when the radius is greater than zero.
- `InvalidRadiusException(double radius)`: A second constructor that accepts the value of the radius and prints it along with a message that it is not valid.

## Main Class

The `Main` class creates three objects to test the code:

- `Circle circle1`: An object with a positive radius.
- `Circle circle2`: An object with a negative radius.
- `Circle circle3`: An object with a radius of zero.

The `Main` method catches the `InvalidRadiusException` exceptions and prints the error messages.

To run the code, you can use a C# IDE like Visual Studio or Visual Studio Code. Simply create a new console application project, add the provided code to the project, and run the application.

Please note that this code is provided as an example and may not be suitable for all use cases. You may need to modify the code or add additional functionality based on your specific requirements.
