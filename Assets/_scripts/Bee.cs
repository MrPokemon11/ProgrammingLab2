using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bee : MonsterController
{
    public float upForce;
    
    public override void Move()
    {
        base.Move();
        if ((rig.transform.position.x < 0 || rig.transform.position.x > 1) && (rig.transform.position.z < 23 || rig.transform.position.z > 24))
        {
            alive = false;
        }
        if (rig.transform.position.y > 0 && rig.transform.position.y < 2)
        {
            alive = true;
        }
        if (alive)
        {
            new WaitForSeconds(5);
            rig.AddForce(Vector3.up * upForce);
        }
    }
}
