using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnotherCustomerAnimation : MonoBehaviour
{
    public Animator AnimateController;
    public string AnimationName;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void playAnimation(){
        AnimateController.Play(AnimationName);
    }

    // Update is called once per frame
    void Update()
    {
        playAnimation();
    }
}
