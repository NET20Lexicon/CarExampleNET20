using System;
using System.Collections.Generic;
using System.Text;

namespace CarExampleNET20
{
    class Demo
    {
        private IUI ui;
        public Demo(IUI ui)
        {
            this.ui = ui;
        }

        public void Do()
        {
            ui.Print("Hej");
        }
        
    }
}
