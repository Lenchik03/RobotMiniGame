// класс для ввода данных
internal class MoveRobotRightCommand : IRobotCommand
{
    public void Execute()
    {// проверяем, может ли робот двигаться враво, если да, меняем ему координаты
        Robot robot = Robot.GetInstance();
        Field field = Field.GetInstance();
        if (robot.X == 5)
            return;
        int x = robot.X + 1;
        if (field.Cells[x, robot.Y] != 2)
        {
            field.DrawCleanField(robot.X, robot.Y);
            robot.X = x;
        }
    }
}