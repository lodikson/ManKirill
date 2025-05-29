using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TravelRaz : MonoBehaviour
{
    [SerializeField] public int SceneNumber = 0;

    public Text text;
    public GameObject ob;

    public void Start()
    {
        ob.SetActive(false);
    }


    public void OnTriggerEnter2D(Collider2D collision)
    {
        
        if (collision.tag == "Player")
        {

            
            if (canktion.objectCount == 0 && SomethingIntrasting.objectCountIntr == 0)
            {
                PlayerPrefs.SetInt("scen", SceneNumber);
                PlayerPrefs.Save();
                PlayerPositionSAver.SaveCurrentPosition(gameObject);
                SceneManager.LoadScene(SceneNumber);
                
            }
            else
            {
                ob.SetActive(true);
                UpdateUI();
                BlinkMessage();
            }
                

        }
    }
    
    

    [Header("Настройки появления текста")]
    [SerializeField] float FadeSec = 0.5f; // время появления/исчезания (пол секунды)
    [SerializeField] float ShowSec = 1f; // время показа (одна секунда)

    public void UpdateUI()
    {
        text.text = "Я упустил " + (SomethingIntrasting.objectCountIntr + canktion.objectCount) + " деталь";
    }

    private void BlinkMessage()
    {
        StopAllCoroutines();
        StartCoroutine(BlinkCoroutine());   
    }

    private IEnumerator BlinkCoroutine()
    {
        yield return FadeTextAlpha(0f, 1f);
        yield return new WaitForSeconds(ShowSec);
        yield return FadeTextAlpha(1f, 0f);

    }

    private IEnumerator FadeTextAlpha(float from, float to)
    {
        Color textColor = text.color;
        textColor.a = from;

        float time = 0;

        while (time < FadeSec)
        {
            time += Time.deltaTime;
            textColor.a = Mathf.Lerp(from, to, 1f / FadeSec * time);
            text.color = textColor;

            yield return null;
        }
    }

}
