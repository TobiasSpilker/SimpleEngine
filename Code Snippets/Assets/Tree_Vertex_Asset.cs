        void Draw_Tree()
        {
            //Everything between GL begin and -end is the same "object"
            GL.Begin(BeginMode.Triangles);
            #region Drawing tree log

            //Square 1 - Bottom half:
            GL.Color3(0.502, 0.4431, 0.3255);
            GL.Vertex3(0.0, 0.0, 0);
            GL.Vertex3(20.0, 20.0, 0.0);
            GL.Vertex3(20.0, 0.0, 0.0);

            //Square 1 - Top half:
            GL.Color3(0.502, 0.4431, 0.3255);
            GL.Vertex3(0.0, 20.0, 0);
            GL.Vertex3(20.0, 20.0, 0.0);
            GL.Vertex3(0.0, 0.0, 0.0);


            //Square 2 - Bottom half:
            GL.Color3(0.52, 0.48, 0.3);
            GL.Vertex3(20.0, 0.0, 0.0);       
            GL.Vertex3(40.0, 20.0, -20.0);
            GL.Vertex3(40.0, 0.0, -20.0);

            //Square 2 - Top half:
            GL.Color3(0.52, 0.48, 0.3);
            GL.Vertex3(20.0, 0.0, 0.0);
            GL.Vertex3(20.0, 20.0, 0.0);
            GL.Vertex3(40.0, 20.0, -20.0);


            //Square 3 - Bottom half:
            GL.Color3(0.502, 0.4431, 0.3255);
            GL.Vertex3(40.0, 0.0, -20.0);
            GL.Vertex3(40.0, 20.0, -40.0);
            GL.Vertex3(40.0, 0.0, -40.0);

            //Square 3 - Top half:
            GL.Color3(0.502, 0.4431, 0.3255);
            GL.Vertex3(40.0, 0.0, -20.0);
            GL.Vertex3(40.0, 20.0, -20.0);
            GL.Vertex3(40.0, 20.0, -40.0);


            //Square 4 - Bottom half:
            GL.Color3(0.52, 0.48, 0.3);
            GL.Vertex3(40.0, 0.0, -40.0);
            GL.Vertex3(20.0, 20.0, -60.0);
            GL.Vertex3(20.0, 0.0, -60.0);

            //Square 4 - Top half:
            GL.Color3(0.52, 0.48, 0.3);
            GL.Vertex3(40.0, 0.0, -40.0);
            GL.Vertex3(40.0, 20.0, -40.0);
            GL.Vertex3(20.0, 20.0, -60.0);


            //Square 5 - Bottom half:
            GL.Color3(0.502, 0.4431, 0.3255);
            GL.Vertex3(20.0, 0.0, -60.0);
            GL.Vertex3(0.0, 20.0, -60.0);
            GL.Vertex3(0.0, 0.0, -60.0);

            //Square 5 - Top half:
            GL.Color3(0.502, 0.4431, 0.3255);
            GL.Vertex3(20.0, 0.0, -60.0);
            GL.Vertex3(0.0, 20.0, -60.0);
            GL.Vertex3(20.0, 20.0, -60.0);


            //Square 6 - Bottom half:
            GL.Color3(0.52, 0.48, 0.3);
            GL.Vertex3(0.0, 0.0, -60.0);
            GL.Vertex3(-20.0, 20.0, -40.0);
            GL.Vertex3(-20.0, 0.0, -40.0);

            //Square 6 - Top half:
            GL.Color3(0.52, 0.48, 0.3);
            GL.Vertex3(0.0, 0.0, -60.0);
            GL.Vertex3(0.0, 20.0, -60.0);
            GL.Vertex3(-20.0, 20.0, -40.0);


            //Square 7 - Bottom half:
            GL.Color3(0.502, 0.4431, 0.3255);
            GL.Vertex3(-20.0, 0.0, -40.0);
            GL.Vertex3(-20.0, 20.0, -20.0);
            GL.Vertex3(-20.0, 0.0, -20.0);

            //Square 7 - Top half:
            GL.Color3(0.502, 0.4431, 0.3255);
            GL.Vertex3(-20.0, 0.0, -40.0);
            GL.Vertex3(-20.0, 20.0, -40.0);
            GL.Vertex3(-20.0, 20.0, -20.0);


            //Square 8 - Bottom half:
            GL.Color3(0.52, 0.48, 0.3);
            GL.Vertex3(-20.0, 0.0, -20.0);
            GL.Vertex3(0.0, 20.0, 0.0);
            GL.Vertex3(0.0, 0.0, 0.0);

            //Square 8 - Top half:
            GL.Color3(0.52, 0.48, 0.3);
            GL.Vertex3(-20.0, 0.0, -20.0);
            GL.Vertex3(-20.0, 20.0, -20.0);
            GL.Vertex3(0.0, 20.0, 0.0);
            #endregion
            GL.End();

            #region Leaf-set 1
            GL.PushMatrix();
            GL.Translate(0.0, 7.0, 0.0);
            GL.Scale(0.8, 0.8, 0.8);
            GL.Begin(BeginMode.Triangles);

            helper_leafs();

            GL.End();
            GL.PopMatrix();
            #endregion

            #region Leaf-set 2
            GL.PushMatrix();
            GL.Translate(20.0, 7.0, 0.0);
            GL.Rotate(45, 0.0, 1.0, 0.0);
            GL.Scale(0.8, 0.8, 0.8);
            GL.Begin(BeginMode.Triangles);

            helper_leafs();

            GL.End();
            GL.PopMatrix();
            #endregion

            #region Leaf-set 3
            GL.PushMatrix();
            GL.Translate(0.0, 13.0, -10.0);
            GL.Scale(0.6, 0.8, 0.6);
            GL.Begin(BeginMode.Triangles);

            helper_leafs();

            GL.End();
            GL.PopMatrix();
            #endregion

            #region Leaf-set 4
            GL.PushMatrix();
            GL.Translate(20.0, 13.0, -10.0);
            GL.Rotate(45, 0.0, 1.0, 0.0);
            GL.Scale(0.6, 0.8, 0.6);
            GL.Begin(BeginMode.Triangles);

            helper_leafs();

            GL.End();
            GL.PopMatrix();
            #endregion

            #region Leaf-set 5
            GL.PushMatrix();
            GL.Translate(10.0, 19.0, -20.0);
            GL.Scale(0.3, 0.8, 0.3);
            GL.Begin(BeginMode.Triangles);

            helper_leafs();

            GL.End();
            GL.PopMatrix();
            #endregion

            #region Leaf-set 6
            GL.PushMatrix();
            GL.Translate(15.0, 19.0, -20.0);
            GL.Rotate(45, 0.0, 1.0, 0.0);
            GL.Scale(0.3, 0.8, 0.3);
            GL.Begin(BeginMode.Triangles);

            helper_leafs();

            GL.End();
            GL.PopMatrix();
            #endregion
        }

        void helper_leafs()
        {
            #region Pyramid
            //Front
            GL.Color3(0.3, 0.52, 0.27);
            GL.Vertex3(10.0, 10.0, -30.0);     //peak
            GL.Vertex3(-110.0, 0.0, 90.0);     //leftside
            GL.Vertex3(130.0, 0.0, 90.0);      //rightside

            //Back
            GL.Color3(0.3, 0.52, 0.27);
            GL.Vertex3(10.0, 10.0, -30.0);     //peak
            GL.Vertex3(-110.0, 0.0, -150.0);   //leftside
            GL.Vertex3(130.0, 0.0, -150.0);    //rightside

            //Left
            GL.Color3(0.32, 0.555, 0.20);
            GL.Vertex3(10.0, 10.0, -30.0);      //peak
            GL.Vertex3(-110.0, 0.0, 90.0);      //leftside
            GL.Vertex3(-110.0, 0.0, -150.0);    //rightside

            //Right
            GL.Color3(0.32, 0.555, 0.20);
            GL.Vertex3(10.0, 10.0, -30.0);      //peak
            GL.Vertex3(130.0, 0.0, 90.0);       //leftside
            GL.Vertex3(130.0, 0.0, -150.0);     //rightside
            #endregion
        }
