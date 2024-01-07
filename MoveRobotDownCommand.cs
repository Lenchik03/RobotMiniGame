// класс для ввода данных
internal class MoveRobotDownCommand : IRobotCommand
{
    public void Execute()
    {// проверяем, может ли робот двигаться вниз, если да, меняем ему координаты
        Robot robot = Robot.GetInstance();
        Field field = Field.GetInstance();
        if (robot.Y == 5)
            return;
        int y = robot.Y + 1;
        if (field.Cells[robot.X, y] != 2)
        {
            field.DrawCleanField(robot.X, robot.Y);
            robot.Y = y;
        }
    }
}