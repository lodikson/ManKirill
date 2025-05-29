using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SomethingIntrasting : MonoBehaviour
{
    public string targetTag = "Intr"; // Тег объектов, которые нужно посчитать
    public static int objectCountIntr;

    void Update()
    {
        // Находим все объекты с указанным тегом
        GameObject[] objects = GameObject.FindGameObjectsWithTag("Intr");

        // Сохраняем количество объектов в переменную
        objectCountIntr = objects.Length;

    }

    public void DeleteTag()
    {
        this.tag = "Wall";
    }
}
