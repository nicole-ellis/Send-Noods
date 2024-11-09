using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEditor.Experimental.GraphView;

public class DialogueController : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI NPCDialogueText; // to display the dialogue
    [SerializeField] private float typeSpeed = 10; // how fast the text moves

    private Queue<string> paragraphs = new Queue<string>(); // create paragraphs

    private bool conversationEnded; // for when the conversation ends
    private bool IsTyping; // for when the text is still being slowly being displayed

    private string p;

    private Coroutine typeDialogueCoroutine;

    private const string HTML_ALPHA = "<color=#00000000>";
    private const float MAX_TYPE_TIME = 0.1f;

    [SerializeField] public int NPCNAMEChange = 0;


    [SerializeField] public int KitchenShow = 0;


    public NFwho NFwho;
    public NFWhere NFWhere;
    public NFAlive NFAlive;





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
                NPCNAMEChange = NPCNAMEChange + 1;
            }
            else
            {
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

        

            //add dialogue text into queue
            for (int i = 0; i < dialogueText.paragraphs.Length; i++)
        {
            paragraphs.Enqueue(dialogueText.paragraphs[i]);
        }
    }

    private void EndConversation()
    {

        NFwho.NFQuestion1 = 0;
        NFWhere.NFQuestion2 = 0;
        NFAlive.NFQuestion3 = 0;

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


    private IEnumerator TypeDialogueText(string p) //stops text from teleporting from the end of the text box to a new line of the textbox while still being typed
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







