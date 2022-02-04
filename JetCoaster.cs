using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JET
{
    public class JetCoaster
    {
        public static int ride
            (int k, int[]g,int r)
        {
        
            int n = k;  //計算用の定員の変数
            int u = 0;  //配列用の定数
            int l = 0;  //二重にグループを数えないための変数
            int a = 0;  //リターン用の変数

            for(int i =1; i <= r; i++)
            {
                k = n;
                l = 0;
                while (0 <= k - g[u]) 
                {
                    if (l == g.Length)//二重に数えてないか判別
                    {
                        break;
                    }
                    k = k - g[u];
                    a = a + g[u];
                    u++;
                    l++;
                    
                    if (u == g.Length)
                    {
                        u = 0;
                    }
               
                }

            }return a;
        }
    }
}