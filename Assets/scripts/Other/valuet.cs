using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class valuet : MonoBehaviour
{
    public int money = 100;
    public Text mon;

    public void Start()
    {
        UpdateData();
    }

    public void Add_Money(int n)
    {
        money += n;
    }

    public void Remove_Money(int n)
    {
        if(money > n)
        {
            money -= n;
        }
        else
        {
            Ret(false);
        }
    }

    public bool Ret(bool Row)
    {
        return Row;
    }

    public void UpdateData()
    {
        mon.text = "" + money;
    }

}
