using DesignPatterns.Examples.Command_Pattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Examples.Command_Pattern.Commands
{
    public class AutoSwitchOffCommand : ICommand
    {
        private readonly ILight light;

        public AutoSwitchOffCommand(ILight light)
        {
            this.light = light;
        }
        public void Execute()
        {
            this.light.PowerOn();
            Thread.Sleep(3000);
            this.light.PowerOff();
        }
    }
}
