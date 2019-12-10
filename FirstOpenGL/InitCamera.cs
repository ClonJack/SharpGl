using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace FirstOpenGL
{
    abstract class InitCam
    {
        public Vector3 m_vPositionCam;//позиция камеры 
        public Vector3 m_vViewCam;//Направление камеры
        public Vector3 m_vUpVectorCam;//вертикальный вектор 

      


        //позиция камеры ,направление 
        public abstract void PostionCamera(float positionX, float positionY, float positionZ,
                     float viewX, float viewY, float viewZ,
                 float upVectorX, float upVectorY, float upVectorZ);

        //движение камеры 
        public abstract void MoveCamera(float speed);



    }
}
