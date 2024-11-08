using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KenjiBackgroundTextChange : MonoBehaviour
{
    public DialogueController NameChange;
    public GameObject targetObject;
    public GameObject ChilliOrChives;
    public DialogueController Kit;
    private void Start()  // if yukio is talking change the colour of the text background to red
    {
        if (NameChange.NPCNAMEChange == 0)
        {
            targetObject.GetComponent<Image>().enabled = false;
        }
    }
    void Update()
    {
        if (NameChange.NPCNAMEChange == 27)
        {

        }





    }
}
