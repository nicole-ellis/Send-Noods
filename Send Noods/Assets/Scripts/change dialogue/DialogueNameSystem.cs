using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;


public class DialogueNameSystem : MonoBehaviour
{


    public DialogueController NameChange;
    public GameObject targetObject;


    private void Start() // if the conversation has not ended show the customer
    {
        if (NameChange.NPCNAMEChange == 0)
        {
            targetObject.GetComponent<TextMeshProUGUI>().text = "Isagi";
        }

    }

    private void Update()
    {
        if (NameChange.NPCNAMEChange == 2 || NameChange.NPCNAMEChange == 5 || NameChange.NPCNAMEChange == 10)
        {
            targetObject.GetComponent<TextMeshProUGUI>().text = "Yukio";
        }
        else if (NameChange.NPCNAMEChange == 1 || NameChange.NPCNAMEChange == 3 || NameChange.NPCNAMEChange == 6)
        {
            targetObject.GetComponent<TextMeshProUGUI>().text = "Isagi";
        }
    }
}
