using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DialogueEditor;

public class ChoseDialog : MonoBehaviour
{
    public NPCConversation dialog1;
    public NPCConversation dialog2;

    public bool bob = true;
    public int Bob = 3;

    public void Choose1()
    {
        Bob = 1;
    }
    public void Choose2()
    {
        Bob = 2;
    }

    private void FixedUpdate()
    {
        if (Bob == 1)
        {
            ConversationManager.Instance.StartConversation(dialog1);
            knight.kcount += 1;
            Bob = 3;
        }
        if (Bob == 2)
        {
            health.hp -= 30;
            ConversationManager.Instance.StartConversation(dialog2);
            Bob = 3;
        }
    }
}
