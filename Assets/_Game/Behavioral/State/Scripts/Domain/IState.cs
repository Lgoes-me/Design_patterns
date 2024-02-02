namespace State.Domain
{
    public interface IState
    {
        void OnStateEnter();
        void OnStateExit();
    }
}