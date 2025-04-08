using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyDieState : MonoBehaviour
{
    int x, scen;
    public int block = 1;
    public void Start()
    {
        scen = SceneManager.GetActiveScene().buildIndex;
        if (scen == 10)
        {
            gameObject.SetActive(false);
        }
        Debug.Log("СТоп!");
        x = SceneManager.sceneCount;
        Debug.Log(x);
    }
    void Update()
    {
        
        GameObject[] objects = GameObject.FindGameObjectsWithTag("Enemy");

        // Сохраняем количество объектов в переменную
        canktion.objectCount = objects.Length;
        if (canktion.objectCount > block)
        {
            gameObject.tag = "Finish";
        }
        if(gameObject.tag == "Finish")
        {
            Destroy(gameObject);
        }
        if (SceneManager.GetActiveScene().name == "Menu")
            Destroy(gameObject);
    }
}
