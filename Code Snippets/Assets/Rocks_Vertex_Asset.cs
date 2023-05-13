        void Draw_Rocks()
        {
            //Drawing rocks with various rotations, locations and sizes:

            #region Big rock
            GL.PushMatrix();
            GL.Translate(0.0, 2.0, 0.0);
            GL.Rotate(45.0, 0.0, 1.0, 0.0);
            GL.Scale(0.52, 0.4, 0.48);
            Draw_Rock();
            GL.PopMatrix();
            #endregion

            #region Small rocks
            GL.PushMatrix();
            GL.Translate(-5.0, 0.5, 5.0);
            GL.Rotate(25.0, 0.0, 1.0, 0.0);
            GL.Scale(0.12, 0.1, 0.1);
            Draw_Rock();
            GL.PopMatrix();

            GL.PushMatrix();
            GL.Translate(-4.0, 0.5, -5.0);
            GL.Rotate(31.0, 0.0, 1.0, 0.0);
            GL.Scale(0.12, 0.1, 0.16);
            Draw_Rock();
            GL.PopMatrix();

            GL.PushMatrix();
            GL.Translate(7.2, 0.5, 7.0);
            GL.Rotate(14.0, 0.0, 1.0, 0.0);
            GL.Scale(0.14, 0.1, 0.12);
            Draw_Rock();
            GL.PopMatrix();
            #endregion

            #region Pebbles
            GL.PushMatrix();
            GL.Translate(-5.0, 0.25, 0.5);
            GL.Rotate(14.0, 0.0, 1.0, 0.0);
            GL.Scale(0.05, 0.05, 0.05);
            Draw_Rock();
            GL.PopMatrix();

            GL.PushMatrix();
            GL.Translate(-6.0, 0.25, -5.5);
            GL.Rotate(18.0, 0.0, 1.0, 0.0);
            GL.Scale(0.05, 0.05, 0.05);
            Draw_Rock();
            GL.PopMatrix();

            GL.PushMatrix();
            GL.Translate(-8.0, 0.25, 4.5);
            GL.Rotate(21.0, 0.0, 1.0, 0.0);
            GL.Scale(0.05, 0.05, 0.05);
            Draw_Rock();
            GL.PopMatrix();

            
            GL.PushMatrix();
            GL.Translate(2.0, 0.25, 8.0);
            GL.Rotate(25.0, 0.0, 1.0, 0.0);
            GL.Scale(0.05, 0.05, 0.05);
            Draw_Rock();
            GL.PopMatrix();

            GL.PushMatrix();
            GL.Translate(3.0, 0.25, -8.5);
            GL.Rotate(28.0, 0.0, 1.0, 0.0);
            GL.Scale(0.05, 0.05, 0.05);
            Draw_Rock();
            GL.PopMatrix();

            #endregion
        }

        void Draw_Rock()
        {
            #region Quads
            GL.Begin(BeginMode.Quads);

            //Topside:
            GL.Color3(0.33, 0.35, 0.33);
            GL.Vertex3(0.0, 0.0, 0.0);      //Left back
            GL.Vertex3(0.0, 0.0, 10.0);     //Left front
            GL.Vertex3(10.0, 0.0, 10.0);    //Right front
            GL.Vertex3(10.0, 0.0, 0.0);     //Right back

            //Leftside:
            GL.Color3(0.33, 0.33, 0.33);
            GL.Vertex3(-5.0, -5.0, 0.0);
            GL.Vertex3(-5.0, -5.0, 10.0);
            GL.Vertex3(0.0, 0.0, 10.0);
            GL.Vertex3(0.0, 0.0, 0.0);

            //Rightside:
            GL.Color3(0.3, 0.3, 0.35);
            GL.Vertex3(10.0, 0.0, 0.0);
            GL.Vertex3(10.0, 0.0, 10.0);
            GL.Vertex3(15.0, -5.0, 10.0);
            GL.Vertex3(15.0, -5.0, 0.0);

            //Frontside:
            GL.Color3(0.35, 0.35, 0.33);
            GL.Vertex3(0.0, 0.0, 10.0);
            GL.Vertex3(0.0, -5.0, 15.0);
            GL.Vertex3(10.0, -5.0, 15.0);
            GL.Vertex3(10.0, 0.0, 10.0);

            //Backside:
            GL.Color3(0.3, 0.3, 0.33);
            GL.Vertex3(0.0, -5.0, -5.0);      //Left back
            GL.Vertex3(0.0, 0.0, 0.0);     //Left front
            GL.Vertex3(10.0, 0.0, 0.0);    //Right front
            GL.Vertex3(10.0, -5.0, -5.0);     //Right back

            GL.End();
            #endregion

            #region Triangles
            GL.Begin(BeginMode.Triangles);
            
            //Mid slope - left front:
            GL.Color3(0.3, 0.3, 0.3);
            GL.Vertex3(-5.0, -5.0, 10.0);
            GL.Vertex3(0.0, 0.0, 10.0);
            GL.Vertex3(0.0, -5.0, 15.0);

            //Mid slope - right front:
            GL.Color3(0.35, 0.3, 0.3);
            GL.Vertex3(10.0, -5.0, 15.0);
            GL.Vertex3(10.0, 0.0, 10.0);
            GL.Vertex3(15.0, -5.0, 10.0);

            //Mid slope - left back:
            GL.Color3(0.33, 0.3, 0.35);
            GL.Vertex3(-5.0, -5.0, 0.0);
            GL.Vertex3(0.0, 0.0, 0.0);
            GL.Vertex3(0.0, -5.0, -5.0);

            //Mid slope - right back:
            GL.Color3(0.3, 0.35, 0.33);
            GL.Vertex3(15.0, -5.0, 0.0);
            GL.Vertex3(10.0, 0.0, 0.0);
            GL.Vertex3(10.0, -5.0, -5.0);

            GL.End();
            #endregion
        }
