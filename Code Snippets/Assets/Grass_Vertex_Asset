        void Draw_Grass()
        {
            #region Bundle grass blades 1
            GL.PushMatrix();
            GL.Translate(-5.0, 0.0, -5.0);
            GL.Rotate(0.0, 0.0, 0.0, 0.0);
            GL.Scale(0.3, 0.2, 0.3);
            Draw_Blade();
            GL.PopMatrix();

            GL.PushMatrix();
            GL.Translate(-6.0, 0.0, -5.5);
            GL.Rotate(20.0, 0.0, 1.0, 0.0);
            GL.Scale(0.3, 0.2, 0.3);
            Draw_Blade();
            GL.PopMatrix();

            GL.PushMatrix();
            GL.Translate(-5.5, 0.0, -6.5);
            GL.Rotate(45.0, 0.0, 1.0, 0.0);
            GL.Scale(0.3, 0.2, 0.3);
            Draw_Blade();
            GL.PopMatrix();
            #endregion

            #region Bundle grass blades 2
            GL.PushMatrix();
            GL.Translate(0.0, 0.0, 0.0);
            GL.Rotate(0.0, 0.0, 0.0, 0.0);
            GL.Scale(0.3, 0.2, 0.3);
            Draw_Blade();
            GL.PopMatrix();

            GL.PushMatrix();
            GL.Translate(-1.0, 0.0, -0.5);
            GL.Rotate(40.0, 0.0, 1.0, 0.0);
            GL.Scale(0.3, 0.2, 0.3);
            Draw_Blade();
            GL.PopMatrix();

            GL.PushMatrix();
            GL.Translate(-0.5, 0.0, -1.5);
            GL.Rotate(65.0, 0.0, 1.0, 0.0);
            GL.Scale(0.3, 0.2, 0.3);
            Draw_Blade();
            GL.PopMatrix();
            #endregion

            #region Bundle grass blades 3
            GL.PushMatrix();
            GL.Translate(-6.0, 0.0, 2.0);
            GL.Rotate(0.0, 0.0, 0.0, 0.0);
            GL.Scale(0.3, 0.2, 0.3);
            Draw_Blade();
            GL.PopMatrix();

            GL.PushMatrix();
            GL.Translate(-7.0, 0.0, 1.5);
            GL.Rotate(60.0, 0.0, 1.0, 0.0);
            GL.Scale(0.3, 0.2, 0.3);
            Draw_Blade();
            GL.PopMatrix();

            GL.PushMatrix();
            GL.Translate(-7.5, 0.0, 0.5);
            GL.Rotate(85.0, 0.0, 1.0, 0.0);
            GL.Scale(0.3, 0.2, 0.3);
            Draw_Blade();
            GL.PopMatrix();
            #endregion

            #region Bundle grass blades 4
            GL.PushMatrix();
            GL.Translate(5.0, 0.0, 5.0);
            GL.Rotate(0.0, 0.0, 0.0, 0.0);
            GL.Scale(0.3, 0.2, 0.3);
            Draw_Blade();
            GL.PopMatrix();

            GL.PushMatrix();
            GL.Translate(5.5, 0.0, 6.5);
            GL.Rotate(60.0, 0.0, 1.0, 0.0);
            GL.Scale(0.3, 0.2, 0.3);
            Draw_Blade();
            GL.PopMatrix();

            GL.PushMatrix();
            GL.Translate(6.5, 0.0, 5.5);
            GL.Rotate(85.0, 0.0, 1.0, 0.0);
            GL.Scale(0.3, 0.2, 0.3);
            Draw_Blade();
            GL.PopMatrix();
            #endregion

            #region Bundle grass blades 5
            GL.PushMatrix();
            GL.Translate(5.0, 0.0, -5.0);
            GL.Rotate(0.0, 0.0, 0.0, 0.0);
            GL.Scale(0.3, 0.2, 0.3);
            Draw_Blade();
            GL.PopMatrix();

            GL.PushMatrix();
            GL.Translate(5.5, 0.0, -6.5);
            GL.Rotate(20.0, 0.0, 1.0, 0.0);
            GL.Scale(0.3, 0.2, 0.3);
            Draw_Blade();
            GL.PopMatrix();

            GL.PushMatrix();
            GL.Translate(6.5, 0.0, -5.5);
            GL.Rotate(35.0, 0.0, 1.0, 0.0);
            GL.Scale(0.3, 0.2, 0.3);
            Draw_Blade();
            GL.PopMatrix();
            #endregion

        }

        void Draw_Blade()
        {
            #region Quads
            //BACKSIDE:
            GL.Begin(BeginMode.Quads);
            GL.Color3(0.28, 0.5, 0.25);
            GL.Vertex3(0.0, 0.0, 0.0);
            GL.Vertex3(1.0, 0.0, 0.0);
            GL.Vertex3(0.6, 5.0, 0.4);
            GL.Vertex3(0.4, 5.0, 0.4);

            //LEFTSIDE:
            GL.Color3(0.2, 0.4, 0.2);
            GL.Vertex3(0.0, 0.0, 0.0);
            GL.Vertex3(0.0, 0.0, 1.0);
            GL.Vertex3(0.4, 5.0, 0.6);
            GL.Vertex3(0.4, 5.0, 0.4);

            //RIGHTSIDE:
            GL.Color3(0.24, 0.45, 0.3);
            GL.Vertex3(1.0, 0.0, 0.0);
            GL.Vertex3(1.0, 0.0, 1.0);
            GL.Vertex3(0.6, 5.0, 0.6);
            GL.Vertex3(0.6, 5.0, 0.4);

            //FRONTSIDE:
            GL.Color3(0.2, 0.5, 0.2);
            GL.Vertex3(0.0, 0.0, 1.0);
            GL.Vertex3(1.0, 0.0, 1.0);
            GL.Vertex3(0.6, 5.0, 0.6);
            GL.Vertex3(0.4, 5.0, 0.6);

            //TOP:
            GL.Color3(0.25, 0.4, 0.2);
            GL.Vertex3(0.4, 5, 0.6);
            GL.Vertex3(0.6, 5, 0.6);
            GL.Vertex3(0.6, 5, 0.4);
            GL.Vertex3(0.4, 5, 0.4);
            GL.End();
            #endregion
        }        void Draw_Grass()
        {
            #region Bundle grass blades 1
            GL.PushMatrix();
            GL.Translate(-5.0, 0.0, -5.0);
            GL.Rotate(0.0, 0.0, 0.0, 0.0);
            GL.Scale(0.3, 0.2, 0.3);
            Draw_Blade();
            GL.PopMatrix();

            GL.PushMatrix();
            GL.Translate(-6.0, 0.0, -5.5);
            GL.Rotate(20.0, 0.0, 1.0, 0.0);
            GL.Scale(0.3, 0.2, 0.3);
            Draw_Blade();
            GL.PopMatrix();

            GL.PushMatrix();
            GL.Translate(-5.5, 0.0, -6.5);
            GL.Rotate(45.0, 0.0, 1.0, 0.0);
            GL.Scale(0.3, 0.2, 0.3);
            Draw_Blade();
            GL.PopMatrix();
            #endregion

            #region Bundle grass blades 2
            GL.PushMatrix();
            GL.Translate(0.0, 0.0, 0.0);
            GL.Rotate(0.0, 0.0, 0.0, 0.0);
            GL.Scale(0.3, 0.2, 0.3);
            Draw_Blade();
            GL.PopMatrix();

            GL.PushMatrix();
            GL.Translate(-1.0, 0.0, -0.5);
            GL.Rotate(40.0, 0.0, 1.0, 0.0);
            GL.Scale(0.3, 0.2, 0.3);
            Draw_Blade();
            GL.PopMatrix();

            GL.PushMatrix();
            GL.Translate(-0.5, 0.0, -1.5);
            GL.Rotate(65.0, 0.0, 1.0, 0.0);
            GL.Scale(0.3, 0.2, 0.3);
            Draw_Blade();
            GL.PopMatrix();
            #endregion

            #region Bundle grass blades 3
            GL.PushMatrix();
            GL.Translate(-6.0, 0.0, 2.0);
            GL.Rotate(0.0, 0.0, 0.0, 0.0);
            GL.Scale(0.3, 0.2, 0.3);
            Draw_Blade();
            GL.PopMatrix();

            GL.PushMatrix();
            GL.Translate(-7.0, 0.0, 1.5);
            GL.Rotate(60.0, 0.0, 1.0, 0.0);
            GL.Scale(0.3, 0.2, 0.3);
            Draw_Blade();
            GL.PopMatrix();

            GL.PushMatrix();
            GL.Translate(-7.5, 0.0, 0.5);
            GL.Rotate(85.0, 0.0, 1.0, 0.0);
            GL.Scale(0.3, 0.2, 0.3);
            Draw_Blade();
            GL.PopMatrix();
            #endregion

            #region Bundle grass blades 4
            GL.PushMatrix();
            GL.Translate(5.0, 0.0, 5.0);
            GL.Rotate(0.0, 0.0, 0.0, 0.0);
            GL.Scale(0.3, 0.2, 0.3);
            Draw_Blade();
            GL.PopMatrix();

            GL.PushMatrix();
            GL.Translate(5.5, 0.0, 6.5);
            GL.Rotate(60.0, 0.0, 1.0, 0.0);
            GL.Scale(0.3, 0.2, 0.3);
            Draw_Blade();
            GL.PopMatrix();

            GL.PushMatrix();
            GL.Translate(6.5, 0.0, 5.5);
            GL.Rotate(85.0, 0.0, 1.0, 0.0);
            GL.Scale(0.3, 0.2, 0.3);
            Draw_Blade();
            GL.PopMatrix();
            #endregion

            #region Bundle grass blades 5
            GL.PushMatrix();
            GL.Translate(5.0, 0.0, -5.0);
            GL.Rotate(0.0, 0.0, 0.0, 0.0);
            GL.Scale(0.3, 0.2, 0.3);
            Draw_Blade();
            GL.PopMatrix();

            GL.PushMatrix();
            GL.Translate(5.5, 0.0, -6.5);
            GL.Rotate(20.0, 0.0, 1.0, 0.0);
            GL.Scale(0.3, 0.2, 0.3);
            Draw_Blade();
            GL.PopMatrix();

            GL.PushMatrix();
            GL.Translate(6.5, 0.0, -5.5);
            GL.Rotate(35.0, 0.0, 1.0, 0.0);
            GL.Scale(0.3, 0.2, 0.3);
            Draw_Blade();
            GL.PopMatrix();
            #endregion

        }

        void Draw_Blade()
        {
            #region Quads
            //BACKSIDE:
            GL.Begin(BeginMode.Quads);
            GL.Color3(0.28, 0.5, 0.25);
            GL.Vertex3(0.0, 0.0, 0.0);
            GL.Vertex3(1.0, 0.0, 0.0);
            GL.Vertex3(0.6, 5.0, 0.4);
            GL.Vertex3(0.4, 5.0, 0.4);

            //LEFTSIDE:
            GL.Color3(0.2, 0.4, 0.2);
            GL.Vertex3(0.0, 0.0, 0.0);
            GL.Vertex3(0.0, 0.0, 1.0);
            GL.Vertex3(0.4, 5.0, 0.6);
            GL.Vertex3(0.4, 5.0, 0.4);

            //RIGHTSIDE:
            GL.Color3(0.24, 0.45, 0.3);
            GL.Vertex3(1.0, 0.0, 0.0);
            GL.Vertex3(1.0, 0.0, 1.0);
            GL.Vertex3(0.6, 5.0, 0.6);
            GL.Vertex3(0.6, 5.0, 0.4);

            //FRONTSIDE:
            GL.Color3(0.2, 0.5, 0.2);
            GL.Vertex3(0.0, 0.0, 1.0);
            GL.Vertex3(1.0, 0.0, 1.0);
            GL.Vertex3(0.6, 5.0, 0.6);
            GL.Vertex3(0.4, 5.0, 0.6);

            //TOP:
            GL.Color3(0.25, 0.4, 0.2);
            GL.Vertex3(0.4, 5, 0.6);
            GL.Vertex3(0.6, 5, 0.6);
            GL.Vertex3(0.6, 5, 0.4);
            GL.Vertex3(0.4, 5, 0.4);
            GL.End();
            #endregion
        }
