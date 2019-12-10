using System;
using System.Drawing;
using System.Windows.Forms;
using SharpGL;
using SharpGL.SceneGraph.Assets;
using SharpGL.SceneGraph.Transformations;
using SharpGL.Enumerations;
using System.Numerics;


namespace FirstOpenGL
{
    public partial class Form1 : Form
    {

        private Texture texture = new Texture();
        private CreateModels models = new CreateModels();



        private double angleRotationCube = 0;


        private PointF centrModel;

        private Camera g_Camera;

        private const int MOUSE_IDLE_TIME = 500; // ms 
        private const int MOUSE_MOVE_THRESHOLD = 2; // px 


        private static DateTime StartTime;
        private static PointF LastMousePos = Point.Empty;

        
      private  double CurrentPosSum;

        private Vector3[] vector = new Vector3[]
        {
            new Vector3(0, 0,(float)(2 * Math.Sqrt(6) / 4)),
            new Vector3((float)(2 / Math.Sqrt(3)), 0, (float)(-2 * Math.Sqrt(6) / 12)),
            new Vector3((float)(-2 /  Math.Sqrt(12)), 2 / 2, (float)(-2 * Math.Sqrt(6) / 12)),
            new Vector3((float)(-2 / Math.Sqrt(12)), -2 / 2,(float)(-2 * Math.Sqrt(6) / 12))
    };


        public Form1()
        {


            g_Camera = new Camera();
            InitializeComponent();

            OpenGL GL = this.openGLControl1.OpenGL;

            GL.Enable(OpenGL.GL_TEXTURE_2D);







            centrModel = new PointF(this.ClientSize.Width / 2, this.ClientSize.Height / 2);




            texture.Create(GL, "C: /Users/1/Downloads/shat.jpg");


        }







        private void openGLControl1_OpenGLDraw(object sender, SharpGL.RenderEventArgs args)
        {



            OpenGL GL = this.openGLControl1.OpenGL;

            args.Graphics.TranslateTransform(centrModel.X, centrModel.Y);

            args.Graphics.ScaleTransform(1, -1);



            GL.Clear(OpenGL.GL_COLOR_BUFFER_BIT | OpenGL.GL_DEPTH_BUFFER_BIT);


            GL.LoadIdentity();

            GL.MatrixMode(MatrixMode.Modelview);


            GL.Translate(0, 0, -6);



            //                   |Позиция |  |Направлен| |Верт.вектор|
            g_Camera.PostionCamera(0, 0.5f, 6, 0, 0.5f, 0, 0, 1f, 0);



            GL.LookAt(g_Camera.m_vPositionCam.X, g_Camera.m_vPositionCam.Y, g_Camera.m_vPositionCam.Z,
          g_Camera.m_vViewCam.X, g_Camera.m_vViewCam.Y, g_Camera.m_vViewCam.Z,
          g_Camera.m_vUpVectorCam.X, g_Camera.m_vUpVectorCam.Y, g_Camera.m_vUpVectorCam.Z);



            double RadDeg = 360 / (Math.PI * 2);


            double atan_two = Math.Atan2((centrModel.Y - Cursor.Position.Y),
                         (centrModel.X - Cursor.Position.X));//получаем угол поворота 

            angleRotationCube = atan_two * RadDeg;// переводим из радиан в градус









            var Rad = (Math.PI * 2) / 360;




            GL.Rotate(angleRotationCube, (Vector2.Normalize(new Vector2(Cursor.Position.X)).X * 2 * Rad),0,0);//сам поворот

            GL.Rotate(angleRotationCube, 0, (Vector2.Normalize(new Vector2(Cursor.Position.Y)).Y * 2 * Rad), 0);

            
            texture.Bind(GL);


            models.DefoultCube(GL);





            GL.Flush();




        }


    }




}





