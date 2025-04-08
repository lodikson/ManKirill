using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ManageScene : MonoBehaviour
{
    public int scen;


    private void Start()
    {
        scen = PlayerPrefs.GetInt("scen", scen);
    }

    [SerializeField] public int SceneNumber = 0;

    public void TravelScene(int scene)
    {
        SceneManager.LoadScene(scene);
    }

    public void Continue()
    {
        SceneManager.LoadScene(scen);
    }
    
}
