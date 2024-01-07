using System.Diagnostics;
using System.Drawing;

Console.WriteLine("enter");
Console.ReadLine();

MainCommander mainCommander = new MainCommander();
Controller controller = new Controller(mainCommander);
controller.StartListner();