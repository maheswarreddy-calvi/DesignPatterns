using DesignPatterns.Examples.Command_Pattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Examples.Command_Pattern.Commands
{
    public class SwitchOffCommand : ICommand
    {
        private readonly ILight _light;

        public SwitchOffCommand(ILight light)
        {
            this._light = light;
        }
        public void Execute()
        {
            this._light.PowerOff();
        }
    }
}
