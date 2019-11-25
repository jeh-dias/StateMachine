using Stateless;
using StateMachine.CrossCutting.StateMachine;
using StateMachine.Domain.ValueObj;
using System;
using System.Collections.Generic;
using System.Text;

namespace StateMachine
{
    /// <summary>
    /// Fonte: https://www.youtube.com/watch?v=ZClpfDby-uY
    /// </summary>
    public class AgendaStateMachine
    {
        
        private readonly StateMachine<StatusEnum, TriggerEnum> _machine;

        public AgendaStateMachine() {

            _machine = StatusConfiguration.Build();
        }

        public StatusEnum NormalPath()
        {
            _machine.Fire(TriggerEnum.NormalPath);
            Console.WriteLine("     Trigger NormalPath - State Wait");
            return _machine.State;
        }

        public StatusEnum Blocked()
        {
            _machine.Fire(TriggerEnum.Blocked);
            Console.WriteLine("     Trigger Blocked - State Blocked");
            return _machine.State;
        }

        public StatusEnum Success()
        {
            _machine.Fire(TriggerEnum.Success);
            Console.WriteLine("     Trigger Success - State Registered");
            return _machine.State;
        }

        public StatusEnum Error()
        {
            _machine.Fire(TriggerEnum.Error);
            Console.WriteLine("     Trigger Error - State Error");
            return _machine.State;
        }

        public StatusEnum Enqueue()
        {
            _machine.Fire(TriggerEnum.Enqueue);
            Console.WriteLine("     Trigger Enqueue - State Wait");
            return _machine.State;
        }

        public StatusEnum Archive()
        {
            _machine.Fire(TriggerEnum.Archive);
            Console.WriteLine("     Trigger Archive - State Archive");
            return _machine.State;
        }

        public StatusEnum Retry()
        {
            _machine.Fire(TriggerEnum.Retry);
            Console.WriteLine("     Trigger Retry - State Retry");
            return _machine.State;
        }
    }
}
