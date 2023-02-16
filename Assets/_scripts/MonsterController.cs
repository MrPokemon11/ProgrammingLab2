using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterController : MonoBehaviour
{
    GameObject monster;
    public Rigidbody rig;
    public bool alive = true;

    // Start is called before the first frame update
    void Start()
    {
        
        rig = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (alive)
        {
            Move();
        }
        
    }

    virtual public void Move()
    {
        if(rig.transform.position.y < 0 || rig.transform.position.y > 2)
        {
            alive = false;
        }
        if (alive)
        {

        }
        
    }
}
