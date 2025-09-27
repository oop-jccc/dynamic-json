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

## Assignment: Implementing a Todo Item Processor

In this exercise, the aim is to enhance a processing system by introducing a functionality to manage Todo items. By adding a `TodoItem` record and a `TodoItemProcessor` class, you will enable the program to mark Todo items as completed as part of the processing. This task encourages the application of SOLID design principles, notably the Open/Closed Principle, alongside the Strategy Design Pattern.

### Understanding the UML Diagram

Below is the UML diagram representing the structure of the codebase for this assignment. In this diagram:
- **Green**: Indicates the new classes and records you need to add.
- **Yellow**: Indicates the class that requires updating with new dependency registrations.

![UML Diagram](uml.png)

### Instructions

1. **Create a `TodoItem` Record:**
   - Navigate to the `Models` folder and create a new file named `TodoItem.cs`.
   - Define a `public` record named `TodoItem` with the following read-only properties (using the `init` accessor):
     - `string Title`
     - `bool IsCompleted`

2. **Create a `TodoItemProcessor` Class:**
   - Navigate to the `JsonProcessors` folder and create a new file named `TodoItemProcessor.cs`.
   - Define a `public` class named `TodoItemProcessor` that implements the `IJsonProcessor` interface.
   - Implement the `CanProcess` method to check if the provided `JObject` contains the necessary keys for a `TodoItem`.
   - Implement the `Process` method to deserialize the `JObject` to a `TodoItem` object. Utilize the `with` operator to create a safe, non-destructive copy of the `TodoItem` with the `IsCompleted` property set to `true`.

3. **Update Dependency Injection:**
   - Navigate to the `Program` class.
   - In the `Main` method, locate the section where dependency injection is set up.
   - Add a new line to register the `TodoItemProcessor` class with the dependency injection collection.

### Running the Application

1. Run the application. The Swagger UI will pop up.
2. To test the `TodoItemProcessor`, use the following JSON string in the Swagger UI:
   ```json
   "{\"Title\":\"Buy Milk\",\"IsCompleted\":false}"
   ```
   This will simulate processing a Todo item and should return a Todo item with `IsCompleted` set to `true`.

### Important Notes

- Your implementation should adhere to the Open/Closed Principle; no existing code should be modified except for the dependency injection setup in the `Program` class.
- This design follows the Strategy Design Pattern by enabling the program to use different processors interchangeably through the `IJsonProcessor` interface.
- Ensure your code is clean, and follows the coding standards discussed in class. The `TodoItem` record's properties should remain read-only, demonstrating the safe handling of data by utilizing the `with` operator in the `TodoItemProcessor` class.

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