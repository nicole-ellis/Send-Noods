using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem.HID;
using Unity.VisualScripting;
using UnityEngine.UI;

public class ChilAlive : MonoBehaviour
{
    public GameObject targetselfobject;

    public DialogueController Kit;
    public int CHILQuestion3 = 0;

    public Button myButton1;

    public CHILWho CHILWho;
    public CHILWhere CHILWhere;

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
        if (Kit.KitchenShow >= 3 && CHILQuestion3 == 0)
        {
            targetselfobject.GetComponent<Image>().enabled = true;
        }
        else if (CHILQuestion3 == 1)
        {
            targetselfobject.SetActive(false);
        }
        if (CHILWhere.CHILQuestion2 == 1 || CHILWho.CHILQuestion1 == 1)
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
        CHILQuestion3 = CHILQuestion3 + 1;
    }
}
