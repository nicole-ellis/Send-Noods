using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem.HID;
using Unity.VisualScripting;
using UnityEngine.UI;

public class MUSHWho : MonoBehaviour
{

    public GameObject targetselfobject;

    public DialogueController Kit;
    public int MUSHQuestion1 = 0;

    public Button myButton1;

    public MUSHWhere MUSHWhere;
    public MUSHAlive MUSHAlive;

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
        if (Kit.KitchenShow >= 3 && MUSHQuestion1 == 0)
        {
            targetselfobject.GetComponent<Image>().enabled = true;
        }
        else if (MUSHQuestion1 == 1)
        {
            targetselfobject.SetActive(false);
        }
        if (MUSHWhere.MUSHQuestion2 == 1 || MUSHAlive.MUSHQuestion3 == 1)
        {
            targetselfobject.SetActive(false);
        }
    }
    // Update is called once per frame
    void OnButtonClick()
    {
        RENAMECHANGE = 1;
        // Code to execute when the button is clicked
        Debug.Log("Button was clicked!");
        MUSHQuestion1 = MUSHQuestion1 + 1;
    }
}
