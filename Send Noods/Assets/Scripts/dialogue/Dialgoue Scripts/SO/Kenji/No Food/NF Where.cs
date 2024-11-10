using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem.HID;
using UnityEngine.UI;

public class NFWhere : MonoBehaviour
{
    public GameObject targetselfobject;

    public DialogueController Kit;
    public int NFQuestion2 = 0;

    public Button myButton1;

    public NFwho NFwho;
    public NFAlive NFAlive;

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
        if (Kit.KitchenShow >= 3 && NFQuestion2 == 0)
        {
            targetselfobject.GetComponent<Image>().enabled = true;
        }
        else if (NFQuestion2 == 1)
        {
                targetselfobject.SetActive(false);
        }
        if (NFwho.NFQuestion1 == 1 || NFAlive.NFQuestion3 == 1)
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
        NFQuestion2 = NFQuestion2 + 1;
    }
}