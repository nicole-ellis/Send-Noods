using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BackgroundTextChange : MonoBehaviour
{
    public DialogueController Kit;
    public DialogueController NameChange;
    public GameObject targetObject;
    public GameObject ChilliOrChives;
    public GameObject ChivesCust;
    public PackageAppear Package;
    private void Start() // if isagi is talking change the colour of the text background to blue
    {
        if (Kit.KitchenShow < 3 && NameChange.NPCNAMEChange == 0)
        {
            targetObject.GetComponent<Image>().enabled = false;
        }
    }
    void Update()
    {
        if (Kit.KitchenShow == 0)
        {
            if (Kit.KitchenShow < 3 && NameChange.NPCNAMEChange == 2 || Kit.KitchenShow < 3 && NameChange.NPCNAMEChange == 5 || Kit.KitchenShow < 3 && NameChange.NPCNAMEChange == 10)
            {
                targetObject.GetComponent<Image>().enabled = false;
            }
            else if (Kit.KitchenShow < 3 && NameChange.NPCNAMEChange == 1 || Kit.KitchenShow < 3 && NameChange.NPCNAMEChange == 3 || Kit.KitchenShow < 3 && NameChange.NPCNAMEChange == 6)
            {
                targetObject.GetComponent<Image>().enabled = true;
            }
        }





        if (ChilliOrChives.activeSelf)
        {
            if (Kit.KitchenShow < 3 && NameChange.NPCNAMEChange == 2 || Kit.KitchenShow < 3 && NameChange.NPCNAMEChange == 4 || Kit.KitchenShow < 3 && NameChange.NPCNAMEChange == 8 || Kit.KitchenShow < 3 && NameChange.NPCNAMEChange == 11 || Kit.KitchenShow < 3 && NameChange.NPCNAMEChange == 14 || Kit.KitchenShow < 3 && NameChange.NPCNAMEChange == 16)
            {
                targetObject.GetComponent<Image>().enabled = false;
            }
            else if (Kit.KitchenShow < 3 && NameChange.NPCNAMEChange == 1 || Kit.KitchenShow < 3 && NameChange.NPCNAMEChange == 3 || Kit.KitchenShow < 3 && NameChange.NPCNAMEChange == 5 || Kit.KitchenShow < 3 && NameChange.NPCNAMEChange == 9 || Kit.KitchenShow < 3 && NameChange.NPCNAMEChange == 13 || Kit.KitchenShow < 3 && NameChange.NPCNAMEChange == 15 || Kit.KitchenShow < 3 && NameChange.NPCNAMEChange == 17)
            {
                targetObject.GetComponent<Image>().enabled = true;
            }
        }
        else if (ChivesCust.activeSelf)
        {
            if (Kit.KitchenShow < 3 && NameChange.NPCNAMEChange == 2 || Kit.KitchenShow < 3 && NameChange.NPCNAMEChange == 4 || Kit.KitchenShow < 3 && NameChange.NPCNAMEChange == 7 || Kit.KitchenShow < 3 && NameChange.NPCNAMEChange == 10 || Kit.KitchenShow < 3 && NameChange.NPCNAMEChange == 13 || Kit.KitchenShow < 3 && NameChange.NPCNAMEChange == 15)
            {
                targetObject.GetComponent<Image>().enabled = false;
            }
            else if (Kit.KitchenShow < 3 && NameChange.NPCNAMEChange == 1 || Kit.KitchenShow < 3 && NameChange.NPCNAMEChange == 3 || Kit.KitchenShow < 3 && NameChange.NPCNAMEChange == 5 || Kit.KitchenShow < 3 && NameChange.NPCNAMEChange == 8 || Kit.KitchenShow < 3 && NameChange.NPCNAMEChange == 12 || Kit.KitchenShow < 3 && NameChange.NPCNAMEChange == 14 || Kit.KitchenShow < 3 && NameChange.NPCNAMEChange == 16)
            {
                targetObject.GetComponent<Image>().enabled = true;
            }
        }


    }
}
