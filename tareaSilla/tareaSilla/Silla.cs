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
namespace tareaSilla
{
    class Silla
    {
        
        double angulo = 0.0;
        int texture;
        GameWindow window;

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
            window.Run(1.0 / 60.0); //60fps
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
            GL.LoadIdentity(); //para parar la ejecucion sino se pone a rotar sin parar
            GL.Clear(ClearBufferMask.ColorBufferBit);
            //GL.Rotate(angulo,0.0,0.0,1.0);
            // SILLA hecha con lineas
           

            //coloreando
            GL.Begin(PrimitiveType.Quads);
            GL.Color3(162 / 255.0, 145 / 255.0, 108 / 255.0);
            
            //asiento
            //contorno frontal
            GL.Vertex2(-15.0, -1.0);
            GL.Vertex2(-15.0, 0.0);
            GL.Vertex2(15.0, 0.0);
            GL.Vertex2(15.0, -1.0);
            
            
            //posadera
            //GL.Color3(0.0f, 0.5f, 0.5f); //rojo

            GL.Vertex2(-15.0, 0.0);
            GL.TexCoord2(0, 0);
            GL.Vertex2(-12.0, 15.0);
            GL.TexCoord2(1, 0);
            GL.Vertex2(12.0, 15.0);
            GL.TexCoord2(1, 1);
            GL.Vertex2(15.0, 0.0);
            GL.TexCoord2(0, 1);
            //espaldar
            //GL.Color3(1.0f, 1.0f, 0.0f);

            //columna izquierda
            GL.Vertex2(-12.0, 15.0);
            GL.Vertex2(-12.0, 40.0);
            GL.Vertex2(-11.0, 40.0);
            GL.Vertex2(-11.0, 15.0);
            //columna derecha
            //GL.Color3(0.0f, 1.0f, 0.0f);

            GL.Vertex2(12.0, 15.0);
            GL.Vertex2(12.0, 40.0);
            GL.Vertex2(11.0, 40.0);
            GL.Vertex2(11.0, 15.0);

            //paralela arriba
            //GL.Color3(0.0f, 0.0f, 1.0f);

            GL.Vertex2(-11.0, 36.0);
            GL.Vertex2(-11.0, 38.0);
            GL.Vertex2(11.0, 38.0);
            GL.Vertex2(11.0, 36.0);
            
            //paralela abajo
            //GL.Color3(1.0f, 0.0f, 0.0f);

            GL.Vertex2(-11.0, 30.0);
            GL.Vertex2(-11.0, 32.0);
            GL.Vertex2(11.0, 32.0);
            GL.Vertex2(11.0, 30.0);
            //patas
            //deantera Izquierda
            //GL.Color3(1.0, 0.0, 1.0);

            GL.Vertex2(-14.0, -20.0);
            GL.Vertex2(-14.0, -1.0); 
            GL.Vertex2(-13.0, -1.0);
            GL.Vertex2(-13.0, -20.0);
            //delantera Derecha
            //GL.Color3(51/255.0, 255 / 255.0, 173 / 255.0); //colores RGB
          
            GL.Vertex2(14.0, -20.0);
            GL.Vertex2(14.0, -1.0);
            GL.Vertex2(13.0, -1.0);
            GL.Vertex2(13.0, -20.0);

            //trasera Izquierda
            //GL.Color3(82 / 255.0, 66 / 255.0, 32 / 255.0);

            GL.Vertex2(-10.0, -13.0);
            GL.Vertex2(-10.0, -1.0); 
            GL.Vertex2(-9.0, -1.0);
            GL.Vertex2(-9.0, -13.0);
            //trasera Derecha
            //GL.Color3(162 / 255.0, 145 / 255.0, 108 / 255.0);

            GL.Vertex2(10.0, -13.0);
            GL.Vertex2(10.0, -1.0);
            GL.Vertex2(9.0, -1.0);
            GL.Vertex2(9.0, -13.0);




            GL.End();
            GL.Begin(PrimitiveType.Lines);
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
            angulo += 1.0;
            if (angulo > 360) {
                angulo -= 360;
            }
        }
        void loaded(object o, EventArgs e)
        {
            GL.ClearColor(245 / 255.0f, 228 / 255.0f, 189 / 255.0f, 0.0f);
            //texturas
            GL.Enable(EnableCap.Texture2D);
            GL.GenTextures(1,out texture);
            GL.BindTexture(TextureTarget.Texture2D,texture);
            BitmapData textData = cargarTextura(@"D:\brick.bmp");
            GL.TexImage2D(TextureTarget.Texture2D,0,OpenTK.Graphics.OpenGL.PixelInternalFormat.Rgb, textData.Width,textData.Height
                ,0,OpenTK.Graphics.OpenGL.PixelFormat.Bgr,PixelType.UnsignedByte,textData.Scan0);
            GL.GenerateMipmap(GenerateMipmapTarget.Texture2D);
        }
        BitmapData cargarTextura(string filePath) {
            Bitmap bmb = new Bitmap(filePath);
            Rectangle rect= new Rectangle(0,0,bmb.Width,bmb.Height);
            BitmapData bmbdata = bmb.LockBits(rect,ImageLockMode.ReadOnly,System.Drawing.Imaging.PixelFormat.Format24bppRgb);
            bmb.UnlockBits(bmbdata);
            return bmbdata;
        }
    }
}
