// класс для ввода данных
internal class RobotCommander : ICommander
{
    Queue<IRobotCommand> robotCommands = new Queue<IRobotCommand>();

    public RobotCommander()
    {
        robotCommands.Enqueue(new DrawRobotCommand());
        robotCommands.Enqueue(new DrawTargetPoint());
        Thread thread = new Thread(RunCommand);
        thread.Start();
    }

    public void Execute(int[] value)
    {
        for (int i = 0; i < value.Length; i++)
        {

            switch (value[i])
            {
                case 1:
                    MoveRobotUpCommand up = new MoveRobotUpCommand(); robotCommands.Enqueue(up); break;
                case 2:
                    MoveRobotDownCommand down = new MoveRobotDownCommand(); robotCommands.Enqueue(down); break;
                case 3:
                    MoveRobotLeftCommand left = new MoveRobotLeftCommand(); robotCommands.Enqueue(left); break;
                case 4:
                    MoveRobotRightCommand right = new MoveRobotRightCommand(); robotCommands.Enqueue(right); break;
            }
            robotCommands.Enqueue(new DrawRobotCommand());
        }


        // массив value перебирается сначала до конца
        // на каждую цифру создается соответствующая команда
        // и передается в очередь выполнения команд
        // здесь какой-нибудь switch, который по номеру создается команду
        // можно чередовать команды движения и рисования
    }

    void RunCommand(object obj)
    {
        while (!Field.GetInstance().CheckRobotEndGame(Robot.GetInstance(), Field.GetInstance()))
        {
            Thread.Sleep(1000);
            if (robotCommands.Count > 0)
            {
                var command = robotCommands.Dequeue();
                command.Execute();
            }
        }
        Console.Title = "Gameover";
    }
}

