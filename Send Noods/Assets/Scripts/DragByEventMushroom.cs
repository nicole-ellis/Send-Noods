using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragByEventMushroom : MonoBehaviour
{

    private Vector3 startPos;

    public GameObject itemOnly2;
    public GameObject emptybowl2;
    public GameObject bowlwithitem2;
    public GameObject donebutton2;


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
        GameObject bowlGO = GameObject.Find("bowl2");

        float dist = Vector3.Distance(transform.position, bowlGO.transform.position);

        if(dist <= 600){
            //transform.position = bowlGO.transform.position;  
            //the object will be in the center of the bowl, this will change later
            itemOnly2.SetActive(false);
            emptybowl2.SetActive(false);
            bowlwithitem2.SetActive(true);
            donebutton2.SetActive(true);
        }    
        else{
            transform.position = startPos;
        }
    }
}
