using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Netcode;

public class PaddleSpawner : NetworkBehaviour
{
    
    public GameObject left;
    public GameObject right;

    public Transform leftSpawn;
    public Transform rightSpawn;

    public override void OnNetworkSpawn()
    {
        if (!IsServer) return;

        NetworkManager.Singleton.OnClientConnectedCallback += SpawnPaddle;
    }

    void SpawnPaddle(ulong clientId)
    {
        GameObject prefab;
        Vector3 spawnPoint;

        if (clientId == NetworkManager.ServerClientId)
        {
            prefab = left;
            spawnPoint = leftSpawn.position;
        }
        else
        {
            prefab = right;
            spawnPoint = rightSpawn.position;
        }

        var paddle = Instantiate(prefab, spawnPoint, Quaternion.identity);
        paddle.GetComponent<NetworkObject>().SpawnAsPlayerObject(clientId);
    }
}
