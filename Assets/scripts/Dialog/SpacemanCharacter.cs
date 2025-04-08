using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DialogueEditor;

public class SpacemanCharacter : MonoBehaviour
{
    public NPCConversation myConversation;
    
    private void OnMouseDown()
    {
        if (Input.GetMouseButtonDown(0))
        {
            ConversationManager.Instance.StartConversation(myConversation);
        }
    }
    
    public void Dialog()
    {
        ConversationManager.Instance.StartConversation(myConversation);
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            ConversationManager.Instance.StartConversation(myConversation);
        }
    }


}
