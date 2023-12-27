using System;
using System.Linq;
using System.Runtime.CompilerServices;

namespace PersistentDarnDarnDarn
{
    public class Matrix
    {
        public double[,] _matrix { get; set; }
        public double _strings { get; set; }
        public double _columns { get; set; }
        public double _mult { get; set; }
    

        public void MatrixMultiplyer()
        {
            this._mult = Convert.ToDouble(Console.ReadLine());
            _mult = this._mult;
            for (int i = 0; i < _strings; i++)
            {
                for (int j = 0; j < _columns; j++)
                {
                    _matrix[i, j] = _mult * _matrix[i, j];
                }
            }
        }
        

        public void ReadSize()
        {
            double[] sized = Console.ReadLine().Split(' ').Select(Convert.ToDouble).ToArray();
            _strings = sized[0];
            _columns = sized[1];
        }

        public void CreateMatrix()
        {
            int strings = (int)_strings;
            int columns = (int)_columns;

            double[,]matrix = new double[strings,columns];
            _matrix = matrix;
        }

        public void ReadMatrix()
        {
            this._columns = Convert.ToInt32(_columns);
            this._strings = Convert.ToInt32(_strings);

            for (int i = 0; i < _strings; i++)
            {
                int[] strings = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                double[] dstrings = new double[strings.Length];
                for (int j = 0; j < strings.Length; j++)
                {
                    dstrings[j] = Convert.ToDouble(strings[j]);
                }

                for (int e = 0; e < this._columns; e++)
                {
                    _matrix[i, e] = dstrings[e];
                }
            }
        }

        public void Write()
        {
            this._strings = Convert.ToInt32(_strings);
            this._columns = Convert.ToInt32(_columns);
            for (int i = 0; i < _strings; i++)
            {
                for (int j = 0; j < _columns; j++)
                {
                    Console.Write($"{_matrix[i,j]} ");
                }

                Console.WriteLine();
            }
        }
        
    }
    
    internal class Program
    {
        public static void Main(string[] args)
        {
            var A = new Matrix();
            A.ReadSize();
            A.CreateMatrix();
            A.ReadMatrix();
            A.MatrixMultiplyer();
            A.Write();
        }
    }
}