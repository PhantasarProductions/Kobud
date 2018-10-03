using System;
using Gtk;
using UseJCR6;
using TrickyUnits;
using TrickyUnits.GTK;

namespace Kobud
{
    class MainClass
    {
        static TJCRDIR Assets;

        static object Init_JCR6() => new JCR6_lzma();

        static void Load_JCR6() { 
            Assets = JCR6.Dir(Dirry.C("$AppDir$/jcr/Kobud.jcr"));
            if (Assets == null) {
                QuickGTK.Error(JCR6.JERROR);
                throw new Exception(JCR6.JERROR);
            }
        }

        static void Init_GUI()
        {
            Application.Init();
            MainWindow win = new MainWindow();
            QuickGTK.MyMainWindow = win;
            win.Title = "Kobud";
            win.ShowAll();
        }

        static void Run() => Application.Run();


        static public void Main(){
            Init_JCR6();
            Init_GUI();
            Load_JCR6();
            Run();
        }
    }
}
