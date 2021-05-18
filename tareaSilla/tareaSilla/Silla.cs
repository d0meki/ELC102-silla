﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenTK;
using OpenTK.Graphics.OpenGL;
namespace tareaSilla
{
    class Silla
    {
        GameWindow window;
        private float red;

        public Silla(GameWindow window)
        {
            this.window = window;
            start();
        }
        void start()
        {
            window.Load += loaded;
            window.Resize += resize;
            window.RenderFrame += renderF;
            window.Run(1.0 / 60.0);
        }
        void resize(object ob, EventArgs e)
        {
            GL.Viewport(0, 0, window.Width, window.Height);
            GL.MatrixMode(MatrixMode.Projection);
            GL.LoadIdentity();
            //GL.Ortho(0.0,50.0,0.0,50.0,-1.0,1.0);
            GL.Ortho(-50.0, 50.0, -50.0, 50.0, -1.0, 1.0);
            GL.MatrixMode(MatrixMode.Modelview);
        }
        void renderF(object o, EventArgs e)
        {
            GL.Clear(ClearBufferMask.ColorBufferBit);
            // SILLA hecha con lineas
            GL.Begin(BeginMode.Lines);
            GL.Color3(0.0f, 0.0f, 0.0f); //rojo

            //asiento
            GL.Vertex2(-15.0, 0.0); GL.Vertex2(15.0, 0.0);//X,Y punto 1 y 2
            GL.Vertex2(-15.0, -1.0); GL.Vertex2(15.0, -1.0);

            GL.Vertex2(-15.0, -1.0); GL.Vertex2(-15.0, 0.0);
            GL.Vertex2(15.0, -1.0); GL.Vertex2(15.0, 0.0);

            GL.Vertex2(-12.0, 15.0); GL.Vertex2(12.0, 15.0);

            GL.Vertex2(-15.0, 0.0); GL.Vertex2(-12.0, 15.0);
            GL.Vertex2(15.0, 0.0); GL.Vertex2(12.0, 15.0);

            //espaldar
            GL.Vertex2(-12.0, 15.0); GL.Vertex2(-12.0, 40.0);
            GL.Vertex2(12.0, 15.0); GL.Vertex2(12.0, 40.0);

            GL.Vertex2(-11.0, 15.0); GL.Vertex2(-11.0, 40.0);
            GL.Vertex2(11.0, 15.0); GL.Vertex2(11.0, 40.0);

            GL.Vertex2(-11.0, 40.0); GL.Vertex2(-12.0, 40.0);
            GL.Vertex2(11.0, 40.0); GL.Vertex2(12.0, 40.0);

            GL.Vertex2(-11.0, 38.0); GL.Vertex2(11.0, 38.0);
            GL.Vertex2(-11.0, 36.0); GL.Vertex2(11.0, 36.0);

            GL.Vertex2(-11.0, 32.0); GL.Vertex2(11.0, 32.0);
            GL.Vertex2(-11.0, 30.0); GL.Vertex2(11.0, 30.0);

            //patas
            //delanteras
            GL.Vertex2(-14.0, -1.0); GL.Vertex2(-14.0, -20.0);
            GL.Vertex2(-13.0, -1.0); GL.Vertex2(-13.0, -20.0);
            GL.Vertex2(-14.0, -20.0); GL.Vertex2(-13.0, -20.0);

            GL.Vertex2(14.0, -1.0); GL.Vertex2(14.0, -20.0);
            GL.Vertex2(13.0, -1.0); GL.Vertex2(13.0, -20.0);
            GL.Vertex2(14.0, -20.0); GL.Vertex2(13.0, -20.0);

            //traseras
            GL.Vertex2(-10.0, -1.0); GL.Vertex2(-10.0, -13.0);
            GL.Vertex2(-9.0, -1.0); GL.Vertex2(-9.0, -13.0);
            GL.Vertex2(-10.0, -13.0); GL.Vertex2(-9.0, -13.0);

            GL.Vertex2(10.0, -1.0); GL.Vertex2(10.0, -13.0);
            GL.Vertex2(9.0, -1.0); GL.Vertex2(9.0, -13.0);
            GL.Vertex2(10.0, -13.0); GL.Vertex2(9.0, -13.0);





            GL.End();
            window.SwapBuffers();
        }
        void loaded(object o, EventArgs e)
        {
            GL.ClearColor(1.0f, 1.0f, 1.0f, 0.0f);
        }
    }
}