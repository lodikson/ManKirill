using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class InputFieldss : MonoBehaviour
{
    [SerializeField] InputField field;
    [SerializeField] Text myText;

    [SerializeField] public string input_text;

    public GameObject vov, but;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.K))
        {
            but.SetActive(true);
        }
    }

    public void Secr()
    {
        input_text = myText.text;
        Debug.Log("" + input_text);
        if(input_text == "когда локации?")
        {
            vov.SetActive(false);
        }
        if (input_text == "сцена с борисом")
        {
            SceneManager.LoadScene(6);
        }
        if (input_text == "fun")
        {
            SceneManager.LoadScene(9);
        }
        if (input_text == "End")
        {
            SceneManager.LoadScene(11);
        }
    }

    public void OnCExit()
    {
        but.SetActive(false);
    }
}
