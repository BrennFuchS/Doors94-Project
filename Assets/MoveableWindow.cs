using UnityEngine;
using UnityEngine.EventSystems;

namespace Doors94
{
    [AddComponentMenu("Doors94/Forms/MoveableWindow")]
    public class MoveableWindow : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
    {
        private bool dragging;
        private Vector2 offset;

        public void Update()
        {
            if (dragging)
            {
                transform.localPosition = CursorBehaviour._Instance.position - offset;
            }
        }

        public void OnPointerDown(PointerEventData eventData)
        {
            dragging = true;
            offset = CursorBehaviour._Instance.position - new Vector2(transform.localPosition.x, transform.localPosition.y);
            transform.SetAsLastSibling();
        }

        public void OnPointerUp(PointerEventData eventData)
        {
            dragging = false;
        }
    }
}