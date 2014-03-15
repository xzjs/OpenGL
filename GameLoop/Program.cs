﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace GameLoop
{
    static class Program
    {
        static FastLoop _fastLoop = new FastLoop(GameLoop);
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }

        static void GameLoop()
        {
            System.Console.WriteLine("loop");
        }
    }
}
