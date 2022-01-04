
using Array;
class Program { 
    static void Main(string[] args)
    {
        #region[Generic Input Area]
        int[] arr = { 1, 2, 3, 4, 5, 6, 7 };
        int d = 2;
        int n = 7;
        #endregion

        #region [1- Program for array rotation]
        Print("1- Array Rotation using temp variable: \n");
        ArrayRotation.usingTempVariable(arr, d, n);
        #endregion

        #region [2- Reversal algorithm for array rotation]
        Print("2- Array rotation using array reverse logic \n");
        ArrayRotation.usingArrayReverse(arr, d, n);
        //ArrayRotateUsingReverse.reverseArray(); //Testing code
        #endregion


    }
    #region [Generic Code snippet]
    static void Print(string s)
    {
        Console.BackgroundColor = ConsoleColor.White;
        Console.ForegroundColor = ConsoleColor.Black;
        Console.WriteLine(s);
        Console.BackgroundColor = ConsoleColor.Black;
        Console.ForegroundColor = ConsoleColor.White;
    }
    #endregion
}



