using UnityEngine;
using UnityEngine.EventSystems;


namespace Doors94
{
    public class ModUIDrag : MonoBehaviour, IDragHandler, IPointerDownHandler, IPointerUpHandler, IBeginDragHandler
    {

        RectTransform m_transform = null;
        bool mouseDown = false;
        void Start()
        {
            m_transform = GetComponent<RectTransform>();
        }
        public void OnPointerDown(PointerEventData eventData)
        {
            transform.SetAsLastSibling(); //Set window on top when clicked on it
        }
        public void OnDrag(PointerEventData eventData)
        {
            // if (eventData.pointerEnter != null && eventData.pointerEnter == transform.GetChild(0)) //Only drag on header (Well this if doesn't work)
            // {
            m_transform.localPosition += new Vector3(CursorBehaviour._Instance.mouseInertia.x, CursorBehaviour._Instance.mouseInertia.y);
            //  }
        }

        public void OnBeginDrag(PointerEventData eventData)
        {
            // Debug.Log(eventData.delta);
        }

        public void OnPointerUp(PointerEventData eventData)
        {

        }
    }
}