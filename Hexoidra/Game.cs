﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using OpenTK.Mathematics;
using OpenTK.Windowing.Desktop;

namespace Hexoidra
{
    internal class Game : GameWindow
    {

        private static int SCREEN_WIDTH;
        private static int SCREEN_HEIGHT;

        public Game(int width, int height) : base(GameWindowSettings.Default, NativeWindowSettings.Default)
        {
            //Center window on monitor
            this.CenterWindow(new Vector2i(width, height));

            SCREEN_WIDTH = width;
            SCREEN_HEIGHT = height;
        }
    }
}
