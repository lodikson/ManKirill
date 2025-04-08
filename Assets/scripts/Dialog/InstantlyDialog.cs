using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DialogueEditor;
public class InstantlyDialog : MonoBehaviour
{
    public NPCConversation myConversation;
    int stop = 0;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(stop == 0)
        {
            if (collision.CompareTag("Finiki"))
                {
                    ConversationManager.Instance.StartConversation(myConversation);
                    stop = 1;
                }
        }
        
    }
}
