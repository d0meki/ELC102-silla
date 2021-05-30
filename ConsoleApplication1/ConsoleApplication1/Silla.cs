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
    class Silla
    {
        double angulo = 0.0;
        double angulo1 = 0.0;
        double angulo2 = 0.0;

        double angulo3 = 0.0;
        Cubo cubo = new Cubo(0.5, 5, 0.5);
        Cubo cubo2 = new Cubo(6.0, 0.25, 6.0);
        Cubo cubo3 = new Cubo(5, 0.5, 0.5);
        public Silla()
        {
            
        }
        public void dibujar()
        {
            //_-------------------------PATA delanteras--------------------------------
            GL.PushMatrix();//-----

            GL.Translate(0.0, 0.0, -50); //lugar punto de masa 
            //GL.Rotate(angulo, 0.0, 1.0, 0.0);
            cubo.dibujar();
            GL.Translate(-10.0, 0.0, 0.0);
            cubo.dibujar();
            //traseras patas
            GL.Translate(10.0, 0.0, -10);
            cubo.dibujar();
            GL.Translate(-10.0, 0.0, 0.0);
            cubo.dibujar();
            //asiento
            GL.Translate(5.0, 5.0, 5.0);
            cubo2.dibujar();
            //palos verticalles de espaldar
            GL.Translate(5.0, 5.0, -5.0);
            cubo.dibujar();
            GL.Translate(-10.0, 0.0, 0.0);
            cubo.dibujar();
            //palos paralelos de espaldar
            GL.Translate(5.0, 0.0, 0.0);
            cubo3.dibujar();
            GL.Translate(0.0, 2.0, 0.0);
            cubo3.dibujar();
            GL.PopMatrix();
            rotar();
        }
        public void rotar() {
            angulo += 1.0;
            if (angulo > 360)
            {
                angulo -= 360;
            }
        }
    

    }
}
