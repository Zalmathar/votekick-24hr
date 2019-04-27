using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShackInit : MonoBehaviour
{
    public GameObject garret;
    // Start is called before the first frame update
    void Start()
    {
        float garstarposx = ToSingle(-1.35);
        float garstarposy = ToSingle(-1.4);
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
