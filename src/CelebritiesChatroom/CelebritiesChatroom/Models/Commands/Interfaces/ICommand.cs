namespace CelebritiesChatroom.Models.Commands.Interfaces
{
    using CelebritiesChatroom.Models.Chatrooms;

    public interface ICommand
    {
        void Execute(Chatroom chatroom, params string[] arguments);
    }
}
