Usage of **Factory Design Pattern** and **Dependency Inversion Principle** to build a simple calculator with ASP.NET.

start: `dotnet run`
execute: `curl -G -d 'firstNumber=12' -d 'secondNumber=2' -d 'operator=add' http://localhost:3000`

The modules of project relies on abstractions instead of implementations, following the Dependency Inversion Principle (D of SOLID).

The implementations are only created by the factory module.