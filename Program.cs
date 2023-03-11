// See https://aka.ms/new-console-template for more information
using System;
using DesignPattern;
using DesignPattern.Command;
using DesignPattern.Command.Editor;
using DesignPattern.Command.VideoEditor;
using DesignPattern.Iterator;
using DesignPattern.Memento;
using DesignPattern.Observer;
using DesignPattern.State;
using DesignPattern.Strategy;
using DesignPattern.Template;
using History = DesignPattern.Command.VideoEditor.History;
using UndoCommand = DesignPattern.Command.VideoEditor.UndoCommand;

// 7. use Observer Pattern
{
    var dataSource = new DataSource();
    var sheet1 = new SpreadSheet(dataSource);
    var sheet2 = new SpreadSheet(dataSource);
    var chart = new Chart(dataSource);
    dataSource.AddObservers(new List<IObserver> { sheet1, sheet2, chart });
    dataSource.SetValue(200);
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

