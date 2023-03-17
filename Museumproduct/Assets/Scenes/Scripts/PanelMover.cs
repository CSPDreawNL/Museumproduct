using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class PanelMover : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    private bool move;

    public void OnPointerDown(PointerEventData eventData)
    {
        move = true;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        move = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(move) transform.position = Input.mousePosition;
    }
}
