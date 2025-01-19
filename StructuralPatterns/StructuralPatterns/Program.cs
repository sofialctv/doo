using StructuralPatterns.PadraoAdapter;
using StructuralPatterns.PadraoBridge;
using StructuralPatterns.PadraoComposite;
using StructuralPatterns.PadraoDecorator;
using StructuralPatterns.PadraoFacade;
using StructuralPatterns.PadraoFlyweight;
using StructuralPatterns.PadraoProxy;

namespace StructuralPatterns
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n# PADRÃO ADAPTER\n");
            var sensors = new List<ITemperatureSensor>
            {
                new SensorAAdapter(),
                new SensorBAdapter(),
                new SensorCAdapter()
            };

            foreach (var sensor in sensors)
            {
                Console.WriteLine($"Temperatura lida: {sensor.ReadTemperature()} °C");
            }

            Console.WriteLine("\n# PADRÃO BRIGDE\n");
            var redCircle = new Circle(new RedColor());
            var blueSquare = new Square(new BlueColor());

            redCircle.Draw();
            blueSquare.Draw();

            Console.WriteLine("\n# PADRÃO COMPOSITE\n");
            var mainMenu = new Menu("Menu Principal");
            var drinksMenu = new Menu("Bebidas");
            var foodMenu = new Menu("Comidas");

            drinksMenu.Add(new MenuItem("Coca-Cola"));
            drinksMenu.Add(new MenuItem("Água"));

            foodMenu.Add(new MenuItem("Hamburguer"));
            foodMenu.Add(new MenuItem("Pizza"));

            mainMenu.Add(drinksMenu);
            mainMenu.Add(foodMenu);

            mainMenu.Display();

            Console.WriteLine("\n# PADRÃO DECORATOR\n");
            INotification notification = new BaseNotification();
            notification = new EmailDecorator(notification);
            notification = new SMSDecorator(notification);
            notification = new PushDecorator(notification);

            notification.Send("Nova mensagem");

            Console.WriteLine("\n# PADRÃO FACADE\n");
            var homeTheater = new HomeTheaterFacade(new DvdPlayer(), new Projector(), new Lights(), new SoundSystem());
            homeTheater.PlayMovie("Inception");
            homeTheater.EndMovie();

            Console.WriteLine("\n# PADRÃO FLYWEIGHT\n");
            var treeType = TreeFactory.GetTreeType("Pine", "Green");

            var trees = new List<Tree>
            {
                new Tree(10, 20, treeType),
                new Tree(30, 40, treeType),
                new Tree(50, 60, treeType)
            };

            foreach (var tree in trees)
            {
                tree.Display();
            }

            Console.WriteLine("\n# PADRÃO PROXY\n");
            IImage image1 = new ProxyImage("imagem1.png");
            IImage image2 = new ProxyImage("imagem2.png");

            image1.Display(); // Carrega a imagem e a exibe
            image1.Display(); // Exibe diretamente sem carregar
            image2.Display(); // Carrega a imagem e a exibe
        }
    }
}
