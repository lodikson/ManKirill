using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestOne : MonoBehaviour
{
    
    void Start()
    {
        PlayerPositionSAver.LoadPreviousPosition(gameObject);
    }

    
}
