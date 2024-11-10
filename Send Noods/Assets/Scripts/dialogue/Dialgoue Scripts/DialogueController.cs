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
    public PackageAppear PackageAppear;

    private Coroutine typeDialogueCoroutine;

    private const string HTML_ALPHA = "<color=#00000000>";
    private const float MAX_TYPE_TIME = 0.1f;

    [SerializeField] public int NPCNAMEChange = 0;


    [SerializeField] public int KitchenShow = 0;


    public NFwho NFwho;
    public NFWhere NFWhere;
    public NFAlive NFAlive;

    public CHILWho CHILwho;
    public CHILWhere CHILWhere;
    public ChilAlive CHILAlive;


    public CHIVWho CHIVwho;
    public CHIVWhere CHIVWhere;
    public ChivAlive CHIVAlive;


    public MUSHWho MUSHwho;
    public MUSHWhere MUSHWhere;
    public MUSHAlive MUSHAlive;



    public int SAVECHIVWHO = 0;
    public int SAVECHIVWHERE = 0;
    public int SAVECHIVALIVE = 0;

    public int SAVECHILWHO = 0;
    public int SAVECHILWHERE = 0;
    public int SAVECHILALIVE = 0;

    public int SAVEMUSHWHO = 0;
    public int SAVEMUSHWHERE = 0;
    public int SAVEMUSHALIVE = 0;

    public GameObject KENJISNOTE;
    public GameObject KENJIHIDE;

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
        if (CHILwho.RENAMECHANGE == 1)
        {
            SAVECHILWHO = 1;
        }
        if (CHILWhere.RENAMECHANGE == 1)
        {
            SAVECHILWHERE = 1;
        }
        if (CHILAlive.RENAMECHANGE == 1)
        {
            SAVECHILALIVE = 1;
        }




        if (CHIVwho.RENAMECHANGE == 1)
        {
            SAVECHIVWHO = 1;
        }
        if (CHIVWhere.RENAMECHANGE == 1)
        {
            SAVECHIVWHERE = 1;
        }
        if (CHIVAlive.RENAMECHANGE == 1)
        {
            SAVECHIVALIVE = 1;
        }




        if (MUSHwho.RENAMECHANGE == 1)
        {
            SAVEMUSHWHO = 1;
        }
        if (MUSHWhere.RENAMECHANGE == 1)
        {
            SAVEMUSHWHERE = 1;
        }
        if (MUSHAlive.RENAMECHANGE == 1)
        {
            SAVEMUSHALIVE = 1;
        }


        if (SAVECHILALIVE == 1 && SAVECHILWHO == 1 && SAVECHILWHERE == 1 || SAVECHIVALIVE == 1 && SAVECHIVWHO == 1 && SAVECHIVWHERE == 1 || SAVEMUSHWHO == 1 || SAVEMUSHWHERE == 1 || SAVEMUSHALIVE == 1)
        {

            KENJIHIDE.SetActive(false);
            Debug.Log("niote appear");
            KENJISNOTE.GetComponent<Image>().enabled = true;
        }



        NPCNAMEChange = 0;
        PackageAppear.MushroomsCollected = 0;

        NFwho.NFQuestion1 = 0;
        NFwho.RENAMECHANGE = 0;
        NFWhere.NFQuestion2 = 0;
        NFWhere.RENAMECHANGE = 0;
        NFAlive.NFQuestion3 = 0;
        NFAlive.RENAMECHANGE = 0;

        CHILwho.CHILQuestion1 = 0;
        CHILwho.RENAMECHANGE = 0;
        CHILWhere.CHILQuestion2 = 0;
        CHILWhere.RENAMECHANGE = 0;
        CHILAlive.CHILQuestion3 = 0;
        CHILAlive.RENAMECHANGE = 0;

        CHIVwho.CHIVQuestion1 = 0;
        CHIVwho.RENAMECHANGE = 0;
        CHIVAlive.CHIVQuestion3 = 0;
        CHIVWhere.RENAMECHANGE = 0;
        CHIVWhere.CHIVQuestion2 = 0;
        CHIVAlive.RENAMECHANGE = 0;

        MUSHwho.MUSHQuestion1 = 0;
        MUSHwho.RENAMECHANGE = 0;
        MUSHWhere.MUSHQuestion2 = 0;
        MUSHWhere.RENAMECHANGE = 0;
        MUSHAlive.MUSHQuestion3 = 0;
        MUSHAlive.RENAMECHANGE = 0;


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







