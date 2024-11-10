using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem.HID;
using Unity.VisualScripting;
using UnityEngine.UI;

public class ChivAlive : MonoBehaviour
{
    public GameObject targetselfobject;

    public DialogueController Kit;
    public int CHIVQuestion3 = 0;

    public Button myButton1;

    public CHIVWho CHIVWho;
    public CHIVWhere CHIVWhere;


    public int RENAMECHANGE = 0;

    private void Start()
    {
        {
            // Ensure the button is assigned and add a listener to it
            if (myButton1 != null)
            {
                myButton1.onClick.AddListener(OnButtonClick);
            }
        }
    }

    // Start is called before the first frame update
    void Update()
    {
        if (Kit.KitchenShow >= 3 && CHIVQuestion3 == 0)
        {
            targetselfobject.GetComponent<Image>().enabled = true;
        }
        else if (CHIVQuestion3 == 1)
        {
            targetselfobject.SetActive(false);
        }
        if (CHIVWhere.CHIVQuestion2 == 1 || CHIVWho.CHIVQuestion1 == 1)
        {
            targetselfobject.GetComponent<Image>().enabled = false;
        }
    }
    // Update is called once per frame
    void OnButtonClick()
    {
        RENAMECHANGE = 1;
        // Code to execute when the button is clicked
        Debug.Log("Button was clicked!");
        CHIVQuestion3 = CHIVQuestion3 + 1;
    }
}
