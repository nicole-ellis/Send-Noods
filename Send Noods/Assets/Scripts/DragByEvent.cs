using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragByEvent : MonoBehaviour
{
    private Vector3 startPos;

    public GameObject itemOnly;
    public GameObject emptybowl;
    public GameObject bowlwithitem;
    public GameObject donebutton;


    // Start is called before the first frame update
    void Start()
    {
        startPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void DragMethod(){
        transform.position = Input.mousePosition;
    }

    public void EndDragMethod(){
        GameObject bowlGO = GameObject.Find("bowl");

        float dist = Vector3.Distance(transform.position, bowlGO.transform.position);

        if(dist <= 600){
            //transform.position = bowlGO.transform.position;  
            //the object will be in the center of the bowl, this will change later
            itemOnly.SetActive(false);
            emptybowl.SetActive(false);
            bowlwithitem.SetActive(true);
            donebutton.SetActive(true);
        }    
        else{
            transform.position = startPos;
        }
    }
}
