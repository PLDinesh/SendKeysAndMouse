using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static SendKeysAndMouse.MouseOperations;

namespace SendKeysAndMouse
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    Thread.Sleep(10000);
                    MousePoint mousePoint = MouseOperations.GetCursorPosition();
                    mousePoint.X += 2;
                    mousePoint.Y += 2;
                    MouseOperations.SetCursorPosition(mousePoint);
                    Thread.Sleep(5000);
                    mousePoint.X -= 2;
                    mousePoint.Y -= 2;
                    MouseOperations.SetCursorPosition(mousePoint);
                    Thread.Sleep(5000);
                    mousePoint.X += 2;
                    mousePoint.Y += 2;
                    MouseOperations.SetCursorPosition(mousePoint);

                    MouseOperations.MouseEvent(MouseEventFlags.LeftDown);
                    Thread.Sleep(1000);
                    MouseOperations.MouseEvent(MouseEventFlags.LeftUp);
                    Thread.Sleep(1000);
                    //MouseOperations.MouseEvent(MouseEventFlags.LeftDown);
                    KeyboardEvents.Send(KeyboardEvents.ScanCodeShort.KEY_P);
                    Thread.Sleep(1000);
                    //MouseOperations.MouseEvent(MouseEventFlags.LeftUp);
                    KeyboardEvents.Send(KeyboardEvents.ScanCodeShort.KEY_Q);

                }catch(Exception ex)
                {
                    Console.WriteLine("Error while trying to send messages - {0}\n{1}",ex.Message,ex.StackTrace.ToString());
                }
            }
        }
    }

}
