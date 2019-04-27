using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class walking_script : MonoBehaviour
{
    public float walkSpeed;
    public float curSpeed;
    public float maxSpeed;

    private BasePlayerStats plStat;
    // Start is called before the first frame update
    void Start()
    {
        plStat = GetComponent<BasePlayerStats>();

        walkSpeed = (float)(plStat.Speed + (plStat.Agility/5));
        sprintSpeed = walkSpeed + (walkSpeed / 2);
    }

    // Update is called once per frame
    void Update()
    {
    }


    void FixedUpdate() 
    {
        GetComponent<Rigidbody2D>().velocity = new Vector2(Mathf.Lerp(0, Input.GetAxis("Horizontal")* curSpeed, 0.8f),
                                            Mathf.Lerp(0, Input.GetAxis("Vertical")* curSpeed, 0.8f));    
    }
}
