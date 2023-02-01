using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_muster
{   //טפל:
    //אוסף של משתנים שאפשר להעביר אותם כמו פרמטר אחד
    internal class Meet1_Tuple
    {
        public void Run()
        {
            int id;
            string name;
            (int id, string fname, string lname) var1;
            var1 = (246, "david", "lavin");
             
            var newPerson=CreatePerson();
        }

        //בעזרת טפל אפשר להחזיר יותר ממשתנה אחד מפונקציה 
        //ומשתמשים כאשר רוצים לעשות מבנה אבל לא קבוע סוג של חד פעמי כזה
        public (int id, string fname, string lname) CreatePerson()
        {
            int id = 246;
            string fname = "david";
            string lname = "lavin";
            (int id, string fname, string lname) var1 = (246,fname ,lname);
            var1.id = id;
            return var1;
        }
    }
}
 