using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Player : MarshalByRefObject
{
    private int HorizontalOffset; // half of 28
    private int VerticalOffset;// half of 10
    public void SayHello(string[] text)
    {
        HorizontalOffset = text[0].Length / 2;
        VerticalOffset = text.Length / 2;

        for (int i = 0; i < 10; i++)
        {
            //Console.WriteLine(String.Format("{0," + (Console.WindowWidth / 2) + "}",text));
            int leftOffSet = (Console.WindowWidth / 2 - HorizontalOffset);
            int topOffSet = (Console.WindowHeight / 2 - VerticalOffset + i);
            Console.SetCursorPosition(leftOffSet, topOffSet);
            Console.Write(text[i]);
        }
    }
}