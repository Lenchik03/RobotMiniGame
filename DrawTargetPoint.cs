using System.Drawing;

internal class DrawTargetPoint : IRobotCommand
{
    public void Execute()
    {
        Paint paint = Paint.GetInstance();
        Field field = Field.GetInstance();

        paint.Graphics.FillRectangle(Brushes.Magenta, 200 + field.X * 50, 200 + field.Y * 50, 50, 50);
    }
}