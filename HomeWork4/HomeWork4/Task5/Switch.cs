using HomeWork4.Task5.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork4.Task5
{
    public class Switch
    {
        private ISwitchable device;

        public Switch(ISwitchable device)
        {
            this.device = device;
        }

        public void Press()
        {
            device.TurnOn();
        }
    
     }
}
