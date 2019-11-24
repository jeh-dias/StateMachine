using System;

namespace StateMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Flow Blocked ");
            AgendaStateMachine stateMachineBlocked = new AgendaStateMachine();
            stateMachineBlocked.Blocked();
            stateMachineBlocked.Enqueue();

            stateMachineBlocked.Error();
            stateMachineBlocked.Archive();

            Console.WriteLine(" Flow Success ");
            AgendaStateMachine stateMachineSuccess = new AgendaStateMachine();
            stateMachineSuccess.NormalPath();
            stateMachineSuccess.Success();

            Console.WriteLine(" Flow ErrorRetrySuccess ");
            AgendaStateMachine stateMachineErrorRetrySuccess = new AgendaStateMachine();
            stateMachineErrorRetrySuccess.NormalPath();
            stateMachineErrorRetrySuccess.Error();
            stateMachineErrorRetrySuccess.Retry();
            stateMachineErrorRetrySuccess.Success();
        }
    }
}
