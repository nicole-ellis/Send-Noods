using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEditor.Experimental.GraphView;

public class DialogueController : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI NPCNameText;
    [SerializeField] private TextMeshProUGUI NPCDialogueText;
    [SerializeField] private float typeSpeed = 10;

    private Queue<string> paragraphs = new Queue<string>();

    private bool conversationEnded;
    private bool IsTyping;

    private string p;

    private Coroutine typeDialogueCoroutine;

    private const string HTML_ALPHA = "<color=#00000000>";
    private const float MAX_TYPE_TIME = 0.1f;

    private int NPCNAMEChange = 0;


    [SerializeField] public int KitchenShow = 0;



    public void SetSpeakerName(string newSpeakerName)
    {
        NPCNameText.text = newSpeakerName;
    }





    public void DisplayNextParagraph(DialogueText dialogueText)
    {
        // if there is nothing in the queue
        if (paragraphs.Count == 0)
        {
            if (!conversationEnded)
            {
                //Start Conversation
                StartConversation(dialogueText);
            }

            else if (conversationEnded && !IsTyping)
            {
                // end the conversation
                EndConversation();
                return;
            }
        }

        //if something in the queue
        if (!IsTyping)
        {
            // changes who is Speaker
            if (NPCNAMEChange % 2 == 0)
            {
                SetSpeakerName("Isagi");
                NPCNAMEChange = NPCNAMEChange + 1;
            }
            else
            {
                SetSpeakerName("Yukio");
                NPCNAMEChange = NPCNAMEChange + 1;
            }


            p = paragraphs.Dequeue();

            typeDialogueCoroutine = StartCoroutine(TypeDialogueText(p));
        }
        

        //conversation is being typed out
        else
        {
            FinishParagraphEarly();
        }

        //update bool end conversation
        if (paragraphs.Count == 0)
        {
            conversationEnded = true;
        }
    }

    private void StartConversation(DialogueText dialogueText)
    {
        //activate gameObject
        if (!gameObject.activeSelf)
        {
            gameObject.SetActive(true);
        }

        //upadte speaker name
        //SetSpeakerName(dialogueText.SpeakerName);
        

            //add dialogue text into queue
            for (int i = 0; i < dialogueText.paragraphs.Length; i++)
        {
            paragraphs.Enqueue(dialogueText.paragraphs[i]);
        }
    }

    private void EndConversation()
    {
        KitchenShow = KitchenShow + 1;
        //clear the queue
        paragraphs.Clear();
        //return bool as false
        conversationEnded = false;
        //deactivate itself(Narrative section)
        if (gameObject.activeSelf)
        {
            gameObject.SetActive(false);
        }
        
    }


    private IEnumerator TypeDialogueText(string p)
    {
        IsTyping = true;

        NPCDialogueText.text = "";

        string originalText = p;
        string displayText = "";
        int alphaIndex = 0;

        foreach (char c in p.ToCharArray())
        {
            alphaIndex++;
            NPCDialogueText.text = originalText;

            displayText = NPCDialogueText.text.Insert(alphaIndex, HTML_ALPHA);
            NPCDialogueText.text = displayText;

            yield return new WaitForSeconds(MAX_TYPE_TIME / typeSpeed);
        } 

        IsTyping = false;
    }

    private void FinishParagraphEarly()
    {
        //stop the coroutine
        StopCoroutine(typeDialogueCoroutine);

        //Finish displaying the text
        NPCDialogueText.text = p;

        //update IsTyping bool
        IsTyping = false;
    }






    
}







