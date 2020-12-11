using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR8
{
    class Program
    {
        static void Main(string[] args)
        {
            TaskFactory tf = new TaskFactory();
            Task t1 = tf.StartNew(TransfMatr);

            Console.ReadKey();
        }

        public static void TransfMatr()
        {
            Random rand = new Random();
            double[,] arr = new double[6, 6];

            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    arr[i, j] = rand.Next(0, 10);
                }
            }

            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    Console.Write(arr[i, j] + " ");
                }
                Console.Write("\n");
            }

            Console.WriteLine("Выполнение задачи {0}", Task.CurrentId);

            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    double a = Math.Sin(arr[i, j]);
                    arr[i, j] = a;
                }
            }
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    Console.Write(arr[i, j] + " ");
                }
                Console.Write("\n");
            }

        }
    }
}

