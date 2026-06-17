# QuantumEntityBuilderPattern

**QuantumEntityBuilderPattern** is a C# demonstration of clean architecture using the **Abstract Factory** and **Strategy** design patterns, applied to quantum-inspired entities using the famous Schrödinger's Cat thought experiment as a creative example.

*(Note: The repository name retains "BuilderPattern" for historical reasons, but the codebase has been aggressively refactored to prioritize clean code, DRY, and SOLID principles over unnecessary patterns).*

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

This project showcases the implementation of the Abstract Factory and Strategy design patterns in C#, centered around quantum-inspired entities. The application narrates a quantum story, describing entities (Cat, Butterfly) in superposition, alive, or dead states. 

By grouping an entity and its narrative scenario into a single abstract factory, the codebase adheres strictly to the Open/Closed Principle (OCP) and the Don't Repeat Yourself (DRY) principle.

---

## Features

- **Abstract Factory Pattern**: Encapsulates the creation of related object families (a `SchrodingerEntity` and its corresponding `IStoryScenario`) via the `IQuantumExperimentFactory` interface.
- **Strategy Pattern**: The narrative logic is decoupled into `IStoryScenario` strategies (`BoxScenario`, `HandScenario`), allowing dynamic story generation without hardcoding.
- **Clean Architecture**: Eliminates over-engineered builders in favor of simple, intention-revealing factory combinations.
- **Quantum Entities**: All entities inherit from `SchrodingerEntity`, with concrete implementations like `SchrodingerCat` and `SchrodingerButterfly`.
- **Superposition State**: Entities can be in superposition (unknown state), alive, or dead, demonstrating quantum mechanics concepts using a custom `QuantumState<T>` monad.

---

## Project Structure

```text
QuantumEntityBuilderPattern/
├── Entities/
│   ├── SchrodingerCat.cs
│   ├── SchrodingerButterfly.cs
│   └── SchrodingerEntity.cs
├── Factory/
│   ├── IQuantumExperimentFactory.cs
│   ├── CatExperimentFactory.cs
│   └── ButterflyExperimentFactory.cs
├── Story/
│   ├── IStoryScenario.cs
│   ├── BoxScenario.cs
│   ├── HandScenario.cs
│   ├── QuantumStory.cs
│   └── QuantumStoryFactory.cs
├── Quantum/
│   └── QuantumState.cs
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
   var experimentFactories = new List<IQuantumExperimentFactory>
   {
       new CatExperimentFactory(),
       new ButterflyExperimentFactory()
   };

   var story = QuantumStoryFactory.Create(experimentFactories);

   foreach (var line in story.RenderStory())
   {
       Console.WriteLine(line);
   }
   ```

---

## Example Output

```text
--- Quantum Entity Narrative Simulator ---

Suppose you put a cat in a box...
Inside the box, there is a mechanism that may or may not release a poisonous gas.
Until you open the box, you do not know whether the gas has been released, or if the cat is alive or dead.
Cat status: Superposition (Superposition? True)
[ACTION] You open the box to observe the cat's fate.
When you open the box, you see the cat is alive!
Cat status: Alive (Superposition? False)

Suppose you put a butterfly in your hand...
Butterfly status: Superposition (Superposition? True)
[ACTION] You crush your hand.
When you open your hand, the butterfly is dead.
[ACTION] Shame on you.
Butterfly status: Dead (Superposition? False)
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
