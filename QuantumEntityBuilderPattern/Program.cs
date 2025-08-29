using QuantumEntityBuilderPattern.Builders;
using QuantumEntityBuilderPattern.Factory;
using QuantumEntityBuilderPattern.Story;

var catFactory = new SchrodingerFactory(new CatBuilder());
var butterflyFactory = new SchrodingerFactory(new ButterflyBuilder());

var cat = catFactory.CreateEntity();
var butterfly = butterflyFactory.CreateEntity();

var story = QuantumStoryFactory.Create(cat, butterfly);

foreach (var line in story.RenderStory())
    Console.WriteLine(line);

Console.ReadKey();
