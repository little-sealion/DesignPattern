using System;
using DesignPattern;
using DesignPattern.ChainOfResponsibility;
using DesignPattern.ChainOfResponsibility.DataReader;
using DesignPattern.Command;
using DesignPattern.Command.Editor;
using DesignPattern.Command.VideoEditor;
using DesignPattern.Iterator;
using DesignPattern.Mediator;
using DesignPattern.Mediator.SignUpDialogBox;
using DesignPattern.Memento;
// using DesignPattern.Observer;
using DesignPattern.Observer.Stock;
using DesignPattern.State;
using DesignPattern.Strategy;
using DesignPattern.Template;
using History = DesignPattern.Command.VideoEditor.History;
using UndoCommand = DesignPattern.Command.VideoEditor.UndoCommand;
using File = DesignPattern.ChainOfResponsibility.DataReader.File;
using DesignPattern.Visitor;
using HtmlDocument = DesignPattern.Visitor.HtmlDocument;
using DesignPattern.Visitor.WavFile;
using DesignPattern.Composite;
using DesignPattern.Composite.Team;
using DesignPattern.Adapter;
using DesignPattern.Adapter.AvaFilters;
using DesignPattern.Adapter.Email;
using DesignPattern.Adapter.Email.Gmail;
using DesignPattern.Decorator;
using Editor = DesignPattern.Decorator.Artifact.Editor;
using DesignPattern.Facade;
using DesignPattern.Facade.Tweet;
using DesignPattern.Flyweight;
using DesignPattern.Flyweight.SpreadSheet;
using DesignPattern.Bridge;
using DesignPattern.Proxy;
using DesignPattern.Proxy.Exercise;
using DesignPattern.FactoryMethod;
using DesignPattern.AbstractFactory;

// 20.use Builder Pattern

// 19. use Abstract Factory Pattern
{
    // var msiFac = new MsiManufacturer();
    // msiFac.CreateGpu();
    // msiFac.CreateMonitor();
    // var asusFac = new AsusManufacturer();
    // asusFac.CreateGpu();
    // asusFac.CreateMonitor();
}


// 18.use Factory method pattern
{
    // var beefResto = new BeefBurgerRestaurant();
    // var beefBurger = beefResto.CreateBurger();
    // beefBurger.Prepare();
    // var veggieResto = new VeggieBurgerRestaurant();
    // var veggieBurger = veggieResto.CreateBurger();
    // veggieBurger.Prepare();
}



// 17.use Proxy Pattern
{
    // var library = new Library();
    // var fileNames = new List<string> { "a", "b", "c" };
    // foreach (var fileName in fileNames)
    // {
    //     library.Add(new LoggingEbookProxy(fileName));
    // }
    // library.OpenEbook("a");

    // var dbContext = new DbContext();
    // var product = dbContext.GetProduct(1);
    // product.SetName("update name");
    // dbContext.SaveChanges();

    // product.SetName("Another name");
    // dbContext.SaveChanges();
}


// 16.use Bridge Pattern
{
    // var remoteControl = new RemoteControl(new SonyTV());
    // remoteControl.TurnOn();
    // remoteControl.TurnOff();
    // var advancedRemoteControl = new AdvancedRemoteControl(new SonyTV());
    // advancedRemoteControl.SetChannel(5);
    // var anotherRemoteControl = new RemoteControl(new SamsungTV());
    // anotherRemoteControl.TurnOn(); 
    // anotherRemoteControl.TurnOff();
    // var anotherAdvancedRemoteControl = new AdvancedRemoteControl(new SamsungTV());
    // anotherAdvancedRemoteControl.SetChannel(5);
}



// 15.use Flyweight pattern(separate the data we need to share in another class and 
// use a factory to cache those reusable objects)
{
    // var service = new PointService(new PointIconFactory());
    // foreach (var point in service.GetPoints())
    // {
    //     point.Draw();
    // }
    // var fontFactory = new FontFactory();
    // var sheet = new SpreadSheet(fontFactory);
    // sheet.SetContent(0, 0, "Hello");
    // sheet.SetContent(1, 0, "World");
    // sheet.SetFontFamily(0, 0, FontType.TITLE);
    // sheet.Render();
}

