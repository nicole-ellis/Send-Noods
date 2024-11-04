using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BackgroundTextChange : MonoBehaviour
{
    public DialogueController NameChange;
    public GameObject targetObject;
    public GameObject ChilliOrChives;
    private void Start() // if isagi is talking change the colour of the text background to blue
    {
        if (NameChange.NPCNAMEChange == 0)
        {
            targetObject.GetComponent<Image>().enabled = true;
        }
    }
    void Update()
    {
        if (NameChange.NPCNAMEChange == 2 || NameChange.NPCNAMEChange == 5 || NameChange.NPCNAMEChange == 10)// if isagi is not talking hide the blue text background
        {
            targetObject.GetComponent<Image>().enabled = false;
        }
        else if (NameChange.NPCNAMEChange == 1 || NameChange.NPCNAMEChange == 3 || NameChange.NPCNAMEChange == 6)
        {
            targetObject.GetComponent<Image>().enabled = true;
        }



        if (ChilliOrChives.activeSelf)
        {
            if (NameChange.NPCNAMEChange == 12 || NameChange.NPCNAMEChange == 14 || NameChange.NPCNAMEChange == 18 || NameChange.NPCNAMEChange == 21 || NameChange.NPCNAMEChange == 24 || NameChange.NPCNAMEChange == 26)
            {
                targetObject.GetComponent<Image>().enabled = false;
            }
            else if (NameChange.NPCNAMEChange == 11 || NameChange.NPCNAMEChange == 13 || NameChange.NPCNAMEChange == 15 || NameChange.NPCNAMEChange == 19 || NameChange.NPCNAMEChange == 23 || NameChange.NPCNAMEChange == 25 || NameChange.NPCNAMEChange == 27)
            {
                targetObject.GetComponent<Image>().enabled = true;
            }
        }
        else
        {
            if (NameChange.NPCNAMEChange == 12 || NameChange.NPCNAMEChange == 14 || NameChange.NPCNAMEChange == 17 || NameChange.NPCNAMEChange == 20 || NameChange.NPCNAMEChange == 23 || NameChange.NPCNAMEChange == 25)
            {
                targetObject.GetComponent<Image>().enabled = false;
            }
            else if (NameChange.NPCNAMEChange == 11 || NameChange.NPCNAMEChange == 13 || NameChange.NPCNAMEChange == 15 || NameChange.NPCNAMEChange == 18 || NameChange.NPCNAMEChange == 22 || NameChange.NPCNAMEChange == 24 || NameChange.NPCNAMEChange == 26)
            {
                targetObject.GetComponent<Image>().enabled = true;
            }
        }
    }
}
