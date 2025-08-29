using QuantumEntityBuilderPattern.Builders;
using QuantumEntityBuilderPattern.Factory;

var catFactory = new SchrodingerFactory(new CatBuilder());
var dogFactory = new SchrodingerFactory(new DogBuilder());

var cat = catFactory.CreateEntity();
var dog = dogFactory.CreateEntity();

Console.WriteLine(cat.Describe());
Console.WriteLine(dog.Describe());