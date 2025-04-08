using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SaveProgress : MonoBehaviour
{
    int numbScene;
    private void Start()
    {
        numbScene = SceneManager.GetActiveScene().buildIndex;
    }
    
    // Start is called before the first frame update
    public void Save()
    {
        Debug.Log(numbScene);
        PlayerPrefs.SetInt("scen", numbScene);
        PlayerPrefs.Save();
    }
}
