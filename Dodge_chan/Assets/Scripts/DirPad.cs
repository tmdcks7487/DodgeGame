using UnityEngine;
using UnityEngine.EventSystems;

public class DirPad : EventTrigger
{
    private Vector2 startPosition;
    public bool dragging { get; private set; }
    private Vector2 currentPosition;
    public Vector2 dir { get { return currentPosition - startPosition; } }

    public override void OnBeginDrag(PointerEventData eventData)
    {
        base.OnBeginDrag(eventData);
        startPosition = eventData.position;//터치 시작한 부분
        dragging = true;//bool타입
    }
    public override void OnDrag(PointerEventData eventData)//drag시작
    {
        base.OnDrag(eventData);
        currentPosition = eventData.position;
    }
    public override void OnEndDrag(PointerEventData eventData)//drag종료
    {
        base.OnEndDrag(eventData);
        dragging = false;
    }
}
 


