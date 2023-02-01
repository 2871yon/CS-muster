using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_muster
{
    internal class Meet1_Events
    {
        //מנגנון הפצת ההודעות של כי שארפ
        //במקום שהביזנס לייר יקרא לפונקציות יש מנגנון להפצת הודעות
        //
        //
        //

        public delegate void TImeOut_func(int time);
        public event TImeOut_func TImeOut_handler; 
        public void run()
        {
            //broadcact events to all listeners
            TImeOut_handler(1200);
        }

        public class Operate
        {
            Meet1_Events meet1_Events=new Meet1_Events();    
            DB db=new DB();
            UI ui=new UI(); 
            public void Init()
            {
                meet1_Events.TImeOut_handler += db.updateDBAfterTimeOut;
                meet1_Events.TImeOut_handler+=ui.updateUIAfterTimeOut;

                //unregister from broadcast list
                meet1_Events.TImeOut_handler -= db.updateDBAfterTimeOut; 
            }
        }
       public class DB
        {
            public void updateDBAfterTimeOut(int time)
            {

            }
        }
        
        public class UI
        {
            public void updateUIAfterTimeOut(int time)
            {

            }
        }
    }

}
