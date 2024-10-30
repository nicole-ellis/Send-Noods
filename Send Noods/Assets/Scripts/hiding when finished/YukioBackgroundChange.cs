using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class YukioBackgroundChange : MonoBehaviour
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
        if (NameChange.NPCNAMEChange % 2 == 0)// if yukio is not talking hide the red text background
        {
            targetObject.GetComponent<Image>().enabled = true;
        }
        else
        {
            targetObject.GetComponent<Image>().enabled = false;
        }
    }
}
