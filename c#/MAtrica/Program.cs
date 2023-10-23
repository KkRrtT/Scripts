namespace MAtrica
{
    internal class SurroundSquares
    {
        static void Main(string[] args)
        {
            #region Ma3ca
            void MatrixCalc()
            {
                #region Inputs

                var row = Console.ReadLine();
                int rowInt = Convert.ToInt32(row);

                var collum = Console.ReadLine();
                int collumInt = Convert.ToInt32(collum);

                #endregion


                #region Field Calculations

                int[,] fields = new int[4, 2];

                fields[0, 0] = rowInt - 1;
                fields[0, 1] = collumInt;

                fields[1, 0] = rowInt + 1;
                fields[1, 1] = collumInt;

                fields[2, 0] = rowInt;
                fields[2, 1] = collumInt + 1;

                fields[3, 0] = rowInt;
                fields[3, 1] = collumInt - 1;

                #endregion


                Console.WriteLine($"Deploy at : " +
                    $"\n {fields[0, 0]}, {fields[0, 1]}" +
                    $"\n {fields[1, 0]}, {fields[1, 1]}" +
                    $"\n {fields[2, 0]}, {fields[2, 1]}" +
                    $"\n {fields[3, 0]}, {fields[3, 1]}");

            }
            MatrixCalc();
            #endregion

            #region Clock Bool
            bool Clock()
            {
                var input = Console.Read();
                int inputInt = Convert.ToInt32(input);

                if ((inputInt % 2) != 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            void ClockMethod()
            {
                if (Clock()) Console.WriteLine("Tick");
                else Console.WriteLine("Tock");
            }
            ClockMethod();
            #endregion

            #region Improved Clock

            void ClockImproved() 
            {
                var input = Console.ReadLine();
                int inputInt = Convert.ToInt32(input);

                bool tickTock = inputInt % 2 == 0;
                string displayText = tickTock ? "parni" : "neparni";

                Console.WriteLine(displayText);
                
            }

            ClockImproved();

            #endregion
        }
    }
}