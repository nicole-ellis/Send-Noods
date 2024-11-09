using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class NFKWho : MonoBehaviour
{

    public NFwho NFwho;
    public NFWhere NFWhere;
    public NFAlive NFAlive;

    public GameObject NFKenji;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (NFwho.NFQuestion1 == 0 && NFWhere.NFQuestion2 == 0 && NFAlive.NFQuestion3 == 0)
        {
            NFKenji.SetActive(false);
        }
    }
}
