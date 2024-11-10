using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KenjiBackgroundTextChange : MonoBehaviour
{
    public DialogueController Kit;
    public DialogueController NameChange;
    public GameObject targetObject;
    public PackageAppear Package;





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
    private void Start()  // if yukio is talking change the colour of the text background to red
    {
        if (NameChange.NPCNAMEChange == 0)
        {
            targetObject.GetComponent<Image>().enabled = false;
        }
    }
    void Update()
    {

        if (Package.MushroomsCollected == 1)
        {


            if (Kit.KitchenShow < 3 && NameChange.NPCNAMEChange == 1 || Kit.KitchenShow < 3 && NameChange.NPCNAMEChange == 3 || Kit.KitchenShow < 3 && NameChange.NPCNAMEChange == 5 || Kit.KitchenShow < 3 && NameChange.NPCNAMEChange == 7 || Kit.KitchenShow < 3 && NameChange.NPCNAMEChange == 12)
            {
                targetObject.GetComponent<Image>().enabled = false;
            }
            else if (Kit.KitchenShow < 3 && NameChange.NPCNAMEChange == 2 || Kit.KitchenShow < 3 && NameChange.NPCNAMEChange == 4 || Kit.KitchenShow < 3 && NameChange.NPCNAMEChange == 6 || Kit.KitchenShow < 3 && NameChange.NPCNAMEChange == 8)
            {
                targetObject.GetComponent<Image>().enabled = true;
            }
        }


        if (NFwho.RENAMECHANGE == 1)
        {



            if (NameChange.NPCNAMEChange == 1)
            {
                targetObject.GetComponent<Image>().enabled = false;
            }
            else if (NameChange.NPCNAMEChange == 2)
            {
                targetObject.GetComponent<Image>().enabled = true;
            }
        }
        if (NFWhere.RENAMECHANGE == 1)
        {
             
            if (NameChange.NPCNAMEChange == 1)
            {
                targetObject.GetComponent<Image>().enabled = false;
            }
            else if (NameChange.NPCNAMEChange == 2)
            {
                targetObject.GetComponent<Image>().enabled = true;
            }
        }
        if (NFAlive.RENAMECHANGE == 1)
        {

             
            if (NameChange.NPCNAMEChange == 1)
            {
                targetObject.GetComponent<Image>().enabled = false;
            }
            else if (NameChange.NPCNAMEChange == 2)
            {
                targetObject.GetComponent<Image>().enabled = true;
            }
        }



        if (CHILwho.RENAMECHANGE == 1)
        {

             
            if (NameChange.NPCNAMEChange == 1)
            {
                targetObject.GetComponent<Image>().enabled = false;
            }
            else if (NameChange.NPCNAMEChange == 2)
            {
                targetObject.GetComponent<Image>().enabled = true;
            }
        }
        if (CHILWhere.RENAMECHANGE == 1)
        {

             
            if (NameChange.NPCNAMEChange == 1)
            {
                targetObject.GetComponent<Image>().enabled = false;
            }
            else if (NameChange.NPCNAMEChange == 2)
            {
                targetObject.GetComponent<Image>().enabled = true;
            }
        }
        if (CHILAlive.RENAMECHANGE == 1)
        {

             
            if (NameChange.NPCNAMEChange == 1)
            {
                targetObject.GetComponent<Image>().enabled = false;
            }
            else if (NameChange.NPCNAMEChange == 2)
            {
                targetObject.GetComponent<Image>().enabled = true;
            }
        }




        if (CHIVwho.RENAMECHANGE == 1)
        {

             
            if (NameChange.NPCNAMEChange == 1)
            {
                targetObject.GetComponent<Image>().enabled = false;
            }
            else if (NameChange.NPCNAMEChange == 2)
            {
                targetObject.GetComponent<Image>().enabled = true;
            }
        }
        if (CHIVWhere.RENAMECHANGE == 1)
        {

             
            if (NameChange.NPCNAMEChange == 1)
            {
                targetObject.GetComponent<Image>().enabled = false;
            }
            else if (NameChange.NPCNAMEChange == 2)
            {
                targetObject.GetComponent<Image>().enabled = true;
            }
        }
        if (CHIVAlive.RENAMECHANGE == 1)
        {

             
            if (NameChange.NPCNAMEChange == 1)
            {
                targetObject.GetComponent<Image>().enabled = false;
            }
            else if (NameChange.NPCNAMEChange == 2)
            {
                targetObject.GetComponent<Image>().enabled = true;
            }
        }



        if (MUSHwho.RENAMECHANGE == 1)
        {

             
            if (NameChange.NPCNAMEChange == 1)
            {
                targetObject.GetComponent<Image>().enabled = false;
            }
            else if (NameChange.NPCNAMEChange == 2)
            {
                targetObject.GetComponent<Image>().enabled = true;
            }
        }
        if (MUSHWhere.RENAMECHANGE == 1)
        {

             
            if (NameChange.NPCNAMEChange == 1)
            {
                targetObject.GetComponent<Image>().enabled = false;
            }
            else if (NameChange.NPCNAMEChange == 2)
            {
                targetObject.GetComponent<Image>().enabled = true;
            }
        }
        if (MUSHAlive.RENAMECHANGE == 1)
        {

             
            if (NameChange.NPCNAMEChange == 1)
            {
                targetObject.GetComponent<Image>().enabled = false;
            }
            else if (NameChange.NPCNAMEChange == 2)
            {
                targetObject.GetComponent<Image>().enabled = true;
            }
        }
    }
}
