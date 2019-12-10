using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SharpGL;

namespace FirstOpenGL
{
    class CreateModels
    {

        public void DefoultCube(OpenGL GL)
        {
            GL.Begin(OpenGL.GL_QUADS);


            GL.TexCoord(0.0f, 0.0f); GL.Vertex(-1.0f, -1.0f, 1.0f);   // Bottom Left Of The Texture and Quad
            GL.TexCoord(1.0f, 0.0f); GL.Vertex(1.0f, -1.0f, 1.0f);    // Bottom Right Of The Texture and Quad
            GL.TexCoord(1.0f, 1.0f); GL.Vertex(1.0f, 1.0f, 1.0f); // Top Right Of The Texture and Quad
            GL.TexCoord(0.0f, 1.0f); GL.Vertex(-1.0f, 1.0f, 1.0f);    // Top Left Of The Texture and Quad

            // Back Face
            GL.TexCoord(1.0f, 0.0f); GL.Vertex(-1.0f, -1.0f, -1.0f);  // Bottom Right Of The Texture and Quad
            GL.TexCoord(1.0f, 1.0f); GL.Vertex(-1.0f, 1.0f, -1.0f);   // Top Right Of The Texture and Quad
            GL.TexCoord(0.0f, 1.0f); GL.Vertex(1.0f, 1.0f, -1.0f);    // Top Left Of The Texture and Quad
            GL.TexCoord(0.0f, 0.0f); GL.Vertex(1.0f, -1.0f, -1.0f);   // Bottom Left Of The Texture and Quad

            // Top Face
            GL.TexCoord(0.0f, 1.0f); GL.Vertex(-1.0f, 1.0f, -1.0f);   // Top Left Of The Texture and Quad
            GL.TexCoord(0.0f, 0.0f); GL.Vertex(-1.0f, 1.0f, 1.0f);    // Bottom Left Of The Texture and Quad
            GL.TexCoord(1.0f, 0.0f); GL.Vertex(1.0f, 1.0f, 1.0f); // Bottom Right Of The Texture and Quad
            GL.TexCoord(1.0f, 1.0f); GL.Vertex(1.0f, 1.0f, -1.0f);    // Top Right Of The Texture and Quad

            // Bottom Face
            GL.TexCoord(1.0f, 1.0f); GL.Vertex(-1.0f, -1.0f, -1.0f);  // Top Right Of The Texture and Quad
            GL.TexCoord(0.0f, 1.0f); GL.Vertex(1.0f, -1.0f, -1.0f);   // Top Left Of The Texture and Quad
            GL.TexCoord(0.0f, 0.0f); GL.Vertex(1.0f, -1.0f, 1.0f);    // Bottom Left Of The Texture and Quad
            GL.TexCoord(1.0f, 0.0f); GL.Vertex(-1.0f, -1.0f, 1.0f);   // Bottom Right Of The Texture and Quad

            // Right face
            GL.TexCoord(1.0f, 0.0f); GL.Vertex(1.0f, -1.0f, -1.0f);   // Bottom Right Of The Texture and Quad
            GL.TexCoord(1.0f, 1.0f); GL.Vertex(1.0f, 1.0f, -1.0f);    // Top Right Of The Texture and Quad
            GL.TexCoord(0.0f, 1.0f); GL.Vertex(1.0f, 1.0f, 1.0f); // Top Left Of The Texture and Quad
            GL.TexCoord(0.0f, 0.0f); GL.Vertex(1.0f, -1.0f, 1.0f);    // Bottom Left Of The Texture and Quad

            // Left Face
            GL.TexCoord(0.0f, 0.0f); GL.Vertex(-1.0f, -1.0f, -1.0f);  // Bottom Left Of The Texture and Quad
            GL.TexCoord(1.0f, 0.0f); GL.Vertex(-1.0f, -1.0f, 1.0f);   // Bottom Right Of The Texture and Quad
            GL.TexCoord(1.0f, 1.0f); GL.Vertex(-1.0f, 1.0f, 1.0f);    // Top Right Of The Texture and Quad
            GL.TexCoord(0.0f, 1.0f); GL.Vertex(-1.0f, 1.0f, -1.0f);   // Top Left Of The Texture and Quad


            GL.End();




        }
    }
}
