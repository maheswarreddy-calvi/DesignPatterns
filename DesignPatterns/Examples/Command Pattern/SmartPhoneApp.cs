using DesignPatterns.Examples.Command_Pattern.Commands;
using DesignPatterns.Examples.Command_Pattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Examples.Command_Pattern
{
    public class SmartPhoneApp
    {
        private readonly ICommand onCommand;
        private readonly ICommand offCommand;
        private readonly AutoSwitchOffCommand autoSwitch;

        public SmartPhoneApp(ICommand onCommand, ICommand offCommand, AutoSwitchOffCommand autoSwitch)
        {
            this.onCommand = onCommand;
            this.offCommand = offCommand;
            this.autoSwitch = autoSwitch;
        }

        public void SwitchOn()
        {
            this.onCommand.Execute();
        }

        public void SwitchOff()
        {
            this.offCommand.Execute();
        }

        public void AutoSwitchOff()
        {
            this.autoSwitch.Execute();
        }
    }
}
