// класс для ввода данных
internal class Controller
{
    private MainCommander mainCommander;

    public Controller(MainCommander mainCommander)
    {
        this.mainCommander = mainCommander;
        mainCommander.SetInterpretator(new FieldCommander());
    }

    // цикл по запросу команды
    internal void StartListner()
    {
        string firstCommands = "11111121121111211111111134";// Console.ReadLine();
        int[] value = new int[25];
        for(int i = 0; i < 25; i++)
        {
            value[i] = int.Parse(firstCommands[i].ToString());
        }
        mainCommander.Execute(value);
        mainCommander.SetInterpretator(new RobotCommander());

        Robot robot = Robot.GetInstance();
        Field field = Field.GetInstance();

        while ((robot.X != field.X) || (robot.Y != field.Y))
        {
            mainCommander.Execute(Console.ReadLine().Select(s=>int.Parse(s.ToString())).ToArray());
        }



        // первый запрос на 25 символов (рисование поля) передается mainCommander в метод Execute
        // смена интерпретатора у mainCommander на RobotCommander
        // остальные запросы передаются туда же (цикл, пока робот не достигнет конечной точки)
    }
}
