using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class canktion : MonoBehaviour
{
    public string targetTag = "Enemy"; // ��� ��������, ������� ����� ���������
    public static int objectCount;

    void Start()
    {
        // ������� ��� ������� � ��������� �����
        GameObject[] objects = GameObject.FindGameObjectsWithTag("Enemy");

        // ��������� ���������� �������� � ����������
        objectCount = objects.Length;

        Debug.Log("���������� ��������: " + objectCount);
    }

    

}
