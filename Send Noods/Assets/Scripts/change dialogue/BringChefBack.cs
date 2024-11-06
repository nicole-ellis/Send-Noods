using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BringChefBack : MonoBehaviour
{
    [SerializeField] public GameObject actualchef; 
    public Button mybutton;
    [SerializeField] private GameObject visualchef;
    public hideCustomer hideC;


    void Start()
    {
        // Ensure the button is assigned in the Inspector or find it in the scene
        if (mybutton != null)
        {
            mybutton.onClick.AddListener(OnButtonClick);
        }
        else
        {
            Debug.LogWarning("Button not assigned in Inspector!");
        }
    }

    void OnButtonClick()
    {
        hideC.allowMoveChef = true;
        actualchef.GetComponent<SpriteRenderer>().enabled = true;
        actualchef.transform.position = visualchef.transform.position;
    }
}
