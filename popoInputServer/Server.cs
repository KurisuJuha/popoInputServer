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

    public void UpdateInput(byte[] bytes)
    {
        DataReader reader = new DataReader(bytes);

        // clientIDを読み込む
        Guid clientID = reader.ReadGuid();
        // secretIDを読み込む
        Guid secretID = reader.ReadGuid();
        // input内容を読み込む
        byte[] inputBytes = reader.ReadBytes();

        // secretIDが違う場合はエラーとする
        if (!clients.TryGetValue(clientID, out Client? client)
            || client is null
            || client.secretID != secretID) return;

        // 新しいclientをセット
        clientDictionary[clientID] = new Client(clientID, secretID, inputBytes);
    }
}