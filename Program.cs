using System;
using Gtk;
using UseJCR6;

namespace Kobud
{
    class MainClass
    {
        static object Init_JCR6() => new JCR6_lzma();

        static void Init_GUI()
        {
            Application.Init();
            MainWindow win = new MainWindow();
            win.ShowAll();
        }

        static void Run() => Application.Run();


        static public void Main(){
            Init_JCR6();
            Init_GUI();
            Run();
        }
    }
}
