using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    public float moveSpeed;
    public float jumpPower;
    public float rotSpeed;

    private Rigidbody rig;
    public static float playerX;
    public static float playerY;
    public static float playerZ;
    // Start is called before the first frame update
    void Start()
    {
        rig = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer();
        playerX = rig.transform.position.x;
        playerY = rig.transform.position.y;
        playerZ = rig.transform.position.z;
    }

    void MovePlayer()
    {
        float turn = Input.GetAxis("Horizontal");
        if (Input.GetKey(KeyCode.W))
        {
            rig.AddRelativeForce(Vector3.forward * moveSpeed);
        }
        if (Input.GetKey(KeyCode.S))
        {
            rig.AddRelativeForce(Vector3.back * moveSpeed);
        }
        if (Input.GetKey(KeyCode.A))
        {
            rig.AddRelativeTorque(Vector3.up * rotSpeed * turn);
        }
        if (Input.GetKey(KeyCode.D))
        {
            rig.AddRelativeTorque(Vector3.up * rotSpeed * turn);
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rig.AddForce(Vector3.up * jumpPower);
        }
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
    }
}
