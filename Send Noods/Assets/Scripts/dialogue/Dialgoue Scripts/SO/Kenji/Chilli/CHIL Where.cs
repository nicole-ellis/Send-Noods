using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem.HID;
using Unity.VisualScripting;
using UnityEngine.UI;

public class CHILWhere : MonoBehaviour
{
    public GameObject targetselfobject;

    public DialogueController Kit;
    public int CHILQuestion2 = 0;

    public Button myButton1;

    public CHILWho CHILwho;
    public ChilAlive CHILAlive;

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
        if (Kit.KitchenShow >= 3 && CHILQuestion2 == 0)
        {
            targetselfobject.GetComponent<Image>().enabled = true;
        }
        else if (CHILQuestion2 == 1)
        {
            targetselfobject.SetActive(false);
        }
        if (CHILwho.CHILQuestion1 == 1 || CHILAlive.CHILQuestion3 == 1)
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
        CHILQuestion2 = CHILQuestion2 + 1;
    }
}
