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
        // Выводим случайное слово из массива слов при запуске игры        
        GenerateRandomWord();
    }

    public void GenerateRandomWord()
    {
        // Генерируем случайный индекс массива слов
        int randomIndex = Random.Range(0, words.Length);
        // Выводим слово на экран
        wordText.text = words[randomIndex];
    }
}
