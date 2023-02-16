using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bee : MonsterController
{
    public float upForce;

    private void FixedUpdate()
    {
        Move();
    }

    public override void Move()
    {
        if(rig.transform.position.y > 3)
        {
            alive = false;
        }
        if (alive)
        {
            new WaitForSecondsRealtime(2);
            rig.AddForce(Vector3.up * upForce);
        }
        if(rig.transform.position.y < 2)
        {
            alive = true;
        }
    }
}
