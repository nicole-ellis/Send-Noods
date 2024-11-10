using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class AnotherCustomerAnimation : MonoBehaviour
{
    public PlayableDirector playableDirector;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void playAnimation(){
        playableDirector.Play();
    }

    // Update is called once per frame
    void Update()
    {
        playAnimation();
    }
}
