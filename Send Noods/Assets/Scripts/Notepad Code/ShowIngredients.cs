using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowIngredients : MonoBehaviour
{


    public GameObject Chives;
    public GameObject Chillis;
    public GameObject ThridFood;
    public BringChefBack BringChefBack;

    // Start is called before the first frame update
    void Start()
    {
        if (BringChefBack.FoodsComplete == 0)
        {
            Chives.GetComponent<Image>().enabled = false;
            Chillis.GetComponent<Image>().enabled = false;
            ThridFood.GetComponent<Image>().enabled = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
