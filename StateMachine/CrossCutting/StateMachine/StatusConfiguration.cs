using Stateless;
using StateMachine.Domain.ValueObj;
using System;
using System.Collections.Generic;
using System.Text;

namespace StateMachine.CrossCutting.StateMachine
{
    public class StatusConfiguration
    {
        public static StateMachine<StatusEnum, TriggerEnum> Build(StatusEnum stateInitial = StatusEnum.Initial)
        {
            var machine = new StateMachine<StatusEnum, TriggerEnum>(() => stateInitial, s => stateInitial = s);

            machine.Configure(StatusEnum.Initial)
                .Permit(TriggerEnum.NormalPath, StatusEnum.Wait)
                .Permit(TriggerEnum.Blocked, StatusEnum.Blocked);

            machine.Configure(StatusEnum.Wait)
                .Permit(TriggerEnum.Success, StatusEnum.Registered)
                .Permit(TriggerEnum.Error, StatusEnum.Error);

            machine.Configure(StatusEnum.Blocked)
                .Permit(TriggerEnum.Enqueue, StatusEnum.Wait);

            machine.Configure(StatusEnum.Error)
                .Permit(TriggerEnum.Archive, StatusEnum.Archived)
                .Permit(TriggerEnum.Retry, StatusEnum.Retry);

            machine.Configure(StatusEnum.Retry)
                .Permit(TriggerEnum.Success, StatusEnum.Registered)
                .Permit(TriggerEnum.Error, StatusEnum.Error);

            return machine;
        }
    }
}
