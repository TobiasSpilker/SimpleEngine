using System;
using OpenTK;
using OpenTK.Input;
using OpenTK.Graphics.OpenGL;
using System.Drawing;

namespace SimpleEngine
{
    public partial class game
    {
        //Public so other stuff can acces it (map for example)
        public double theta_X_rad;
        public double theta_Z_rad;
        void updateF(object o, EventArgs e)
        //Checks key states and updates theta values to shift players location
        {
            //Keyboard object
            KeyboardState k = Keyboard.GetState();

            #region Head movement       
            //Setting rotation based on mouse "shift" and sensitivity [0-1]
            theta_XZ = Mouse.GetState().X / (1 / Sensitivity);
            
            //Setting rotation based on shift, sensitivity and if it is not to far down [RESTRICTIONS]
            if (Mouse.GetState().Y / (1 / Sensitivity) <= 90)
            {
                //Checking if it is not to far up (rotation)
                if (Mouse.GetState().Y / (1 / Sensitivity) >= -90)
                {
                    theta_Y = Mouse.GetState().Y / (1 / Sensitivity);
                }
                else //Sets it slightly "back" so player wont be locked up
                {
                    theta_Y = -90;
                }
            }
            else //Sets it slightly "back" so player wont be locked down
            {
                theta_Y = 90;
            }

            // Calculate the middle of the display:
            var primaryDisplay = DisplayDevice.GetDisplay(DisplayIndex.Primary).Bounds; //This gets done
            int displayMiddleX = primaryDisplay.Width / 2; //here on purpose because the size of the
            int displayMiddleY = primaryDisplay.Height / 2; //screen can change per situation       

            if (true) //Should later check because sometimes mouse should be freed (inventory)
            {
                Mouse.SetPosition(displayMiddleX - 12, displayMiddleY - 30);
                window.CursorVisible = false;
                //Makes it easier to detect if player is looking at an object (corrosponds to mouse
                //location)
            }
            #endregion

            #region Walk speed
            double Walkspeed = 0.5; //General walk speed

            //Making sure speed does not get doubled when going diagonal
            if (k.IsKeyDown(Key.W) && k.IsKeyDown(Key.D) ||
                k.IsKeyDown(Key.W) && k.IsKeyDown(Key.A) ||
                k.IsKeyDown(Key.S) && k.IsKeyDown(Key.D) ||
                k.IsKeyDown(Key.S) && k.IsKeyDown(Key.A))
            {
                Walkspeed = 0.4;
            }

            //Sprint option:
            if (k.IsKeyDown(Key.ShiftLeft) && k.IsKeyDown(Key.W))
            {
                Walkspeed = 0.8;
            }
            #endregion

            #region Moving

            if (k.IsKeyDown(Key.W) && Collision(beta_X, beta_Z))
            {
                // Convert theta_R from degrees to radians
                double theta_R_rad = (theta_XZ + 90)* Math.PI / 180.0;

                // Calculate the X and Z components of the movement vector using trigonometry
                theta_X_rad = Math.Atan2(Math.Sin(theta_R_rad), Math.Cos(theta_R_rad));
                theta_Z_rad = Math.Atan2(Math.Cos(theta_R_rad), Math.Sin(theta_R_rad));

                double move_X = Walkspeed * Math.Cos(theta_X_rad);
                double move_Z = Walkspeed * Math.Cos(theta_Z_rad);

                // Update the player's position based on the calculated movement vector
                beta_X += move_X;
                beta_Z += move_Z;
            }       

            if (k.IsKeyDown(Key.S) && Collision(beta_X, beta_Z))
            {
                // Convert theta_R from degrees to radians
                double theta_R_rad = (theta_XZ - 90) * Math.PI / 180.0;

                // Calculate the X and Z components of the movement vector using trigonometry
                double theta_X_rad = Math.Atan2(Math.Sin(theta_R_rad), Math.Cos(theta_R_rad));
                double theta_Z_rad = Math.Atan2(Math.Cos(theta_R_rad), Math.Sin(theta_R_rad));

                double move_X = Walkspeed * Math.Cos(theta_X_rad);
                double move_Z = Walkspeed * Math.Cos(theta_Z_rad);

                // Update the player's position based on the calculated movement vector
                beta_X += move_X;
                beta_Z += move_Z;
            }

            if (k.IsKeyDown(Key.A) && Collision(beta_X, beta_Z))
            {
                // Convert theta_R from degrees to radians
                double theta_R_rad = (theta_XZ) * Math.PI / 180.0;

                // Calculate the X and Z components of the movement vector using trigonometry
                double theta_X_rad = Math.Atan2(Math.Sin(theta_R_rad), Math.Cos(theta_R_rad));
                double theta_Z_rad = Math.Atan2(Math.Cos(theta_R_rad), Math.Sin(theta_R_rad));

                double move_X = Walkspeed * Math.Cos(theta_X_rad);
                double move_Z = Walkspeed * Math.Cos(theta_Z_rad);

                // Update the player's position based on the calculated movement vector
                beta_X += move_X;
                beta_Z += move_Z;
            }

            if (k.IsKeyDown(Key.D) && Collision(beta_X, beta_Z))
            {
                // Convert theta_R from degrees to radians
                double theta_R_rad = (theta_XZ + 180) * Math.PI / 180.0;

                // Calculate the X and Z components of the movement vector using trigonometry
                double theta_X_rad = Math.Atan2(Math.Sin(theta_R_rad), Math.Cos(theta_R_rad));
                double theta_Z_rad = Math.Atan2(Math.Cos(theta_R_rad), Math.Sin(theta_R_rad));

                double move_X = Walkspeed * Math.Cos(theta_X_rad);
                double move_Z = Walkspeed * Math.Cos(theta_Z_rad);

                // Update the player's position based on the calculated movement vector
                beta_X += move_X;
                beta_Z += move_Z;
            }
            #endregion

            //Quick exit, should be implemented in menu later on:
            if (k.IsKeyDown(Key.Escape) == true) {window.Close();}
        }

        public bool Collision(double x, double z)
        {
            //for tree that is on the same tile as the player (1 hitbox at a time)
            //if x or z close to object then false
                //using type of tree {0, 90...} en drawing simple box
            //else true

            return true;
        }

        void Transform_World()
        //AKA moving the player "through" the world
        {
            #region Body
            GL.Translate(beta_X, beta_Y, beta_Z); //moving "through" the world
            GL.Rotate(0.0, 0.0, 0.0, 0.0);
            GL.Scale(1.0, 1.0, 1.0);
            #endregion
        }
    }
}
