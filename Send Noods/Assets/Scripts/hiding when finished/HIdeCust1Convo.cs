using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HIdeCust1Convo : MonoBehaviour
{


    public BringChefBack BringChefBack;
    public GameObject targetObject;



    // Start is called before the first frame update
    void Start()
    {
        if (BringChefBack.FoodsComplete == 0)
        {
            targetObject.SetActive(true);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (BringChefBack.FoodsComplete == 1)
        {
            targetObject.SetActive(false);
        }
    }
}
