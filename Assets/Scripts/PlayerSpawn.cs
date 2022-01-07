using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSpawn : MonoBehaviour
{
    public Transform spawner;
    public GameObject player;

    // Start is called before the first frame update
    public void Start()
    {
        Instantiate(player, spawner);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
