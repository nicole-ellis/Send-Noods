using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartingKenjihide : MonoBehaviour
{

    public DialogueController Kit;
    public GameObject targetObject;
    public GameObject QuestionReveal1;
    public GameObject QuestionReveal2;
    public GameObject QuestionReveal3;
    public GameObject ShowPlaceHolder;


    public Vector3 currentPosition; // Variable to store the current position
    public Vector3 newPosition;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Kit.KitchenShow == 3)
        {
            QuestionReveal1.GetComponent<Image>().enabled = true;
            QuestionReveal2.GetComponent<Image>().enabled = true;
            QuestionReveal3.GetComponent<Image>().enabled = true;
            ShowPlaceHolder.GetComponent<SpriteRenderer>().enabled = true;
            targetObject.SetActive(false);
        }
    }
}
