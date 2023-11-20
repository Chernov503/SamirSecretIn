using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Numerics;

namespace WindowsFormsApp2
{
    class Lagrange
    {
        BigInteger[,] arr;
        public Lagrange(DataGridView d)
        {
            arr = new BigInteger[d.RowCount, d.ColumnCount];
            CopyDToArray(d);

        }
        void CopyDToArray(DataGridView d)
        {
            for(int i = 0; i < d.ColumnCount; i++)
            {
                for(int j = 0; j < d.RowCount; j++)
                {
                    arr[j, i] = BigInteger.Parse(d.Rows[j].Cells[i].Value.ToString());
                }
            }
        }

        decimal Calculatel(int n)
        {
            decimal l = 1;
            for(int i =0; i < arr.GetLength(0); i++)
            {
                if (i == n) continue;

                l *= (0 - ((decimal)arr[i, 0])) / ((decimal)arr[n, 0] - (decimal)arr[i, 0]);
            }
            l *= (decimal)arr[n, 1];
            return l;
        }
        public decimal ReturnSecret()
        {
            decimal secret = 0;
            for(int i = 0; i < arr.GetLength(0);i++)
            {
                secret += Calculatel(i);
            }
            return secret;
        }
    }
}
