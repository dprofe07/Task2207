using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2207 {
    class LevDistance {
        public static int count(string a, string b) {
            if (a == "") return b.Length;
            if (b == "") return a.Length;

            int[,] D = new int[a.Length, b.Length];
            for (int i = 0; i < a.Length; i++) {
                for (int j = 0; j < b.Length; j++) {
                    if (i == 0 || j == 0)
                        D[i, j] = i + j;
                    else
                        D[i, j] = Math.Min(D[i, j - 1] + 1, Math.Min(D[i - 1, j] + 1, D[i - 1, j - 1] + (a[i] == b[j] ? 0 : 1)));
                }
            }
            return D[a.Length - 1, b.Length - 1];
        }
    }
}
