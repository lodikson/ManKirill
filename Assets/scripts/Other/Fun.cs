using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fun : MonoBehaviour
{
    public static int FUN;

    public void Rab()
    {
        FUN = Random.Range(1, 100);
    }
}
