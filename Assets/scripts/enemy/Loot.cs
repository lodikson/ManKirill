using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loot : MonoBehaviour
{
    public void Loots(int id)
    {
        if(id == 1)
        {
            if(Random.Range(1, 5) == 3)
            {
                knight.kcount += 1;
                Debug.Log("Найден нож");
            }
            else
            {
                Debug.Log("Ничего полезного");
            }
        }
    }
}
