using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform player;

    void Update()
    {
        if(player.position.x > transform.position.x)
        {
            transform.position = new Vector3(player.position.x, player.position.y, transform.position.z);
        }

        transform.position = new Vector3(transform.position.x, player.position.y, transform.position.z);


    }
}
