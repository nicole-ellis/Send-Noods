using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CHIVKWho : MonoBehaviour
{

    public CHIVWho CHIVwho;
    public CHIVWhere CHIVWhere;
    public ChivAlive CHIVAlive;

    public GameObject CHIVKenji;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (CHIVwho.CHIVQuestion1 == 0 && CHIVWhere.CHIVQuestion2 == 0 && CHIVAlive.CHIVQuestion3 == 0)
        {
            CHIVKenji.SetActive(false);
        }
    }
}
