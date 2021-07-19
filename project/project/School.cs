using System;
using System.Collections.Generic;
using System.Text;

namespace project
{
    class School
    {
        public int ID { get; set; }
        public String Class{ get; set; }
        public String  Section { get; set; }

        public School (int Id,String c , String s)
        {
            this.ID = Id;
            this.Class = c;
            this.Section = s;
        }
    }
}
