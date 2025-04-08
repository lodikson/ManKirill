using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lookForwar : MonoBehaviour
{
    public GameObject ob;
    public static int Ach;

    public void Chtenie()
    {
        ob.SetActive(true);
    }

    public void zakrit()
    {
        ob.SetActive(false);
    }
    public void otherSans()
    {
        Ach = 1;
        
    }
}
