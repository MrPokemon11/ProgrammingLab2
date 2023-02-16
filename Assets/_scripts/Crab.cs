using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crab : MonsterController
{
    public Transform target;
    public float movePower;
    public int damping;
    // Start is called before the first frame update
    void Start()
    {
        var targetX = movement.playerX;
        var targetY = movement.playerY;
        var targetZ = movement.playerZ;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        
    }

    public override void Move()
    {
        var lookPos = target.position + transform.position;
        //lookPos.y = 0;
        var rotation = Quaternion.LookRotation(lookPos);
        transform.rotation = Quaternion.Slerp(transform.rotation, rotation, Time.deltaTime * damping);
        rig.AddRelativeForce(Vector3.back * movePower);
    }
}
