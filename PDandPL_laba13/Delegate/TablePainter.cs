using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDandPL.Delegate
{
    public class TablePainter
    {
        public TablePainter()
        {
            
        }
        int a;
        int b;
        List<double> listAtoB = new List<double>() { 0,0.57,0.78,1.5, 3.14, 4.71 ,6.28};
        public double[,] SinTable()
        {
            double[,] sinTable = new double[2, listAtoB.Count];
            for(int i = 0; i < sinTable.GetLength(1); i++)
            {
                sinTable[0, i] = listAtoB[i];
            }
            for (int j = 0; j < sinTable.GetLength(1); j++)
            {
                sinTable[1, j] = Math.Sin(sinTable[0,j]);
            }
            return sinTable;
        }
        public double[,] SinAndCosTable()
        {
            double[,]  Table = new double[2, listAtoB.Count];
            for (int i = 0; i < Table.GetLength(1); i++)
            {
                Table[0, i] = listAtoB[i];
            }
            for (int j = 0; j < Table.GetLength(1); j++)
            {
                Table[1, j] = Math.Pow(Math.Sin(Table[0, j]), 2) + Math.Pow(Math.Cos(Table[0, j]), 2);
                
            }
            return Table;
        }
        public double[,] OneDelX()
        {
            double[,] Table = new double[2, listAtoB.Count];
            for (int i = 0; i < Table.GetLength(1); i++)
            {
                Table[0, i] = listAtoB[i];
            }
            for (int j = 0; j < Table.GetLength(1); j++)
            {
                if(Table[0, j] == 0)
                {
                    continue;
                }
                Table[1, j] = 1 / Table[0, j];
            }
            return Table;
        }
    }
}
