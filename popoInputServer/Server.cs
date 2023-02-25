using System.Collections.ObjectModel;
using JuhaKurisu.PopoTools.ByteSerializer;

namespace JuhaKurisu.PopoTools.InputSystem.Server;

public class Server
{
    public ReadOnlyDictionary<Guid, Client> clients => clientDictionary.AsReadOnly();
    public readonly int playerCount;

    private readonly Dictionary<Guid, Client> clientDictionary;

    public Server(int playerCount, Dictionary<Guid, Client> clients)
    {
        this.playerCount = playerCount;
        clientDictionary = new();
        clientDictionary = clients;
    }

}