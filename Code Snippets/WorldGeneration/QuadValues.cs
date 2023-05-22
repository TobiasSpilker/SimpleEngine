        public void Generate_World_Data()
        //Setting the size of the array and filling it
        {
            //Variables:
            QuadValues = new string[WorldSize, WorldSize];
            Random r = new Random();
            List<string> Asset_P = Helper_Probability();

            //Algorithm:
            for (int i = 0; i < WorldSize; i++)
            {
                for (int j = 0; j < WorldSize; j++)
                {
                    #region Filling array with random types
                    int type_int = r.Next(1, Asset_P.Count());
                    string type_string = Asset_P[type_int];
                    QuadValues[i, j] = type_string;
                    #endregion
                }
            }
        }

        List<string> Helper_Probability()
        //Returns a % of a given asset or something in a list???
        {
            //List to store all the items:
            List<string> Asset_P = new List<string>();

            //List with assets and their respective probability (in percentile!):
            List<(string, int)> Assets = new List<(string, int)> 
            {("empty", 500), 
             ("pine tree 0", 50), ("pine tree 90", 50), ("pine tree 180", 50), ("pine tree 270", 50),
             ("rocks 0", 20), ("rocks 90", 20), ("rocks 180", 20), ("rocks 270", 20),
             ("grass 0", 30), ("grass 90", 30), ("grass 180", 30), ("grass 270", 30)};

            for (int i = 0; i < Assets.Count; i++)
            {
                //Keep looping till it is looped x amount of times corresponding to number:
                for (int j = 0; j < Assets[i].Item2; j++)
                {
                    //Adding the appropiate string to the new list:
                    Asset_P.Add(Assets[i].Item1);
                }
            }

            //Returning the filled list:
            return Asset_P;
        }
