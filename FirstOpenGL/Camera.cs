using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace FirstOpenGL
{
    class Camera : InitCam

       
    {

      
        public Camera()
        {
            m_vPositionCam = Vector3.Zero;
            m_vViewCam = new Vector3(0f, 1f, .5f);// // Иниц. вектор взгляда
            m_vUpVectorCam = Vector3.UnitZ;///Вертикальный вектор
        }

        public override void MoveCamera(float speed)
        {
            Vector3 viewVector = new Vector3(0);//Инициализация вектора направления взгляда

            //Получаем напралвение взгляда 
            viewVector = new Vector3(m_vViewCam.X - m_vPositionCam.X, m_vViewCam.Y - m_vPositionCam.Y, m_vViewCam.Z - m_vPositionCam.Z);




            /*движение камеры*/

            m_vPositionCam.X += viewVector.X * speed;
            m_vPositionCam.Z += viewVector.Z * speed;

           
            m_vViewCam.X += viewVector.X * speed;
            m_vViewCam.Y += viewVector.Z * speed;




        }

        public override void PostionCamera(float positionX, float positionY, float positionZ,
            float viewX, float viewY, float viewZ,
            float upVectorX, float upVectorY, float upVectorZ)
        {
            Vector3 vPositionCam = new Vector3(positionX, positionY, positionZ);//позиция камеры 
            Vector3 vViewCam = new Vector3(viewX, viewY, viewZ);//Направление камеры
            Vector3 vUpVectorCam=new Vector3(upVectorX, upVectorY, upVectorZ);//вертикальный вектор 


            m_vPositionCam = vPositionCam;
            m_vViewCam = vViewCam;
            m_vUpVectorCam = vUpVectorCam;

        }

    }
}
