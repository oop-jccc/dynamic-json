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

## Getting Started

1. Clone the repository
2. Start with the default branch (`01-todo-starter-code`)
3. Follow the instructions in `assignment.md`
4. Test your implementation using the Swagger UI

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