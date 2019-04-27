using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShackInit : MonoBehaviour
{
    public GameObject playerGarrett;
    // Start is called before the first frame update
    private Rigidbody2D rb;

    

    void Start()
    {
        float garstarposx = ToSingle(-1.35);
        float garstarposy = ToSingle(-1.4);
        Instantiate (playerGarrett, new Vector2(garstarposx, garstarposy), Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
    }

    void FixedUpdate()
    {
        transform.position = new Vector3(playerGarrett.transform.position.x, playerGarrett.transform.position.y, transform.position.z);
    }
    
        private static float ToSingle(double value)
    {
        return (float)value;
    }
}
