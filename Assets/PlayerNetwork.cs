using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class PlayerNetwork : MonoBehaviour
{
    // Method to send data across the network
    public void SendData(byte[] data, int hostId, int connectionId, int channelId)
    {
        byte error;
        // Send data across the network
        NetworkTransport.Send(hostId, connectionId, channelId, data, data.Length, out error);

        // Log any errors encountered during sending
        Debug.Log("Data sent with error: " + error);
    }
}
