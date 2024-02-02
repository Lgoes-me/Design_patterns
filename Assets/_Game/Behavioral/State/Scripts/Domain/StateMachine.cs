namespace State.Domain
{
    public class StateMachine
    {
        private IState State { get; set; }

        public void ChangeState(IState state)
        {
            State?.OnStateExit();
            State = state;
            State.OnStateEnter();
        }
        
        
    }
}