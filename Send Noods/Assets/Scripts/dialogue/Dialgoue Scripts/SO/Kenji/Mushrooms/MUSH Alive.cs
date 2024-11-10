using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem.HID;
using Unity.VisualScripting;
using UnityEngine.UI;

public class MUSHAlive : MonoBehaviour
{
    public GameObject targetselfobject;

    public DialogueController Kit;
    public int MUSHQuestion3 = 0;

    public Button myButton1;

    public MUSHWho MUSHWho;
    public MUSHWhere MUSHWhere;

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
        if (Kit.KitchenShow >= 3 && MUSHQuestion3 == 0)
        {
            targetselfobject.GetComponent<Image>().enabled = true;
        }
        else if (MUSHQuestion3 == 1)
        {

            targetselfobject.SetActive(false);
        }
        if (MUSHWhere.MUSHQuestion2 == 1 || MUSHWho.MUSHQuestion1 == 1)
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
        MUSHQuestion3 = MUSHQuestion3 + 1;
    }
}
