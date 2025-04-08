using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class health : MonoBehaviour
{
    public static float hp;
    public GameObject ob, new_ob;
    public Image healthBur;
    public float maxHp = 100;
     
    private Animator anim;
    private int loads;
    GameObject cub;

    //public GameObject specif;
    public float totalTime = 5f;

    void Start()
    {
        
        anim = GetComponent<Animator>();
        hp = maxHp;
        loads = SceneManager.sceneCount;
    }

    // Update is called once per frame
    void Update()
    {
        healthBur.fillAmount = hp / maxHp;
        if (hp >= 1)
        {


            if (totalTime > 0)
            {
                totalTime -= Time.deltaTime;
            }
            else
            {
                if (hp <= 70)
                {
                    ob.SetActive(true);
                }
                else
                {
                    ob.SetActive(false);
                }
                if (hp < 100)
                {
                    totalTime = 20;
                    hp += 10;
                }
            }
        }
        else
        {
            

            if (new_ob == null)
                return;
            new_ob.SetActive(true);
            PlayerPrefs.SetInt("scen", loads);
            PlayerPrefs.Save();
        }
        
    }

}
