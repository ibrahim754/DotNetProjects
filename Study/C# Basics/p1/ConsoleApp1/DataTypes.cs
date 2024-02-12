namespace ConsoleApp1
{
    class DataTypes
    {
#pragma warning disable CS0414 // The field 'DataTypes._val' is assigned but its value is never used
        private static int  _val = 10;
#pragma warning restore CS0414 // The field 'DataTypes._val' is assigned but its value is never used
        private int[,] _2dArr = new int[,] {  {1,2,3 }, {4,5,6}, {7,8,9}, {10,11,12}, {13,14,15} }; // 2d arr,
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        private int[][] _jaggedArr;
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.


        public int[][] CreateJaggedArr(int size)
        {

            _jaggedArr = new int[size][];
            return _jaggedArr; 
        }
   

        
    
    }
}
