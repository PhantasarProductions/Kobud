// Lic:
// 	Kobud
// 	Phantasar Style Gambling Game
// 	
// 	
// 	
// 	(c) Jeroen P. Broks, 2018, All rights reserved
// 	
// 		This program is free software: you can redistribute it and/or modify
// 		it under the terms of the GNU General Public License as published by
// 		the Free Software Foundation, either version 3 of the License, or
// 		(at your option) any later version.
// 		
// 		This program is distributed in the hope that it will be useful,
// 		but WITHOUT ANY WARRANTY; without even the implied warranty of
// 		MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// 		GNU General Public License for more details.
// 		You should have received a copy of the GNU General Public License
// 		along with this program.  If not, see <http://www.gnu.org/licenses/>.
// 		
// 	Exceptions to the standard GNU license are available with Jeroen's written permission given prior 
// 	to the project the exceptions are needed for.
// Version: 18.10.07
// EndLic
﻿using System;
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
