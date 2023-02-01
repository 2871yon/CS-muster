using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_muster
{
    internal class Meet1_delegate
    {//delegate
        // פונקציה שמקבלת פונקציה כפרמטר 
        // אין לה גוף זה מצביע לפונקציה לפי החתימה של הפונקציה
        // ועושה הגדרה לפונקציה
        //הגדרה של חתימת פונקציה ניתן ליצור משתנים שיצביעו על הפונקציה רלוונטית רק לפי התאמת החתימה החתימה 
        //ולהעביר כפרמטרים כל פעם פונקציה שונה ובתנאי שיתאים לחתימה

        public void Run()
        {
            CalcFunc f;
            f = Calc;
            f(4, 4);
            int r=f(4, 4);

            CalcTax(200, Calc);

        }

        public  delegate int CalcFunc(int a, int b);

        public int Calc(int a, int b)
        {
            return a*b;
        }

        public int Calc1(int a, int b)
        {
            return a / b;
        }

        public int CalcTax(int price,CalcFunc func)
        {
            return (func(price, 20));
        } 
    }
}
