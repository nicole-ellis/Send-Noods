using System.Collections;
using System.Collections.Generic;
using TMPro;
using TMPro.Examples;
using UnityEngine;
using UnityEngine.UI;


public class DialogueNameSystem : MonoBehaviour
{


    public DialogueController NameChange;
    public GameObject targetObject;
    public GameObject ChilliOrChives;


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





        if (ChilliOrChives.activeSelf)
        {
            if (NameChange.NPCNAMEChange == 12 || NameChange.NPCNAMEChange == 14 || NameChange.NPCNAMEChange == 18 || NameChange.NPCNAMEChange == 21 || NameChange.NPCNAMEChange == 24 || NameChange.NPCNAMEChange == 26)
            {
                targetObject.GetComponent<TextMeshProUGUI>().text = "Yukio";
            }
            else if (NameChange.NPCNAMEChange == 11 || NameChange.NPCNAMEChange == 13 || NameChange.NPCNAMEChange == 15 || NameChange.NPCNAMEChange == 19 || NameChange.NPCNAMEChange == 23 || NameChange.NPCNAMEChange == 25 || NameChange.NPCNAMEChange == 27)
            {
                targetObject.GetComponent<TextMeshProUGUI>().text = "Isagi";
            }
        }
        else
        {
            if (NameChange.NPCNAMEChange == 12 || NameChange.NPCNAMEChange == 14 || NameChange.NPCNAMEChange == 17 || NameChange.NPCNAMEChange == 20 || NameChange.NPCNAMEChange == 23 || NameChange.NPCNAMEChange == 25)
            {
                targetObject.GetComponent<TextMeshProUGUI>().text = "Yukio";
            }
            else if (NameChange.NPCNAMEChange == 11 || NameChange.NPCNAMEChange == 13 || NameChange.NPCNAMEChange == 15 || NameChange.NPCNAMEChange == 18 || NameChange.NPCNAMEChange == 22 || NameChange.NPCNAMEChange == 24 || NameChange.NPCNAMEChange == 26)
            {
                targetObject.GetComponent<TextMeshProUGUI>().text = "Isagi";
            }
        }


        if (NameChange.NPCNAMEChange == 28 || NameChange.NPCNAMEChange == 30 || NameChange.NPCNAMEChange == 32 || NameChange.NPCNAMEChange == 34 || NameChange.NPCNAMEChange == 39)
        {
            targetObject.GetComponent<TextMeshProUGUI>().text = "Yukio";
        }
        else if (NameChange.NPCNAMEChange == 29 || NameChange.NPCNAMEChange == 31 || NameChange.NPCNAMEChange == 33 || NameChange.NPCNAMEChange == 35)
        {
            targetObject.GetComponent<TextMeshProUGUI>().text = "Kenji";
        }
    }
}