// 14.use facade pattern
{
    // var service = new NotificationService();
    // service.Send("Hello World", "target");
    // var service = new TwitterService();
    // service.GetRecentTweets();
}

// 13. use decorator pattern
{
    // void StoreCreditCrad(IStream stream)
    // {
    //     stream.Write("1234-1234-1234-1234");
    // }

    // var cloudStream = new CloudStream();
    // StoreCreditCrad(cloudStream);
    // var encryptedStream = new EncryptedCloudStream(cloudStream);
    // StoreCreditCrad(encryptedStream);
    // var compressedStream = new CompressedCloudStream(encryptedStream);
    // StoreCreditCrad(compressedStream);

    // Editor.OpenProject();
}


// 12. use adapter pattern
{
    // var imageView = new ImageView(new Image());
    // imageView.Apply(new VividFilter());
    // imageView.Apply(new CaramelFilter(new Caramel() ));

    // var emailClient = new EmailClient();
    // emailClient.AddProvider(new GmailAdapter());
    // emailClient.DownloadEmails();
}

// 11.use composite pattern
{
    // var group1 = new Group();
    // group1.Add(new Shape());
    // group1.Add(new Shape());
    // var group2 = new Group();
    // group2.Add(new Shape());
    // group2.Add(new Shape());
    // var group = new Group();
    // group.Add(group1);
    // group.Add(group2);
    // group.Render();
    // group.Move();

    // var subTeam1 = new Team();
    // subTeam1.Add(new Truck());
    // subTeam1.Add(new Human());
    // subTeam1.Add(new Human());
    // var subTeam2 = new Team();
    // subTeam2.Add(new Truck());
    // subTeam2.Add(new Human());
    // subTeam2.Add(new Human());
    // var team = new Team();
    // team.Add(subTeam1);
    // team.Add(subTeam2);
    // team.Deploy();
}

// 10. use Visitor Pattern
{
    // var document = new HtmlDocument();
    // document.AddNode(new AnchorNode());
    // document.AddNode(new HeadingNode());
    // document.Execute(new HighlightOperation());
    // document.Execute(new PlainTextOperation());


    // var wavFile = new WavFile();
    // wavFile.AddSegment(new FactSegment());
    // wavFile.AddSegment(new FormatSegment());
    // wavFile.Execute(new ReduceNoiseOperation());
    // wavFile.Execute(new NormalizeOperation());
    // wavFile.Execute(new AddReverbOperation());
}


// 9. use ChainOfResponsibility Pattern
{
    //  authenticator  -> compressor -> encryptor
    // var encryptor = new Encryptor(null);
    // var compressor = new Compressor(encryptor);
    // // var logger = new Logger(compressor);
    // var authenticator = new Authenticator(compressor);
    // var server = new WebServer(authenticator);
    // server.Handle(new HttpRequest("admin", "1234"));

    // var dataReader = DataReaderFactory.GetDataReaderChain();
    // dataReader.Read(new File("xls", "123,13,ads,542"));
    // dataReader.Read(new File("qbw", "123,13,ads,542"));
    // dataReader.Read(new File("numbers", "123,13,ads,542"));
    // try
    // {
    //     dataReader.Read(new File("xlsx", "123,13,ads,542"));

    // }
    // catch (System.Exception e)
    // {

    //     System.Console.WriteLine(e.Message);
    // }

}


// 8. use Mediator Pattern
{
    // var dialog = new ArticlesDialogBox();
    // dialog.SimulateUserInteraction();

    // var signUpDialogBox = new SignUpDialogBox();
    // signUpDialogBox.SimulateUserInteraction();
}



// 7. use Observer Pattern
{
    // var dataSource = new DataSource();
    // var sheet1 = new SpreadSheet(dataSource);
    // var sheet2 = new SpreadSheet(dataSource);
    // var chart = new Chart(dataSource);
    // dataSource.AddObservers(new List<IObserver> { sheet1, sheet2, chart });
    // dataSource.SetValue(200);

    // var stock1 = new Stock("300123", 1.43f);
    // var stock2 = new Stock("300111", 11.23f);
    // var stockListView = new StockListView();
    // stockListView.AddStock(stock1);
    // stockListView.AddStock(stock2);
    // var statusBar = new StatusBar();
    // statusBar.AddStock(stock1);
    // stock1.SetPrice(1.40f);
    // stock2.SetPrice(11.40f);
}




