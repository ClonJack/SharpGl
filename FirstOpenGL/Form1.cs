using System;
using System.Drawing;
using System.Windows.Forms;
using SharpGL;
using SharpGL.SceneGraph.Assets;
using SharpGL.SceneGraph.Transformations;
using SharpGL.Enumerations;
using SharpGL;
using System.Numerics;
namespace FirstOpenGL
{
    public partial class Form1 : Form
    {

        private Texture texture = new Texture();
        private CreateModels models = new CreateModels();


        private double angleRotationCube_last = 0;
        private double angleRotationCube = 0;

        private bool isRotate = false;

        private Point Pm_ONE;
        private Point Pm_TWO;
        private PointF centrModel;


        private Vector3[] vector = new Vector3[]
        {
            new Vector3(0, 0,(float)(2 * Math.Sqrt(6) / 4)),
            new Vector3((float)(2 / Math.Sqrt(3)), 0, (float)(-2 * Math.Sqrt(6) / 12)),
            new Vector3((float)(-2 /  Math.Sqrt(12)), 2 / 2, (float)(-2 * Math.Sqrt(6) / 12)),
            new Vector3((float)(-2 / Math.Sqrt(12)), -2 / 2,(float)(-2 * Math.Sqrt(6) / 12))
    };






        public Form1()
        {


            InitializeComponent();

            OpenGL GL = this.openGLControl1.OpenGL;

            GL.Enable(OpenGL.GL_TEXTURE_2D);


            Pm_ONE = Cursor.Position;

            centrModel = new PointF(this.ClientSize.Width / 2, this.ClientSize.Height / 2);


            texture.Create(GL, "C: /Users/1/Downloads/shat.jpg");


        }





        private void openGLControl1_OpenGLDraw(object sender, SharpGL.RenderEventArgs args)
        {


            OpenGL GL = this.openGLControl1.OpenGL;


     


            GL.Clear(OpenGL.GL_COLOR_BUFFER_BIT | OpenGL.GL_DEPTH_BUFFER_BIT);

            GL.LoadIdentity();

            GL.Translate(0, 0, -6);



            GL.MatrixMode(MatrixMode.Modelview);


            double atan_two = Math.Atan2((centrModel.Y - Cursor.Position.Y), (centrModel.X - Cursor.Position.X));

            angleRotationCube = (atan_two * 180) / Math.PI;


            GL.Rotate(angleRotationCube, Cursor.Position.X, Cursor.Position.Y, 0);



            // texture.Bind(GL);

            

            GL.Begin(BeginMode.Polygon);

            GL.Color(1f, 0, 1f, 1f);
            GL.Vertex(vector[0].X, vector[0].Y, vector[0].Z);
            GL.Vertex(vector[1].X, vector[1].Y, vector[1].Z);
            GL.Vertex(vector[2].X, vector[2].Y, vector[2].Z);
           
            GL.End();





            GL.Begin(BeginMode.Polygon);

            GL.Color(1f,1f, 0f, 1f);
            GL.Vertex(vector[0].X, vector[0].Y, vector[0].Z);
            GL.Vertex(vector[3].X, vector[3].Y, vector[3].Z);
            GL.Vertex(vector[1].X, vector[1].Y, vector[1].Z);

            GL.End();




            GL.Begin(BeginMode.Polygon);
            GL.Color(1, 1, 1, 1f);
            GL.Vertex(vector[0].X, vector[0].Y, vector[0].Z);
            GL.Vertex(vector[2].X, vector[2].Y, vector[2].Z);
            GL.Vertex(vector[3].X, vector[3].Y, vector[3].Z);

            GL.End();


            GL.Begin(BeginMode.Polygon);
            GL.Color(0, 1f, 0, 1f);
            GL.Vertex(vector[1].X, vector[1].Y, vector[1].Z);
            GL.Vertex(vector[3].X, vector[3].Y, vector[3].Z);
            GL.Vertex(vector[2].X, vector[2].Y, vector[2].Z);

        
            GL.End();
        


            //     models.DefoultCube(GL);



            GL.Flush();



        }

    }




}





