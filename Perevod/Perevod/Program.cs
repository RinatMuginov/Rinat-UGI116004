using System;
using System.Collections.Generic;

namespace PErevod
{
    class Program
    {
        static void Main()
        {
            int ret;
            ret = PathFinder(2, 3, 0);
        }
        static int PathFinder(int startpoint, int endpoint, int prevpoint)
        {
            int[] path = new int[10];
            int[][] PathPoints = new int[4][];
            PathPoints[0] = new int[] { 2 };
            PathPoints[1] = new int[] { 1, 3 };
            PathPoints[2] = new int[] { 2, 4 };
            PathPoints[3] = new int[] { 3 };
            int flag = 0;
            int ret, k = 0;
            for (int j = startpoint; j < PathPoints.Length; j++)
            {
                for (int i = 0; i < PathPoints[j].Length; i++)
                {
                    if (PathPoints[j][i] == endpoint)
                    {
                        path[k] = j;
                        k++;
                    }
                    if (PathPoints[j][i] != 0)
                    {
                        ret = PathFinder(i, endpoint, startpoint);
                        if (ret > 0)
                        {
                            path[k] = j;
                            k++;

                        }
                    }
                }
            }
            return 5555;
        }



    }
}