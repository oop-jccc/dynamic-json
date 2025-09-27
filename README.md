# Dynamic JSON Processing - Educational Repository

This repository demonstrates the Strategy Design Pattern and SOLID principles through a JSON processing system built with ASP.NET Core.

## Branch Structure

This repository follows a numbered branch structure that reflects the educational progression:

### 01-todo-starter-code (Default Branch)
- **Purpose**: Starting point for students
- **Content**: Base infrastructure with User and Product processors
- **Missing**: TodoItem model and processor implementation
- **Student Task**: Implement the missing TodoItem functionality

### 02-todo-solution
- **Purpose**: Complete solution for the Todo assignment
- **Content**: Full TodoItem implementation demonstrating proper use of records and the `with` operator
- **Learning Focus**: Strategy pattern, Open/Closed principle, immutable data structures

### 03-template-method-pattern
- **Purpose**: Advanced implementation showing Template Method pattern
- **Content**: Refactored processors using BaseJsonProcessor abstract class
- **Learning Focus**: Template Method pattern, inheritance, advanced OOP design

### 04-exam-thumbnail-exercise
- **Purpose**: Additional exercise for assessment
- **Content**: Thumbnail model and processor implementation
- **Learning Focus**: Pattern application with different data types

## Solution Branch - TodoItem Implementation Complete

**⚠️ This is the solution branch containing the complete implementation of the TodoItem assignment.**

This branch contains the fully implemented solution for the TodoItem processor assignment. Students should work on the `01-todo-starter-code` branch and only reference this branch to check their implementation or understand the expected solution.

### What's Implemented

This branch includes:
- ✅ **TodoItem Record**: Complete `TodoItem.cs` in the Models folder with `Title` and `IsCompleted` properties
- ✅ **TodoItemProcessor Class**: Complete `TodoItemProcessor.cs` implementing the `IJsonProcessor` interface
- ✅ **Dependency Injection**: Proper registration of `TodoItemProcessor` in the `Program.cs` file
- ✅ **Strategy Pattern**: Demonstrates the Strategy Design Pattern with interchangeable processors
- ✅ **SOLID Principles**: Implementation follows Open/Closed Principle

### Key Implementation Details

- **Record Usage**: The `TodoItem` uses C# records with `init` accessors for immutability
- **`with` Operator**: The processor uses the `with` operator for non-destructive copying
- **Interface Implementation**: Proper implementation of `CanProcess` and `Process` methods
- **JSON Processing**: Correct handling of JObject deserialization and property checking

### Testing the Solution

1. Run the application to launch Swagger UI
2. Test with the following JSON:
   ```json
   "{\"Title\":\"Buy Milk\",\"IsCompleted\":false}"
   ```
3. Verify the response shows `IsCompleted` set to `true`

### Learning Outcomes Demonstrated

- Strategy Design Pattern implementation
- Open/Closed Principle adherence
- Immutable data structures with C# records
- Dependency injection in .NET Core
- JSON processing with Newtonsoft.Json

## Technologies Used

- ASP.NET Core 6.0
- Newtonsoft.Json
- Swagger/OpenAPI
- C# Records and Pattern Matching

## Learning Objectives

- Strategy Design Pattern implementation
- SOLID principles (especially Open/Closed)
- Dependency Injection in .NET
- Immutable data structures with C# records
- Web API development with ASP.NET Core