using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Packagedisappear : MonoBehaviour
{

    public GameObject targetObject;

    void OnButtonClick()
    {
        targetObject.SetActive(false);
    }
}
