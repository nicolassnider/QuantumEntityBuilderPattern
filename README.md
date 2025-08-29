# QuantumEntityBuilderPattern

QuantumEntityBuilderPattern is a C# demonstration of the Builder and Factory design patterns applied to quantum-inspired entities, specifically using the famous Schrödinger's Cat thought experiment as a metaphor. The project provides a flexible way to construct entities (like cats, dogs, and butterflies) that can exist in a superposition of states (alive, dead, or both), and showcases how to decouple entity creation from their representation.

## Features

- **Builder Pattern**: Construction logic for different quantum entities (`CatBuilder`, `DogBuilder`, `ButterflyBuilder`) is encapsulated via the `ISchrodingerBuilder` interface and a generic base class `SchrodingerBuilderBase<T>`.
- **Factory Pattern**: The `SchrodingerFactory` class creates entities using any provided builder.
- **Quantum Entities**: All entities inherit from the abstract base class `SchrodingerEntity`, with concrete implementations (`SchrodingerCat`, `SchrodingerDog`, `SchrodingerButterfly`) each providing a `Describe` method for their quantum state.
- **Superposition State**: Entities can be in a superposition (unknown state), alive, or dead.
- **Storytelling**: The application narrates a quantum story, describing the scenario for each entity.
- **Flexible State Configuration**: Builders support an optional state configuration function for functional and flexible entity creation.

## Project Structure

```text
QuantumEntityBuilderPattern/
├── Builders/
│   ├── CatBuilder.cs
│   ├── DogBuilder.cs
│   └── ISchrodingerBuilder.cs
├── Entities/
│   ├── SchrodingerCat.cs
│   ├── SchrodingerDog.cs
│   └── SchrodingerEntity.cs
├── Factory/
│   └── SchrodingerFactory.cs
├── Program.cs
└── QuantumEntityBuilderPattern.csproj
```

## Usage

1. **Build and Run**
    - Requires [.NET 8.0 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/8.0)
    - Open a terminal in the project root and run:
    
    ```powershell
    dotnet run --project QuantumEntityBuilderPattern
    ```

2. **Output**
    - The program will create a Schrödinger Cat and Dog, both in a superposition state, and print their descriptions:

    ```text
    The cat is in a superposition of states.
    The dog is in a superposition of states.
    ```

## Example Code

```csharp
var catFactory = new SchrodingerFactory(new CatBuilder());
var dogFactory = new SchrodingerFactory(new DogBuilder());

var cat = catFactory.CreateEntity();
var dog = dogFactory.CreateEntity();

Console.WriteLine(cat.Describe());
Console.WriteLine(dog.Describe());
```

## License

MIT License
QuantumEntityBuilderPattern
QuantumEntityBuilderPattern is a C# demonstration of the Builder and Factory design patterns applied to quantum-inspired entities, specifically using the famous Schrödinger's Cat thought experiment as a metaphor. The project provides a flexible way to construct entities (like cats and dogs) that can exist in a superposition of states (alive, dead, or both), and showcases how to decouple entity creation from their representation.
