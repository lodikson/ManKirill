using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class canktion : MonoBehaviour
{
    public string targetTag = "Enemy"; // Тег объектов, которые нужно посчитать
    public static int objectCount;

    void Start()
    {
        // Находим все объекты с указанным тегом
        GameObject[] objects = GameObject.FindGameObjectsWithTag("Enemy");

        // Сохраняем количество объектов в переменную
        objectCount = objects.Length;

        Debug.Log("Количество объектов: " + objectCount);
    }

    

}
