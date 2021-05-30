using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenTK;
using OpenTK.Graphics.OpenGL;
using OpenTK.Graphics;
using System.Drawing;
using System.Drawing.Imaging;
namespace ConsoleApplication1
{
    class Ventana
    {
        GameWindow ventana;

        
        Silla silla = new Silla();

        //----------------CONFIGURACIONES DE VENTANA Y OTROS-----------------
        public Ventana(GameWindow ventana)
        {
            this.ventana = ventana;
            comenzar();
        }
        void comenzar()
        {
            ventana.Load += cargar;
            ventana.Resize += redimencionar;
            ventana.RenderFrame += renderizar;
            ventana.Run(1.0 / 60.0);
        }
        void redimencionar(object ob, EventArgs e)//redimensianar la ventana
        {
            GL.Viewport(0, 0, ventana.Width, ventana.Height);
            GL.MatrixMode(MatrixMode.Projection);
            GL.LoadIdentity();
            Matrix4 matrix = Matrix4.CreatePerspectiveFieldOfView(MathHelper.DegreesToRadians(45), ventana.Width / ventana.Height, 1.0f, 100.0f);
            GL.LoadMatrix(ref matrix);

            GL.MatrixMode(MatrixMode.Modelview);
            
        }
        void renderizar(object o, EventArgs e)//es lo que siempre se esta ejecutando
        {
            
            GL.LoadIdentity();
            GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);
            //SILLA 1
            GL.PushMatrix();
            GL.Translate(0.0, 0.0, 0.0);
            silla.dibujar();
            GL.PopMatrix();
            //SILLA 2
            GL.PushMatrix();
            GL.Translate(-5.0, 0.0, 0.0);
            GL.Scale(0.4, 0.25, 0.3);
            silla.dibujar();
            GL.PopMatrix();
            //SILLA 3
            GL.PushMatrix();
            GL.Scale(0.5,0.5,1.0);
            GL.Translate(20.0, 0.0, 0.0);
            silla.dibujar();
            GL.PopMatrix();
            //SILLA 4
            GL.PushMatrix();
            GL.Scale(0.15, 0.15, 0.15);
            GL.Translate(30.0, -5.0, 10.0);
            silla.dibujar();
            GL.PopMatrix();
            ventana.SwapBuffers();
            
        }
        void cargar(object o, EventArgs e)
        {
            GL.ClearColor(65 / 255.0f, 137 / 255.0f, 157 / 255.0f, 0.0f);
            GL.Enable(EnableCap.DepthTest);

        }


    }
}
