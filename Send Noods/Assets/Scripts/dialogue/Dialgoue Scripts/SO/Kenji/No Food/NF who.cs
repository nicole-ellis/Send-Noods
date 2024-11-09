using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem.HID;
using UnityEngine.UI;

public class NFwho : MonoBehaviour
{

    public GameObject targetselfobject;

    public DialogueController Kit;
    public int NFQuestion1 = 0;

    public Button myButton1;

    public NFWhere NFWhere;
    public NFAlive NFAlive;

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
        if (Kit.KitchenShow >= 3 && NFQuestion1 == 0)
        {
            targetselfobject.GetComponent<Image>().enabled = true;
        }
        else if (NFQuestion1 == 1)
        {
            targetselfobject.SetActive(false);
        }
        if (NFWhere.NFQuestion2 == 1 || NFAlive.NFQuestion3 == 1)
        {
            targetselfobject.GetComponent<Image>().enabled = false;
        }
    }
        // Update is called once per frame
        void OnButtonClick()
        {
            // Code to execute when the button is clicked
            Debug.Log("Button was clicked!");
        NFQuestion1 = NFQuestion1 + 1;
        }
}
