using DesignPatterns.Examples.Command_Pattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Examples.Command_Pattern
{
    internal class Switch
    {
        private readonly ICommand onCommand;
        private readonly ICommand offCommand;

        public Switch(ICommand onCommand, ICommand offCommand)
        {
            this.onCommand = onCommand;
            this.offCommand = offCommand;
        }

        public void SwitchOn()
        {
            this.onCommand.Execute();
        }

        public void SwitchOff()
        {
            this.offCommand.Execute();
        }
    }
}
