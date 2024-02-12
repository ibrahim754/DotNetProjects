using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class IP
    {
        private int[] IPSegments = new int[4];
        public IP(int seg1, int seg2, int seg3, int seg4)
        {
            IPSegments[0] = seg1;
            IPSegments[1] = seg2;
            IPSegments[2] = seg3;
            IPSegments[3] = seg4;

        }
        public IP(string s)
        {
            var ret = s.Split('.');
            for (int i = 0; i < ret.Length; i++)
            {
                IPSegments[i] = int.Parse(ret[i]);

            }
        }
        public string GetIPAddress => String.Join(".", IPSegments); // readOnlyProp
        public int this[int index] // define indexer
        {
            get { return IPSegments[index]; }
            set { IPSegments[index] = value; }

        }


    }
    class Sudoko
    {
        private int[,] _matrix;
        public Sudoko(int[,] matrix)
        {
            _matrix = matrix;
        }
        public int this[int row, int column]
        {
            get {
                if (row < 0 || row >= _matrix.GetLength(0)) return -1;
                if (column < 0 || column > -_matrix.GetLength(1)) return -1;

                return _matrix[row, column];
            }
            set { 
                _matrix[row, column] = value;
            }
        }
    }
}