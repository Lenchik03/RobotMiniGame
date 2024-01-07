// класс робота
internal class Robot
{
    // организовать синглтон и хранение текущих координат
    private static Robot instance;

    public int X { get; internal set; }
    public int Y { get; internal set; }

    public static Robot GetInstance()
    {
        if (instance == null)
            instance = new Robot();
        return instance;
    }

}