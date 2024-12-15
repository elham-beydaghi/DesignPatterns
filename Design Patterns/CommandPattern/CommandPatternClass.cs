using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.CommandPattern
{
    public interface ICommander
    {
        void Execute();
        void UnExecute();
    }
    public interface IInvoker
    {
        void ClickBlackButton();
        void ClickWhiteButton();
        void ClickRedButton();
    }

    public class Lamp : ILamp
    {
        public void TurnOnLight()
        {
            Console.WriteLine("Light turned on");
        }

        public void TurnOffLight()
        {
            Console.WriteLine("Light turned off");
        }
    }

    public interface ILamp
    {
        void TurnOnLight();

        void TurnOffLight();

    }

    public class TurningOnCommander : ICommander
    {
        private readonly ILamp lamp;

        public TurningOnCommander(ILamp lamp)
        {
            this.lamp = lamp;
        }
        public void Execute()
        {
            lamp.TurnOnLight();
        }

        public void UnExecute()
        {
            lamp.TurnOffLight();
        }
    }


    public class TurningOffCommander : ICommander
    {
        private readonly ILamp lamp;

        public TurningOffCommander(ILamp lamp)
        {
            this.lamp = lamp;
        }
        public void Execute()
        {
            lamp.TurnOffLight();
        }
        public void UnExecute()
        {
                lamp.TurnOnLight(); 
        }
    }

    public class Invoker : IInvoker
    {

        private readonly ICommander _turnOnCommander;
        private readonly ICommander _turnOffCommander;
        public Invoker(ICommander turnOncommander, ICommander turnOffcommander)
        {
            _turnOffCommander = turnOffcommander;
            _turnOnCommander = turnOncommander;
        }
        public void ClickBlackButton()
        {
            _turnOnCommander.Execute();
        }

        public void ClickWhiteButton()
        {
            _turnOffCommander.Execute();
        }

        public void ClickRedButton()
        {
            _turnOnCommander.UnExecute();
        }
    }
}
