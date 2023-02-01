using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pickUpGem : MonoBehaviour
{
    [SerializeField] private GameObject player;

    [SerializeField] private GameObject gem;

    private Rigidbody gemRig;
    private playerController controller;
    private Vector3 startPos;
    
    // Start is called before the first frame update
    void Start()
    {
        controller = player.GetComponent<playerController>();
        gem = GetComponent<GameObject>();
        gemRig = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if(gemRig.velocity.x != Vector3.zero.x)
        {
            
            Destroy(gem);
        }
    }
    
}
