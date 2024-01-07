// класс для ввода данных
using System.Drawing;

internal class DrawRobotCommand : IRobotCommand
{
    public void Execute()
    {
        // нарисовать робота по его координатам
        Paint paint = Paint.GetInstance();
        Robot robot = Robot.GetInstance();

        paint.Graphics.FillRectangle(Brushes.Blue,200+ robot.X * 50, 200+robot.Y * 50, 50, 50);
    }
}

