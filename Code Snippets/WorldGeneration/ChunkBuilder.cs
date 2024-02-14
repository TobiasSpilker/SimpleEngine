using System;
using OpenTK;
using OpenTK.Input;
using OpenTK.Graphics.OpenGL;
using System.Drawing;

namespace SimpleEngine
{
    public partial class game
    {
        void Build_Chunks()
        //if player is near specific location it will draw chunks on- and around that position
        {
            //Setting size of chunk array to that of  total amount of chunks that could fit:
            int Size = WorldSize / ChunkSize;

            //Setting render distance (aka chunk loading):
            int Margin = Convert.ToInt32(RenderDistance);

            for (int i = 0; i < Size; i++)
            //Looping through chunk array and comparing location to see if it should be loaded
            {
                for (int j = 0; j < Size; j++)
                {
                    #region Checking if player is close enough to chunk
                    if (beta_X < -1 * (i * (ChunkSize * 20)) + Margin
                        &&
                        beta_X > -1 * ((i * ChunkSize * 20) + ChunkSize * 20) - Margin
                        &&
                        beta_Z < -1 * (j * (ChunkSize * 20)) + Margin
                        &&
                        beta_Z > -1 * ((j * ChunkSize * 20) + ChunkSize * 20) - Margin)
                    {
                        //Giving chunk location to draw method so it will draw tiles on chunk place
                        Draw_Chunk(ChunkSize * i, ChunkSize * j);
                    }
                    #endregion

                }

            }

        }

        void Draw_Chunk(int q, int r)
        //Draws everything in the world {terrain, trees, rocks..}
        {
            //Real world coordinates coresponding with array location
            int X, Z;

            for (int i = 0 + q; i < ChunkSize + q; i++)
            {
                for (int j = 0 + r; j < ChunkSize + r; j++)
                {
                    //setting object & tile distance
                    X = (i * 20);
                    Z = (j * 20);

                    #region Drawing tiles
                    if (QuadValues[i, j] != null)
                    //if it is null it hasn't or shouldn't be generated so no tiles
                    {
                        //Always drawing empty tiles because thats the base:
                        Draw_Tile(X, Z, QuadValues[i, j]);

                    }

                    #endregion

                    #region Pine trees
                    //Drawing pine tree on tile [rotation 0]:
                    if (QuadValues[i, j] == "pine tree 0")
                    {
                        GL.PushMatrix();
                        Transform_Tree(X, Z, 0);
                        Draw_Tree();
                        GL.PopMatrix();
                    }

                    if (QuadValues[i, j] == "pine tree 90")
                    {
                        GL.PushMatrix();
                        Transform_Tree(X, Z, 90);
                        Draw_Tree();
                        GL.PopMatrix();
                    }

                    if (QuadValues[i, j] == "pine tree 180")
                    {
                        GL.PushMatrix();
                        Transform_Tree(X, Z, 180);
                        Draw_Tree();
                        GL.PopMatrix();
                    }

                    if (QuadValues[i, j] == "pine tree 270")
                    {
                        GL.PushMatrix();
                        Transform_Tree(X, Z, 270);
                        Draw_Tree();
                        GL.PopMatrix();
                    }
                    #endregion

                    #region Rocks
                    if (QuadValues[i, j] == "rocks 0")
                    {
                        GL.PushMatrix();
                        Transform_Rocks(X, Z, 0);
                        Draw_Rocks();
                        GL.PopMatrix();
                    }

                    if (QuadValues[i, j] == "rocks 90")
                    {
                        GL.PushMatrix();
                        Transform_Rocks(X, Z, 90);
                        Draw_Rocks();
                        GL.PopMatrix();
                    }

                    if (QuadValues[i, j] == "rocks 180")
                    {
                        GL.PushMatrix();
                        Transform_Rocks(X, Z, 180);
                        Draw_Rocks();
                        GL.PopMatrix();
                    }

                    if (QuadValues[i, j] == "rocks 270")
                    {
                        GL.PushMatrix();
                        Transform_Rocks(X, Z, 270);
                        Draw_Rocks();
                        GL.PopMatrix();
                    }
                    #endregion

                    #region Grass
                    if (QuadValues[i, j] == "grass 0")
                    {
                        GL.PushMatrix();
                        Transform_Grass(X, Z, 0);
                        Draw_Grass();
                        GL.PopMatrix();
                    }

                    if (QuadValues[i, j] == "grass 90")
                    {
                        GL.PushMatrix();
                        Transform_Grass(X, Z, 90);
                        Draw_Grass();
                        GL.PopMatrix();
                    }

                    if (QuadValues[i, j] == "grass 180")
                    {
                        GL.PushMatrix();
                        Transform_Grass(X, Z, 180);
                        Draw_Grass();
                        GL.PopMatrix();
                    }

                    if (QuadValues[i, j] == "grass 170")
                    {
                        GL.PushMatrix();
                        Transform_Grass(X, Z, 170);
                        Draw_Grass();
                        GL.PopMatrix();
                    }
                    #endregion
                }
            }


        }
    }
}
