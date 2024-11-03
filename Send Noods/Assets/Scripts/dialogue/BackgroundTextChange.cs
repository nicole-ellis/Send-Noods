using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BackgroundTextChange : MonoBehaviour
{
    public DialogueController NameChange;
    public GameObject targetObject;
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
    }
}
