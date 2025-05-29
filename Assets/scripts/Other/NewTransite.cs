using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewTransite : MonoBehaviour
{
    public GameObject n;

    private void Start()
    {
        //n = GameObject.FindGameObjectWithTag("UIman");
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            n.SetActive(true);
        }
    }
}
