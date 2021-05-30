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
    class Cubo
    {
        private double x;
        private double y;
        private double z;
        public Cubo(double x, double y, double z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }
        
        public void dibujar()
        {

            GL.Begin(PrimitiveType.Quads);
            GL.Color3(1.0, 1.0, 0.0);

            GL.Vertex3(-x, y, z);
            GL.Vertex3(-x, y,-z);
            GL.Vertex3(-x, -y,-z);
            GL.Vertex3(-x, -y, z);

            GL.Color3(1.0, 0.0, 1.0);

            GL.Vertex3(x, y, z);
            GL.Vertex3(x, y, -z);
            GL.Vertex3(x, -y, -z);
            GL.Vertex3(x, -y, z);

            GL.Color3(0.0, 1.0, 1.0);

            GL.Vertex3(x, -y, z);
            GL.Vertex3(x, -y, -z);
            GL.Vertex3(-x, -y, -z);
            GL.Vertex3(-x, -y, z);

            GL.Color3(1.0, 0.0, 0.0);

            GL.Vertex3(x, y, z);
            GL.Vertex3(x, y, -z);
            GL.Vertex3(-x, y, -z);
            GL.Vertex3(-x, y, z);

            GL.Color3(0.0, 1.0, 0.0);

            GL.Vertex3(x, y, -z);
            GL.Vertex3(x, -y, -z);
            GL.Vertex3(-x, -y, -z);
            GL.Vertex3(-x, y, -z);

            GL.Color3(0.0, 0.0, 1.0);

            GL.Vertex3(x, y, z);
            GL.Vertex3(x, -y, z);
            GL.Vertex3(-x, -y, z);
            GL.Vertex3(-x, y, z);

            GL.End();
            GL.DrawArrays(PrimitiveType.Triangles,0, 12*3);
            GL.End();



        }
    }
}
