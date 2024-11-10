using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem.HID;
using Unity.VisualScripting;
using UnityEngine.UI;

public class CHIVWhere : MonoBehaviour
{
    public GameObject targetselfobject;

    public DialogueController Kit;
    public int CHIVQuestion2 = 0;

    public Button myButton1;

    public CHIVWho CHIVwho;
    public ChivAlive CHIVAlive;

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
        if (Kit.KitchenShow >= 3 && CHIVQuestion2 == 0)
        {
            targetselfobject.GetComponent<Image>().enabled = true;
        }
        else if (CHIVQuestion2 == 1)
        {
            targetselfobject.SetActive(false);
        }
        if (CHIVwho.CHIVQuestion1 == 1 || CHIVAlive.CHIVQuestion3 == 1)
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
        CHIVQuestion2 = CHIVQuestion2 + 1;
    }
}
