using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CHILKWho : MonoBehaviour
{

    public CHILWho CHILwho;
    public CHILWhere CHILWhere;
    public ChilAlive CHILAlive;

    public GameObject CHILKenji;



    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (CHILwho.CHILQuestion1 == 0 && CHILWhere.CHILQuestion2 == 0 && CHILAlive.CHILQuestion3 == 0)
        {
            CHILKenji.SetActive(false);
        }
    }
}
