using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Media;
using System.Reflection;
using System.Text.RegularExpressions;
using System.IO;

namespace Jungler_Timers 
{
    public class myButton : Button
    {
        public int state { get; set; }

        public myButton() : base()
        {
            state = 0;
        }  
    }
}
