using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SomethingIntrasting : MonoBehaviour
{
    public string targetTag = "Intr"; // ��� ��������, ������� ����� ���������
    public static int objectCountIntr;

    void Update()
    {
        // ������� ��� ������� � ��������� �����
        GameObject[] objects = GameObject.FindGameObjectsWithTag("Intr");

        // ��������� ���������� �������� � ����������
        objectCountIntr = objects.Length;

    }

    public void DeleteTag()
    {
        this.tag = "Wall";
    }
}
