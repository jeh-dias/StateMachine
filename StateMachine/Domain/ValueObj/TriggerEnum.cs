using System;
using System.Collections.Generic;
using System.Text;

namespace StateMachine.Domain.ValueObj
{
    public enum TriggerEnum
    {
        NormalPath, 
        Blocked, 
        Success, 
        Error, 
        Archive, 
        Retry, 
        Enqueue 
    }
}
