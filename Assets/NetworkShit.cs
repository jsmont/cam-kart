using UnityEngine;
using UnityEngine.Networking;
using System.Collections;

[RequireComponent(typeof(NetworkManager))]

public class NetworkShit : MonoBehaviour {

    public NetworkManager manager;
    
	// Use this for initialization
    void Awake()
    {
        manager = GetComponent<NetworkManager>();
    }

	void Start () {
        if (Application.platform == RuntimePlatform.Android)
        {
            manager.networkAddress = "10.248.229.115";
            manager.StartClient();
            ClientScene.Ready(manager.client.connection);
        }
        
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
