using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollowScript : MonoBehaviour
{
    private GameObject playerGarrett;
    
    private Rigidbody2D rb;

    void start()
    {
        playerGarrett = FindObjectOfType<PlayerController>().gameObject;
    }

    void FixedUpdate()
    {
        transform.position = new Vector3(playerGarrett.transform.position.x, playerGarrett.transform.position.y, transform.position.z);
    }
}
