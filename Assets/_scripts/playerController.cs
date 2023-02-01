using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour
{
    private GameObject player;

    public int gemsCollected = 0;

    // Start is called before the first frame update
    void Start()
    {
        player = GetComponent<GameObject>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddGem()
    {
        gemsCollected = gemsCollected + 1;
        Console.WriteLine(gemsCollected);
    }

    public int GetGemsCollected()
    {
        return gemsCollected;
    }

    public GameObject GetPlayer()
    {
        return player;
    }
}
