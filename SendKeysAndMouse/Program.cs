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
            Random rnd = new Random();

            while (true)
            {
                try
                {
                    int v = rnd.Next(0, 11);
                    //    Thread.Sleep(10000);
                    //    MousePoint mousePoint = MouseOperations.GetCursorPosition();
                    //    mousePoint.X += 2;
                    //    mousePoint.Y += 2;
                    //    MouseOperations.SetCursorPosition(mousePoint);
                    //    Thread.Sleep(5000);
                    //    mousePoint.X -= 2;
                    //    mousePoint.Y -= 2;
                    //    MouseOperations.SetCursorPosition(mousePoint);
                    //    Thread.Sleep(5000);
                    //    mousePoint.X += 2;
                    //    mousePoint.Y += 2;
                    //    MouseOperations.SetCursorPosition(mousePoint);

                    MouseOperations.MouseEvent(MouseEventFlags.LeftDown);
                    Thread.Sleep(1000);
                    MouseOperations.MouseEvent(MouseEventFlags.LeftUp);
                    Thread.Sleep(1000);
                    //MouseOperations.MouseEvent(MouseEventFlags.LeftDown);

                    switch (v)
                    {
                        case 0:
                            KeyboardEvents.Send(KeyboardEvents.ScanCodeShort.KEY_P);
                            Thread.Sleep(1000);
                            break;
                        //MouseOperations.MouseEvent(MouseEventFlags.LeftUp);
                        case 1:
                            KeyboardEvents.Send(KeyboardEvents.ScanCodeShort.KEY_Q);
                            Thread.Sleep(1000);
                            break;

                        case 2:
                            KeyboardEvents.Send(KeyboardEvents.ScanCodeShort.KEY_A);
                            Thread.Sleep(1000);
                            break;
                        case 3:
                            KeyboardEvents.Send(KeyboardEvents.ScanCodeShort.KEY_N);
                            Thread.Sleep(1000);
                            break;
                        case 4:
                            KeyboardEvents.Send(KeyboardEvents.ScanCodeShort.KEY_O);
                            Thread.Sleep(1000);
                            break;
                        case 5:
                            KeyboardEvents.Send(KeyboardEvents.ScanCodeShort.KEY_R);
                            Thread.Sleep(1000);
                            break;
                        case 6:
                            KeyboardEvents.Send(KeyboardEvents.ScanCodeShort.KEY_S);
                            Thread.Sleep(1000);
                            break;
                        case 7:
                            KeyboardEvents.Send(KeyboardEvents.ScanCodeShort.KEY_K);
                            Thread.Sleep(1000);
                            break;
                        case 8:
                            KeyboardEvents.Send(KeyboardEvents.ScanCodeShort.KEY_U);
                            Thread.Sleep(1000);
                            break;
                        case 9:
                            KeyboardEvents.Send(KeyboardEvents.ScanCodeShort.KEY_T);
                            Thread.Sleep(1000);
                            break;
                        case 10:
                            KeyboardEvents.Send(KeyboardEvents.ScanCodeShort.KEY_Z);
                            Thread.Sleep(1000);
                            break;
                        default:
                            KeyboardEvents.Send(KeyboardEvents.ScanCodeShort.KEY_H);
                            Thread.Sleep(1000);
                            break;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error while trying to send messages - {0}\n{1}", ex.Message, ex.StackTrace.ToString());
                }
            }
        }
    }

}
