using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class NetworkManager : MonoBehaviour
{
    // Maximum number of connections allowed
    private const int MAX_CONNECTION = 10;

    // Port number for the network communication
    private int port = 5701;

    // Network host ID for this instance
    private int hostId;

    // Network host ID for WebSockets (if used)
    private int webHostId;

    // Channel ID for reliable communication
    private int reliableChannel;

    // Flag to check if the network has started
    private bool isStarted = false;

    // Variable to hold network errors
    private byte error;

    void Start()
    {
        // Initialize the NetworkTransport layer
        NetworkTransport.Init();

        // Create a new connection configuration
        ConnectionConfig cc = new ConnectionConfig();

        // Add a reliable channel to the connection configuration
        reliableChannel = cc.AddChannel(QosType.Reliable);

        // Create a host topology with the connection configuration
        HostTopology topo = new HostTopology(cc, MAX_CONNECTION);

        // Add a regular host with the specified topology and port
        hostId = NetworkTransport.AddHost(topo, port, null);

        // Add a WebSocket host (optional)
        webHostId = NetworkTransport.AddWebsocketHost(topo, port, null);

        // Set the network as started
        isStarted = true;
    }

    void Update()
    {
        if (!isStarted)
            return;

        // Variables to store event details
        int recHostId;
        int connectionId;
        int channelId;
        byte[] recBuffer = new byte[1024];
        int bufferSize = 1024;
        int dataSize;

        // Receive network events
        NetworkEventType recData = NetworkTransport.Receive(out recHostId, out connectionId, out channelId, recBuffer, bufferSize, out dataSize, out error);

        switch (recData)
        {
            case NetworkEventType.Nothing:
                break;

            case NetworkEventType.ConnectEvent:
                // Log connection events
                Debug.Log("Player " + connectionId + " has connected");
                break;

            case NetworkEventType.DataEvent:
                // Log data reception events
                Debug.Log("Data received");
                break;

            case NetworkEventType.DisconnectEvent:
                // Log disconnection events
                Debug.Log("Player " + connectionId + " has disconnected");
                break;
        }
    }
}
