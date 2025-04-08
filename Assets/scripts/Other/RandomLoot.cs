using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DialogueEditor;

public class RandomLoot : MonoBehaviour
{
    public int[] elements;
    int Bob;
    public NPCConversation myConversationGood;
    public NPCConversation myConversationBad;

    public void Start()
    {
        
    }

    

    public void Begin()
    {
        int randomIndex = Random.Range(0, elements.Length); // Выбираем случайный индекс
        Debug.Log("Выбранный элемент: " + elements[randomIndex]);
        Bob = elements[randomIndex];
    }

    private void FixedUpdate()
    {
        if (Bob == 1) {
            ConversationManager.Instance.StartConversation(myConversationGood);
            knight.kcount += 1;
            Bob = 3;
        }
        if (Bob == 2)
        {
            health.hp -= 30;
            ConversationManager.Instance.StartConversation(myConversationBad);
            Bob = 3;
        }
    }
}
