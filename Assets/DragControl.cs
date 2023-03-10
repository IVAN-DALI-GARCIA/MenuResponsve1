using UnityEngine.EventSystems;
using UnityEngine;
using UnityEngine.UI;

public class DragControl : MonoBehaviour, IPointerUpHandler,IPointerDownHandler, IDragHandler, IBeginDragHandler, IEndDragHandler
{   
    Image image;
    public bool Pressed;
    // Start is called before the first frame update

    private void Awake() {
        image = GetComponent<Image>();
    }
    
    public void OnPointerUp(PointerEventData eventData)
    {
        Pressed = false;
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        Pressed = true;
    }

    public void OnDrag(PointerEventData eventData)
    {
        transform.position = eventData.position;
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        image.color = Color.green;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        image.color = Color.white;
    }
}
