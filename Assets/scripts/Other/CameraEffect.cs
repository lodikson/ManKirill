using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraEffect : MonoBehaviour
{
    private Vector3 originalPosition;
    // ����������� ������ � �������� ������������� � ��������������  
    public void ShakeCamera(float duration, float intensity)
    {
        duration = 5;
        originalPosition = transform.localPosition;
        InvokeRepeating("DoShake", 0, 0.01f);
        Invoke("StopShake", duration);
    }
    // ��������� ������ ������������  
    private void DoShake()
    {
        float offsetX = Random.Range(-0.1f, 0.1f);
        float offsetY = Random.Range(-0.1f, 0.1f);
        transform.localPosition = originalPosition + new Vector3(offsetX, offsetY, 0);
    }
    // ���������� ������ ������������ � ���������� ��������� ������  
    private void StopShake()
    {
        CancelInvoke("DoShake");
        transform.localPosition = originalPosition;
    }
}
