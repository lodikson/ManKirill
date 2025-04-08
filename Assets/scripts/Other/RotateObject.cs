using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateObject : MonoBehaviour
{
    public Transform targetObject; // ������, � �������� ����� �����������
    public SpriteRenderer spriteRenderer; // �������� ������� ������ ���������

    private void Update()
    {
        if (targetObject != null && spriteRenderer != null)
        {
            // ���������, ��������� �� ���� ����� ��� ������ �� ���
            float directionX = targetObject.position.x - transform.position.x;

            // ������������� ������� �� ��� X � ����������� �� �����������
            spriteRenderer.flipX = directionX < 0;
        }
    }
}
