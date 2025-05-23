using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DialogueEditor;

public class two_var_Dialogs : MonoBehaviour
{
    public NPCConversation myConversation;
    public NPCConversation myConversation2;
    public bool OnTrue = false;

    private void OnMouseDown()
    {
        if(OnTrue == false)
        {
            if (Input.GetMouseButtonDown(0))
            {
                ConversationManager.Instance.StartConversation(myConversation);
                OnTrue = true;
            }
        }
        else
        {
            if (Input.GetMouseButtonDown(0))
            {
                ConversationManager.Instance.StartConversation(myConversation2);
                
            }
        }
        
    }

    public void Dialog()
    {
        ConversationManager.Instance.StartConversation(myConversation);
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (OnTrue == false)
        {
            if (Input.GetKeyDown(KeyCode.F))
            {
                ConversationManager.Instance.StartConversation(myConversation);
                OnTrue = true;
            }
        }
        else
        {
            if (Input.GetKeyDown(KeyCode.F))
            {
                ConversationManager.Instance.StartConversation(myConversation2);
            }
        }
        
        
    }
}
