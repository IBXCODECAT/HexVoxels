﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using OpenTK.Graphics.OpenGL;
using OpenTK.Mathematics;
using OpenTK.Windowing.Common;
using OpenTK.Windowing.Desktop;

namespace Hexoidra
{
    internal class Game : GameWindow
    {
        private int width;
        private int height;

        public Game(int width, int height) : base(GameWindowSettings.Default, NativeWindowSettings.Default)
        {

            this.width = width;
            this.height = height;

            //Center window on monitor
            CenterWindow(new Vector2i(width, height));
        }

        //Called every time the screen is resized
        protected override void OnResize(ResizeEventArgs e)
        {
            base.OnResize(e);
            GL.Viewport(0, 0, e.Width, e.Height);
            
            width = e.Width;
            height = e.Height;
        }

        protected override void OnLoad()
        {
            base.OnLoad();
        }

        protected override void OnUnload()
        {
            base.OnUnload();
        }

        
        protected override void OnRenderFrame(FrameEventArgs args)
        {
            GL.ClearColor(0.6f, 0.3f, 1f, 1f);
            GL.Clear(ClearBufferMask.ColorBufferBit);

            Context.SwapBuffers();

            base.OnRenderFrame(args);
        }

        protected override void OnUpdateFrame(FrameEventArgs args)
        {
            base.OnUpdateFrame(args);
        }
    }
}
