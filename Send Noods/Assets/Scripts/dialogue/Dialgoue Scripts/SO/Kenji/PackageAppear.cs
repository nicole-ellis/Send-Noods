using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PackageAppear : MonoBehaviour
{

    public DialogueController Kit;
    public GameObject targetObject;
    public Button mybutton;
    private int MushroomsCollected = 0;
    void Start()
    {

        if (mybutton != null)
        {
            mybutton.onClick.AddListener(OnButtonClick);
        }
        else
        {
            Debug.LogWarning("Button not assigned in Inspector!");
        }
        if (Kit.KitchenShow == 0)
        {
            targetObject.GetComponent<Image>().enabled = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if ((Kit.KitchenShow) == 2 && MushroomsCollected == 0) // if the conversation has ended show the Kitchen button
        {
            targetObject.GetComponent<Image>().enabled = true;
        }
    }

    void OnButtonClick()
    {
        MushroomsCollected = MushroomsCollected + 1;
        targetObject.GetComponent<Image>().enabled = false;
    }
}
