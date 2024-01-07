// класс для рисования поля
using System.Drawing;

internal class FieldCommander : ICommander
{
    public FieldCommander()
    {
    }

    public void Execute(int[] value)
    {
        // получение ссылки на Graphics для рисования
        Paint paint = Paint.GetInstance();

        // происходит рисование поля, цифры заносятся
        // в объект Field заносятся цифры (одномерный массив
        // в 25 ячеек преобразовываем в двумерный массив 5х5)
        // в объект Robot заносятся координаты
        int[,] array = new int[5,5];
        int o = 0;
        for (int i = 0; i < 5; i++)
            for (int j = 0; j < 5; j++)
            {
                array[i, j] = value[o++];
            }

        Field field = Field.GetInstance();
        field.Cells = array;

        for (int i = 0; i < 5; i++)
            for (int j = 0; j < 5; j++)
            {
                Brush brush = null;
                switch(array[i,j])
                {
                    case 1:
                        brush = Brushes.Green; break;
                    case 2:
                        brush = Brushes.Red; break;
                    case 3:
                        Robot.GetInstance().X = i;
                        Robot.GetInstance().Y = j;
                        continue;
                    case 4:
                        field.X = i;
                        field.Y = j;
                        continue;
                }
                paint.Graphics.FillRectangle(brush, 200+i * 50, 200+j * 50, 50, 50);

            }
    }
}
