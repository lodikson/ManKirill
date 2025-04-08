using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tutorial : MonoBehaviour
{

    public int man_scoll = 0;
    
    void Start()
    {
        man_scoll = PlayerPrefs.GetInt("scen", man_scoll);
        if(man_scoll > 0)
        {
            gameObject.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
