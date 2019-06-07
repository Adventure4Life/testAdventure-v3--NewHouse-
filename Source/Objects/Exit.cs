using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testAdventure
{
    class Exit
    {
        public string name { get; set; } = "";
        public string direction { get; set; } = "";
        public bool avaliable { get; set; } = false;
        public bool open { get; set; } = false;
        public string look_at_exit { get; set; } = "";
        public string move_Through_exit { get; set; } = "";

        public void SetOpenClosed()
        {
            if (open == true) { open = false; }
            else if (open == false) { open = true; }
        }
    }
}

/*
        
        public string look_at_closed { get; set; } = "";
        public string use_Open { get; set; } = "";
        public string use_Closed { get; set; } = "";
*/
