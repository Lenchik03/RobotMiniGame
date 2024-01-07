// класс поля
using System.Drawing;

internal class Field
{
    private static Field instance;

    public static Field GetInstance()
    {
        if (instance == null)
            instance = new Field();
        return instance;
    }
    public int X { get; internal set; }
    public int Y { get; internal set; }
    // тут организовать синглтон и хранение ячеек в свойстве Cells

    public int[,] Cells { get; set; }

    public void DrawCleanField(int x, int y)
    {
        Paint paint = Paint.GetInstance();
        paint.Graphics.FillRectangle(Brushes.Green, 200 + x * 50, 200 + y * 50, 50, 50);
    }


    internal bool CheckRobotEndGame(Robot robot, Field field)
    {
        if (robot.X == field.X && robot.Y == field.Y)
           return true;

        return false;
        // сравнение координат робота с координатами
        // финишной точки
    }
}

