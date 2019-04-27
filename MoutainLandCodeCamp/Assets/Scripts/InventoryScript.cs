using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryScript : MonoBehaviour
{
    void Update()
    {
        bool keyread = Input.GetKey("i");
        InvenScript();
    }
    public static void InvenScript()
    {
        bool keyread = Input.GetKey("i");
        Debug.Log(keyread);
    }
}