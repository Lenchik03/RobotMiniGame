// класс для ввода данных
internal class MoveRobotUpCommand : IRobotCommand
{
    public void Execute()
    {// проверяем, может ли робот двигаться вверх, если да, меняем ему координаты
        Robot robot = Robot.GetInstance();
        Field field = Field.GetInstance();
        if (robot.Y == 0)
            return;

        int y = robot.Y-1;
        if (field.Cells[robot.X, y] != 2)
        {
            field.DrawCleanField(robot.X, robot.Y);
            robot.Y = y;
        }
    }
}