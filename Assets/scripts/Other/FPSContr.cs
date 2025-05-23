using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FPSContr : MonoBehaviour
{
    public int targetFPS = 144;
    private void Awake()
    {
        Application.targetFrameRate = targetFPS;
    }

    public void Redacted(int Num)
    {
        if(Num == 0)
        {
            targetFPS = 30;
        }
        if (Num == 1)
        {
            targetFPS = 60;
        }
        if (Num == 2)
        {
            targetFPS = 144;
        }
    }
}
