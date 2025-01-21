using BehavioursPatterns.ChainOfResponsibility;
using BehavioursPatterns.Command;
using BehavioursPatterns.Interpreter;
using BehavioursPatterns.Iterator;
using BehavioursPatterns.Mediator;
using BehavioursPatterns.Memento;
using BehavioursPatterns.Observer;
using BehavioursPatterns.State;
using BehavioursPatterns.Strategy;
using BehavioursPatterns.TemplateMethod;
using BehavioursPatterns.Visitor;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("# CHAIN OF RESPONSIBILITY");
        var handler = new InvoiceHandler();
        handler.SetNext(new ReceiptHandler()).SetNext(new BillHandler());
        handler.Handle("Invoice");
        handler.Handle("Unknown");

        Console.WriteLine("# COMMAND");
        var editor = new TextEditor();
        var commandManager = new CommandManager();
        commandManager.ExecuteCommand(new WriteTextCommand(editor, "Hello, "));
        commandManager.ExecuteCommand(new WriteTextCommand(editor, "world!"));
        commandManager.Undo();
        commandManager.Undo();
        commandManager.Redo();

        Console.WriteLine("\n# INTERPRETER");
        var expression = new AddExpression(
            new NumberExpression(5),
            new SubtractExpression(new NumberExpression(10), new NumberExpression(3))
        );
        Console.WriteLine(expression.Interpret());

        Console.WriteLine("\n# ITERATOR");
        var playlist = new Playlist();
        playlist.Add("Song 1");
        playlist.Add("Song 2");
        playlist.Add("Song 3");
        foreach (var song in playlist)
        {
            Console.WriteLine(song);
        }

        Console.WriteLine("\n# MEDIATOR");
        var mediator = new ChatMediator();
        var user1 = new User("Alice", mediator);
        var user2 = new User("Bob", mediator);
        user1.SendMessage("Hello, Bob!");
        user2.SendMessage("Hi, Alice!");

        Console.WriteLine("\n# MEMENTO");
        var player = new Player();
        player.Position = 5;
        player.Health = 100;
        var caretaker = new Caretaker();
        caretaker.Save(player.SaveState());
        player.Position = 10;
        caretaker.Restore(player);
        Console.WriteLine(player.Position);

        Console.WriteLine("\n# OBSERVER");
        var order = new Order();
        order.Attach(new EmailNotifier());
        order.Attach(new SmsNotifier());
        order.UpdateStatus("Shipped");

        Console.WriteLine("\n# STATE");
        var vendingMachine = new VendingMachine();
        vendingMachine.InsertCoin();
        vendingMachine.SelectProduct();
        vendingMachine.DispenseProduct();

        Console.WriteLine("\n# STRATEGY");
        var calculator = new ShippingCalculator(new EconomyShipping());
        Console.WriteLine(calculator.Calculate(100));
        calculator.SetStrategy(new ExpressShipping());
        Console.WriteLine(calculator.Calculate(100));

        Console.WriteLine("\n# TEMPLATE METHOD");
        var pdfReport = new PdfReportGenerator();
        pdfReport.GenerateReport();
        var excelReport = new ExcelReportGenerator();
        excelReport.GenerateReport();

        Console.WriteLine("\n# VISITOR");
        var visitor = new ValidationVisitor();
        var elementA = new ElementA();
        elementA.Accept(visitor);
    }
}