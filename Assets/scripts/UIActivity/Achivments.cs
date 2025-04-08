using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Achivments : MonoBehaviour
{
    public static int Achiv;
    [SerializeField] bool[] achs_was;
    [SerializeField] Image[] achs_wins;
    [SerializeField] Text[] text_wins;
    public int stop;
    public static int shiza;
    public static int samyrai;


    SpriteRenderer spr;

    // Метод Start вызывается перед обновлением первой фреймы
    void Start()
    {
        spr = GetComponent<SpriteRenderer>();
        
    }

    public void Update()
    {
        
        if (!achs_was[0] && lookForwar.Ach == 1)
        {
            achs_was[0] = true;
            achs_wins[0].color = Color.white;
            text_wins[0].color = Color.white;
        }
        if (!achs_was[1] && shiza == 1)
        {
            achs_was[1] = true;
            achs_wins[1].color = Color.white;
            text_wins[1].color = Color.white;
        }
        if (!achs_was[2] && samyrai == 1)
        {
            achs_was[2] = true;
            achs_wins[2].color = Color.white;
            text_wins[2].color = Color.white;
        }

    }

    
}
