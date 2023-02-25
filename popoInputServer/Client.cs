using System.Collections.ObjectModel;

namespace JuhaKurisu.PopoTools.InputSystem.Server;

public class Client
{
    public readonly Guid clientID;
    public readonly Guid secretID;
    public readonly ReadOnlyCollection<byte> input;

    public Client(Guid clientID, Guid secretID, byte[] bytes)
    {
        this.clientID = clientID;
        this.secretID = secretID;
        input = new(bytes);
    }
}