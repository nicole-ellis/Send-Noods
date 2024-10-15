using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;


public class DragDrop : MonoBehaviour, IPointerDownHandler, IBeginDragHandler, IEndDragHandler, IDragHandler{

    public void OnPointerDown(PointerEventData eventData) {
        Debug.Log("Down");
    }

    public void OnBeginDrag(PointerEventData eventData){
        Debug.Log("Begin");
    }

    public void OnDrag(PointerEventData eventData)
    {
        Debug.Log("drag");
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        Debug.Log("end");
    }
}
