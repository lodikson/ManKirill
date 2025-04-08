using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerSave : MonoBehaviour
{
    public GameObject savePoint;

    public void OnTriggerEnter2D(Collider2D collision) {
        if (collision.tag == "Player")
        {
            if(savePoint.tag == "Not_Save")
                savePoint.tag.Replace("Not_Save", "Save");
        }
    }
}
