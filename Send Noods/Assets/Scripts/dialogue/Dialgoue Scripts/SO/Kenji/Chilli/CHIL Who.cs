using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem.HID;
using Unity.VisualScripting;
using UnityEngine.UI;

public class CHILWho : MonoBehaviour
{

    public GameObject targetselfobject;

    public DialogueController Kit;
    public int CHILQuestion1 = 0;

    public Button myButton1;

    public CHILWhere CHILWhere;
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
        if (Kit.KitchenShow >= 3 && CHILQuestion1 == 0)
        {
            targetselfobject.GetComponent<Image>().enabled = true;
        }
        else if (CHILQuestion1 == 1)
        {
            targetselfobject.SetActive(false);
        }
        if (CHILWhere.CHILQuestion2 == 1 || CHILAlive.CHILQuestion3 == 1)
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
        CHILQuestion1 = CHILQuestion1 + 1;
    }
}
