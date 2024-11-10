using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class KenjiNote : MonoBehaviour
{
    public GameObject targetObject; 
    public GameObject KENJIHIDE;
    public CHILWho CHILwho;
    public CHILWhere CHILWhere;
    public ChilAlive CHILAlive;


    public CHIVWho CHIVwho;
    public CHIVWhere CHIVWhere;
    public ChivAlive CHIVAlive;


    public MUSHWho MUSHwho;
    public MUSHWhere MUSHWhere;
    public MUSHAlive MUSHAlive;

    public int SAVECHIVWHO = 0;
    public int SAVECHIVWHERE = 0;
    public int SAVECHIVALIVE = 0;

    public int SAVECHILWHO = 0;
    public int SAVECHILWHERE = 0;
    public int SAVECHILALIVE = 0;

    public int SAVEMUSHWHO = 0;
    public int SAVEMUSHWHERE = 0;
    public int SAVEMUSHALIVE = 0;
    // Start is called before the first frame update
    void Start()
    {

        targetObject.GetComponent<Image>().enabled = false;
    }

    // Update is called once per frame
    void Update()
    {

        if (CHILwho.RENAMECHANGE == 1)
        {
            SAVECHILWHO = 1;
        }
        if (CHILWhere.RENAMECHANGE == 1)
        {
            SAVECHILWHERE = 1;
        }
        if (CHILAlive.RENAMECHANGE == 1)
        {
            SAVECHILALIVE = 1;
        }




        if (CHIVwho.RENAMECHANGE == 1)
        {
            SAVECHIVWHO = 1;
        }
        if (CHIVWhere.RENAMECHANGE == 1)
        {
            SAVECHIVWHERE = 1;
        }
        if (CHIVAlive.RENAMECHANGE == 1)
        {
            SAVECHIVALIVE = 1;
        }




        if (MUSHwho.RENAMECHANGE == 1)
        {
            SAVEMUSHWHO = 1;
        }
        if (MUSHWhere.RENAMECHANGE == 1)
        {
            SAVEMUSHWHERE = 1;
        }
        if (MUSHAlive.RENAMECHANGE == 1)
        {
            SAVEMUSHALIVE = 1;
        }
        
        if (SAVECHILALIVE == 1 && SAVECHILWHO == 1 && SAVECHILWHERE == 1 || SAVECHIVALIVE == 1 && SAVECHIVWHO == 1 && SAVECHIVWHERE == 1 || SAVEMUSHWHERE == 1 || SAVEMUSHWHERE == 1 || SAVEMUSHWHERE == 1)
        {
            targetObject.GetComponent<Image>().enabled = true;
        }
    }
}
