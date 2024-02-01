namespace Command.Controllers.PlayerCommands
{
    public interface IPlayerCommand
    {
        void Execute(PlayerController playerController);
    }
}