//6. use Command Pattern
{
    // var service = new CustomerService();
    // var command = new AddCustomerCommand(service);
    // var button = new Button(command);
    // button.Click();

    // var composite = new CompositeCommand();
    // composite.Add(new ResizeCommand());
    // composite.Add(new BlackWhiteCommand());
    // composite.Execute();

    // var document = new HtmlDocument();
    // document.Content = "hello world";
    // var history = new History();
    // var boldCommand = new BoldCommand(document, history);
    // boldCommand.Execute();
    // System.Console.WriteLine(document.Content);
    // var undoCommand = new UndoCommand(history);
    // undoCommand.Execute();
    // System.Console.WriteLine(document.Content);

    // var video = new Video();
    // var history = new History();
    // var setContrastCommand = new SetContrastCommand(3.5f, video, history);
    // setContrastCommand.Execute();
    // System.Console.WriteLine(video.ToString());
    // var undoCommand = new UndoCommand(history);
    // undoCommand.Execute();
    // System.Console.WriteLine(video.ToString());
    // var setTextCommand = new SetTextCommand("hello", video, history);
    // setTextCommand.Execute();
    // System.Console.WriteLine(video.ToString());
    // undoCommand.Execute();
    // System.Console.WriteLine(video.ToString());
}



// 5.use Template Pattern
{
    // var generateReportTask = new GenerateReportTask();
    // generateReportTask.Execute();

    // var transferMoneyTask = new TransferMoneyTask();
    // transferMoneyTask.Execute();

    // var bumpWindow = new BumpWindow();
    // bumpWindow.Close();

    // var bounceWindow = new BounceWindow();
    // bounceWindow.Close();
}


// 4. use Strategy Pattern

{
    // var imageStorage = new ImageStorage();
    // imageStorage.Store("image 1", new PNGCompressor(), new HighContrastFilter());
    // imageStorage.Store("image 2", new JPGCompressor(), new BWFilter());

    // var chatClient = new ChatClient();
    // chatClient.Send("a top secret file", new AESEncryptor());
    // chatClient.Send("another top secret file", new DESEncryptor());

}

// 3. use Iterator Pattern
{
    // var browseHistory = new BrowseHistory<string>();
    // browseHistory.Push("a");
    // browseHistory.Push("b");
    // browseHistory.Push("c");
    // var iterator = browseHistory.CreateIterator();
    // while (iterator.HasNext())
    // {
    //     System.Console.WriteLine(iterator.Current());
    //     iterator.Next();
    // }
    // var productCollection = new ProductCollection();
    // productCollection.Add(new Product(1, "a"));
    // productCollection.Add(new Product(2, "b"));
    // productCollection.Add(new Product(3, "c"));

    // var iterator = productCollection.CreateIterator();
    // while (iterator.HasNext())
    // {
    //     var currentProduct = iterator.Current();
    //     System.Console.WriteLine(currentProduct.ToString());
    //     iterator.Next();
    // }
}


// 2. use State pattern
// {
//     var canvas = new Canvas();
//     canvas.CurrentTool = new Brush();
//     canvas.MouseDown();
//     canvas.MouseUp();
// var directionService = new DirectionService();
// directionService.CurrentTravelMode = new Bicycling();
// directionService.GetDirection();
// directionService.GetETA();
// }



// 1. use Memento pattern
// {
//     var editor = new Editor();
//     var history = new History();
//     var doc1 = new Document { Content = "a", FontName = "a1", FontSize = "10" };
//     editor.SetContent(doc1);
//     history.Push(editor.CreateState());
//     var doc2 = new Document { Content = "b", FontName = "b1", FontSize = "11" };
//     editor.SetContent(doc2);
//     history.Push(editor.CreateState());

//     var doc3 = new Document { Content = "c", FontName = "c1", FontSize = "11" };
//     editor.SetContent(doc3);
//     editor.Restore(history.Pop());
//     editor.Restore(history.Pop());

//     System.Console.WriteLine(editor.Document.ToString());
// }


// DrawUIControl(new TextBox());
// DrawUIControl(new CheckBox());

// void DrawUIControl(UIControl ui)
// {
//     ui.Draw();
// }


// await ThreeLineRiddle.Riddle();

