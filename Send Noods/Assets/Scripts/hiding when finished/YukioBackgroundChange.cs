using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class YukioBackgroundChange : MonoBehaviour
{
    public DialogueController Kit;
    public DialogueController NameChange;
    public GameObject targetObject;
    public GameObject ChilliOrChives;
    public GameObject ChivesCust;
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
                targetObject.GetComponent<Image>().enabled = true;
            }
            else if (Kit.KitchenShow < 3 && NameChange.NPCNAMEChange == 1 || Kit.KitchenShow < 3 && NameChange.NPCNAMEChange == 3 || Kit.KitchenShow < 3 && NameChange.NPCNAMEChange == 6)
            {
                targetObject.GetComponent<Image>().enabled = false;
            }
        }





        if (ChilliOrChives.activeSelf)
        {
            if (Kit.KitchenShow < 3 && NameChange.NPCNAMEChange == 2 || Kit.KitchenShow < 3 && NameChange.NPCNAMEChange == 4 || Kit.KitchenShow < 3 && NameChange.NPCNAMEChange == 8 || Kit.KitchenShow < 3 && NameChange.NPCNAMEChange == 11 || Kit.KitchenShow < 3 && NameChange.NPCNAMEChange == 14 || Kit.KitchenShow < 3 && NameChange.NPCNAMEChange == 16)
            {
                targetObject.GetComponent<Image>().enabled = true;
            }
            else if (Kit.KitchenShow < 3 && NameChange.NPCNAMEChange == 1 || Kit.KitchenShow < 3 && NameChange.NPCNAMEChange == 3 || Kit.KitchenShow < 3 && NameChange.NPCNAMEChange == 5 || Kit.KitchenShow < 3 && NameChange.NPCNAMEChange == 9 || Kit.KitchenShow < 3 && NameChange.NPCNAMEChange == 13 || Kit.KitchenShow < 3 && NameChange.NPCNAMEChange == 15 || Kit.KitchenShow < 3 && NameChange.NPCNAMEChange == 17)
            {
                targetObject.GetComponent<Image>().enabled = false;
            }
        }
        else if (ChivesCust.activeSelf)
        {
            if (Kit.KitchenShow < 3 && NameChange.NPCNAMEChange == 2 || Kit.KitchenShow < 3 && NameChange.NPCNAMEChange == 4 || Kit.KitchenShow < 3 && NameChange.NPCNAMEChange == 7 || Kit.KitchenShow < 3 && NameChange.NPCNAMEChange == 10 || Kit.KitchenShow < 3 && NameChange.NPCNAMEChange == 13 || Kit.KitchenShow < 3 && NameChange.NPCNAMEChange == 15)
            {
                targetObject.GetComponent<Image>().enabled = true;
            }
            else if (Kit.KitchenShow < 3 && NameChange.NPCNAMEChange == 1 || Kit.KitchenShow < 3 && NameChange.NPCNAMEChange == 3 || Kit.KitchenShow < 3 && NameChange.NPCNAMEChange == 5 || Kit.KitchenShow < 3 && NameChange.NPCNAMEChange == 8 || Kit.KitchenShow < 3 && NameChange.NPCNAMEChange == 12 || Kit.KitchenShow < 3 && NameChange.NPCNAMEChange == 14 || Kit.KitchenShow < 3 && NameChange.NPCNAMEChange == 16)
            {
                targetObject.GetComponent<Image>().enabled = false;
            }
        }

        if (Package.MushroomsCollected == 1)
        {


            if (Kit.KitchenShow < 3 && NameChange.NPCNAMEChange == 1 || Kit.KitchenShow < 3 && NameChange.NPCNAMEChange == 3 || Kit.KitchenShow < 3 && NameChange.NPCNAMEChange == 5 || Kit.KitchenShow < 3 && NameChange.NPCNAMEChange == 7 || Kit.KitchenShow < 3 && NameChange.NPCNAMEChange == 12)
            {
                targetObject.GetComponent<Image>().enabled = true;
            }
            else if (Kit.KitchenShow < 3 && NameChange.NPCNAMEChange == 2 || Kit.KitchenShow < 3 && NameChange.NPCNAMEChange == 4 || Kit.KitchenShow < 3 && NameChange.NPCNAMEChange == 6 || Kit.KitchenShow < 3 && NameChange.NPCNAMEChange == 8)
            {
                targetObject.GetComponent<Image>().enabled = false;
            }
        }


        if (NFwho.RENAMECHANGE == 1)
        {



            if (NameChange.NPCNAMEChange == 1)
            {
                targetObject.GetComponent<Image>().enabled = true;
            }
            else if (NameChange.NPCNAMEChange == 2)
            {
                targetObject.GetComponent<Image>().enabled = false;
            }
        }
        if (NFWhere.RENAMECHANGE == 1)
        {
            if (NameChange.NPCNAMEChange == 1)
            {
                targetObject.GetComponent<Image>().enabled = true;
            }
            else if (NameChange.NPCNAMEChange == 2)
            {
                targetObject.GetComponent<Image>().enabled = false;
            }
        }
        if (NFAlive.RENAMECHANGE == 1)
        {

            if (NameChange.NPCNAMEChange == 1)
            {
                targetObject.GetComponent<Image>().enabled = true;
            }
            else if (NameChange.NPCNAMEChange == 2)
            {
                targetObject.GetComponent<Image>().enabled = false;
            }
        }



        if (CHILwho.RENAMECHANGE == 1)
        {

             
            if (NameChange.NPCNAMEChange == 1)
            {
                targetObject.GetComponent<Image>().enabled = true;
            }
            else if (NameChange.NPCNAMEChange == 2)
            {
                targetObject.GetComponent<Image>().enabled = false;
            }
        }
        if (CHILWhere.RENAMECHANGE == 1)
        {

             
            if (NameChange.NPCNAMEChange == 1)
            {
                targetObject.GetComponent<Image>().enabled = true;
            }
            else if (NameChange.NPCNAMEChange == 2)
            {
                targetObject.GetComponent<Image>().enabled = false;
            }
        }
        if (CHILAlive.RENAMECHANGE == 1)
        {

             
            if (NameChange.NPCNAMEChange == 1)
            {
                targetObject.GetComponent<Image>().enabled = true;
            }
            else if (NameChange.NPCNAMEChange == 2)
            {
                targetObject.GetComponent<Image>().enabled = false;
            }
        }




        if (CHIVwho.RENAMECHANGE == 1)
        {

             
            if (NameChange.NPCNAMEChange == 1)
            {
                targetObject.GetComponent<Image>().enabled = true;
            }
            else if (NameChange.NPCNAMEChange == 2)
            {
                targetObject.GetComponent<Image>().enabled = false;
            }
        }
        if (CHIVWhere.RENAMECHANGE == 1)
        {

             
            if (NameChange.NPCNAMEChange == 1)
            {
                targetObject.GetComponent<Image>().enabled = true;
            }
            else if (NameChange.NPCNAMEChange == 2)
            {
                targetObject.GetComponent<Image>().enabled = false;
            }
        }
        if (CHIVAlive.RENAMECHANGE == 1)
        {

             
            if (NameChange.NPCNAMEChange == 1)
            {
                targetObject.GetComponent<Image>().enabled = true;
            }
            else if (NameChange.NPCNAMEChange == 2)
            {
                targetObject.GetComponent<Image>().enabled = false;
            }
        }



        if (MUSHwho.RENAMECHANGE == 1)
        {

             
            if (NameChange.NPCNAMEChange == 1)
            {
                targetObject.GetComponent<Image>().enabled = true;
            }
            else if (NameChange.NPCNAMEChange == 2)
            {
                targetObject.GetComponent<Image>().enabled = false;
            }
        }
        if (MUSHWhere.RENAMECHANGE == 1)
        {

             
            if (NameChange.NPCNAMEChange == 1)
            {
                targetObject.GetComponent<Image>().enabled = true;
            }
            else if (NameChange.NPCNAMEChange == 2)
            {
                targetObject.GetComponent<Image>().enabled = false;
            }
        }
        if (MUSHAlive.RENAMECHANGE == 1)
        {

             
            if (NameChange.NPCNAMEChange == 1)
            {
                targetObject.GetComponent<Image>().enabled = true;
            }
            else if (NameChange.NPCNAMEChange == 2)
            {
                targetObject.GetComponent<Image>().enabled = false;
            }
        }
    }
}
