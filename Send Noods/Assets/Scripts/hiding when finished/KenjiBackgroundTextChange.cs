using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KenjiBackgroundTextChange : MonoBehaviour
{
    public DialogueController NameChange;
    public GameObject targetObject;
    private void Start()  // if yukio is talking change the colour of the text background to red
    {
        if (NameChange.NPCNAMEChange == 0)
        {
            targetObject.GetComponent<Image>().enabled = false;
        }
    }
    void Update()
    {
        if (NameChange.NPCNAMEChange == 28 || NameChange.NPCNAMEChange == 30 || NameChange.NPCNAMEChange == 32 || NameChange.NPCNAMEChange == 34 || NameChange.NPCNAMEChange == 39)
        {
            targetObject.GetComponent<Image>().enabled = false;
        }
        else if (NameChange.NPCNAMEChange == 29 || NameChange.NPCNAMEChange == 31 || NameChange.NPCNAMEChange == 33 || NameChange.NPCNAMEChange == 35)
        {
            targetObject.GetComponent<Image>().enabled = true;
        }




    }
}
