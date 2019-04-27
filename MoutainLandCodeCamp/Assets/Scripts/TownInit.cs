using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TownInit : MonoBehaviour
{
    public GameObject garret;
    public GameObject monster;
    // Start is called before the first frame update
    void Start()
    {
        float garstarposx = ToSingle(-2.104);
        float garstarposy = ToSingle(5.5639);
        Instantiate (garret, new Vector2(garstarposx, garstarposy), Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
    }

    private static float ToSingle(double value)
    {
        return (float)value;
    }
}
