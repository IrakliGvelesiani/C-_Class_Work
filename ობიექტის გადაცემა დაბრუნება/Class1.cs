using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ობიექტის_გადაცემა_დაბრუნება
{
    class Class1
    {
        private int[,] masivi_1;
        private int jami_luwi;
        public Class1(int [,] masivi_1)
        {
            this.masivi_1 = masivi_1;
        }
        public int Jami(Class1 obj_par)
        {
            jami_luwi = 0;
            for (int str = 0; str < masivi_1.GetLength(0); str++)
                for (int sv = 0; sv < masivi_1.GetLength(1); sv++)
                    if (obj_par.masivi_1[str, sv] % 2 == 0) jami_luwi += obj_par.masivi_1[str, sv];
            return jami_luwi;
        }
    }
}
