using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TranslateScene : MonoBehaviour
{
    public int NumScene;
    public bool goida = false;

    public void TravelScene(int scene)
    {
        SceneManager.LoadScene(scene);
    }

    public void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            goida = true;
            if (Input.GetKey(KeyCode.F))
            {
                TravelScene(NumScene);
            }
            
        }
    }

    private void OnMouseDown()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (goida)
            {
                TravelScene(NumScene);
            }
        }
    }
}
