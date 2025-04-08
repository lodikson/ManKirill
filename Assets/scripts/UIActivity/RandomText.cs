using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RandomText : MonoBehaviour
{
    public Text wordText;
    public string[] words;

    private void Start()
    {
        // ������� ��������� ����� �� ������� ���� ��� ������� ����        
        GenerateRandomWord();
    }

    public void GenerateRandomWord()
    {
        // ���������� ��������� ������ ������� ����
        int randomIndex = Random.Range(0, words.Length);
        // ������� ����� �� �����
        wordText.text = words[randomIndex];
    }
}
