using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Battle : MonoBehaviour
{
    public int HealthBarPlayer, HealthBarEnemy, scen, maxHp = 100;

    public Image HealthBarPlaye, HealthBarEnem;

    public void Start()
    {
        PlayerPrefs.GetInt("scen", scen);
        HealthBarPlayer = maxHp;
        HealthBarEnemy = maxHp;
    }

    private void FixedUpdate()
    {
        // Здоровье врага
        if(HealthBarEnemy >= 1)
        {
            HealthBarEnem.fillAmount = HealthBarEnemy / maxHp;
        }
        else
        {
            Victory();
        }
        // Здоровье игрока
        if (HealthBarPlayer >= 1)
        {
            HealthBarPlaye.fillAmount = HealthBarPlayer / maxHp;
        }
        else
        {
            Deaf();
        }
    }

    public void AttackEnemy(int Num)
    {
        HealthBarEnemy -= Num;
    }

    public void Victory()
    {
        SceneManager.LoadScene(scen);
    }

    public void Deaf()
    {
        SceneManager.LoadScene(10);
    }
}
