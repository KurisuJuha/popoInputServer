using System.Collections.ObjectModel;

namespace JuhaKurisu.PopoTools.InputSystemServer;

public class Client
{
    public readonly Guid clientID;
    public readonly Guid secretID;
    public ReadOnlyCollection<byte> input;

    public Client(Guid clientID, Guid secretID, byte[] bytes)
    {
        this.clientID = clientID;
        this.secretID = secretID;
        input = new(bytes);
    }
}