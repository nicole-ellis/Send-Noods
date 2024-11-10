using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MUSHKWho : MonoBehaviour
{

    public MUSHWho MUSHwho;
    public MUSHWhere MUSHWhere;
    public MUSHAlive MUSHAlive;

    public GameObject MUSHKenji;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (MUSHwho.MUSHQuestion1 == 0 && MUSHWhere.MUSHQuestion2 == 0 && MUSHAlive.MUSHQuestion3 == 0)
        {
            MUSHKenji.SetActive(false);
        }
    }
}
