using System;
using System.Collections.Generic;

namespace SolutionTriplets
{
    public class Solution
    {
        public int FindTriplets(int[] matriz)
        {
            int numeroTripletas = 0;

            if ((matriz.Length / 3) >= 1)
            {
                for (int posicionPibot = 0; posicionPibot < matriz.Length; posicionPibot++)
                {
                    if (posicionPibot < matriz.Length && (posicionPibot + 1) < matriz.Length && (posicionPibot + 2) < matriz.Length)
                    {
                        if (matriz[posicionPibot] == matriz[posicionPibot + 1] && matriz[posicionPibot + 1] == matriz[posicionPibot + 2])
                        {
                            numeroTripletas++;
                            posicionPibot = posicionPibot + 2;
                        }
                    }
                }
            }

            return numeroTripletas;
        }
    }
}
