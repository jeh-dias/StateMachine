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

        public void NormalPath()
        {
            _machine.Fire(TriggerEnum.NormalPath);
            Console.WriteLine("     Trigger NormalPath - State Wait");
        }

        public void Blocked()
        {
            _machine.Fire(TriggerEnum.Blocked);
            Console.WriteLine("     Trigger Blocked - State Blocked");
        }

        public void Success()
        {
            _machine.Fire(TriggerEnum.Success);
            Console.WriteLine("     Trigger Success - State Registered");
        }

        public void Error()
        {
            _machine.Fire(TriggerEnum.Error);
            Console.WriteLine("     Trigger Error - State Error");
        }

        public void Enqueue()
        {
            _machine.Fire(TriggerEnum.Enqueue);
            Console.WriteLine("     Trigger Enqueue - State Wait");
        }

        public void Archive()
        {
            _machine.Fire(TriggerEnum.Archive);
            Console.WriteLine("     Trigger Archive - State Archive");
        }

        public void Retry()
        {
            _machine.Fire(TriggerEnum.Retry);
            Console.WriteLine("     Trigger Retry - State Retry");
        }
    }
}
