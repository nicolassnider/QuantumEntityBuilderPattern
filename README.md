# QuantumEntityBuilderPattern

**QuantumEntityBuilderPattern** is a C# demonstration of the Builder and Factory design patterns, applied to quantum-inspired entities using the famous Schrödinger's Cat thought experiment as a creative example.

![.NET](https://img.shields.io/badge/.NET-8.0-blue)
![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)

---

## Table of Contents

- [Overview](#overview)
- [Features](#features)
- [Project Structure](#project-structure)
- [Installation](#installation)
- [Usage](#usage)
- [Example Output](#example-output)
- [Contributing](#contributing)
- [License](#license)

---

## Overview

This project showcases the implementation of the Builder and Factory design patterns in C#, centered around quantum-inspired entities. The application narrates a quantum story, describing entities (Cat, Dog, Butterfly) in superposition, alive, or dead states.

---

## Features

- **Builder Pattern**: Encapsulates construction logic for quantum entities (`CatBuilder`, `DogBuilder`, `ButterflyBuilder`) via the `ISchrodingerBuilder` interface and a generic base class.
- **Factory Pattern**: The `SchrodingerFactory` class creates entities using any provided builder, promoting extensibility and separation of concerns.
- **Quantum Entities**: All entities inherit from the abstract base class `SchrodingerEntity`, with concrete implementations like `SchrodingerCat`, `SchrodingerDog`, and `SchrodingerButterfly`.
- **Superposition State**: Entities can be in superposition (unknown state), alive, or dead, demonstrating quantum mechanics concepts.
- **Storytelling**: The application narrates a quantum story for each entity, showing their state and scenario.
- **Flexible State Configuration**: Builders support optional state configuration functions for flexible entity creation and testing.

---

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
│   ├── SchrodingerButterfly.cs
│   └── SchrodingerEntity.cs
├── Factory/
│   └── SchrodingerFactory.cs
├── Program.cs
└── QuantumEntityBuilderPattern.csproj
```

---

## Installation

1. **Prerequisites**
   - [.NET 8.0 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/8.0) or later.

2. **Clone the Repository**
   ```bash
   git clone https://github.com/nicolassnider/QuantumEntityBuilderPattern.git
   cd QuantumEntityBuilderPattern
   ```

---

## Usage

1. **Build and Run**
   ```bash
   dotnet run --project QuantumEntityBuilderPattern
   ```

2. **Example Code**
   ```csharp
   var catFactory = new SchrodingerFactory(new CatBuilder());
   var dogFactory = new SchrodingerFactory(new DogBuilder());

   var cat = catFactory.CreateEntity();
   var dog = dogFactory.CreateEntity();

   Console.WriteLine(cat.Describe());
   Console.WriteLine(dog.Describe());
   ```

---

## Example Output

```text
The cat is in a superposition of states.
The dog is in a superposition of states.
```

---

## Contributing

Contributions are welcome! Please open an issue or submit a pull request for any feature requests, bug fixes, or improvements.

1. Fork the repository.
2. Create a new branch: `git checkout -b my-feature`
3. Make your changes and commit them.
4. Push to your fork and submit a pull request.

---

## License

This project is licensed under the MIT License.  
See the [LICENSE](LICENSE) file for details.

---

## Acknowledgments

Inspired by Schrödinger's Cat thought experiment and quantum mechanics principles.
