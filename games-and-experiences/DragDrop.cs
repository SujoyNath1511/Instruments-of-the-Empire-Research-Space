using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DragDrop : MonoBehaviour, IPointerDownHandler, IBeginDragHandler, IEndDragHandler, IDragHandler
{
    [SerializeField] private Canvas canvas;
    
    private RectTransform rectTransform;

    private void Awake() {
        rectTransform = GetComponent<RectTransform>();
    }
    
    public void OnPointerDown(PointerEventData eventData) {
        Debug.Log("Click");
    }


    public void OnBeginDrag(PointerEventData eventData) {
        Debug.Log("Begin Drag");
    }

    public void OnEndDrag(PointerEventData eventData) {
        Debug.Log("End Drag");
    }

    public void OnDrag(PointerEventData eventData) {
        Debug.Log("On Drag");
        rectTransform.anchoredPosition += eventData.delta / canvas.scaleFactor;
    }
    
}
