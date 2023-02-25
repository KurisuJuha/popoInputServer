﻿using System.Collections.ObjectModel;
using JuhaKurisu.PopoTools.ByteSerializer;

namespace JuhaKurisu.PopoTools.InputSystem.Server;

public class Server
{
    public ReadOnlyDictionary<Guid, Client> clients => clientDictionary.AsReadOnly();

    private readonly Dictionary<Guid, Client> clientDictionary;

}