using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class CursorInputModule : PointerInputModule
{
    public CursorBehaviour cursor;
    public string ClickInputName = "Submit";
    public RaycastResult CurrentRaycast;

    private PointerEventData pointerEventData;
    private GameObject currentLookAtHandler;

    public override void Process()
    {
        SetPointerPosition();
        HandleRaycast();
        HandleSelection();
    }

    private void SetPointerPosition()
    {
        if (pointerEventData == null)
        {
            pointerEventData = new PointerEventData(eventSystem);
        }

        // fake a pointer always being at the center of the screen
        pointerEventData.position = new Vector2((cursor.position.x / cursor.refRect.rect.width * 2) * Screen.width, (cursor.position.y / cursor.refRect.rect.height * 2) * Screen.height);
        Debug.Log(pointerEventData.position);
        pointerEventData.delta = Vector2.zero;
    }

    private void HandleRaycast()
    {
        List<RaycastResult> raycastResults = new List<RaycastResult>();
        eventSystem.RaycastAll(pointerEventData, raycastResults);
        CurrentRaycast = pointerEventData.pointerCurrentRaycast = FindFirstRaycast(raycastResults);

        ProcessMove(pointerEventData);
    }

    private void HandleSelection()
    {
        if (pointerEventData.pointerEnter != null)
        {
            GameObject handler = ExecuteEvents.GetEventHandler<IPointerClickHandler>(pointerEventData.pointerEnter);

            if (currentLookAtHandler != handler)
            {
                currentLookAtHandler = handler;
            }

            if (currentLookAtHandler != null && Input.GetMouseButtonDown(0))
            {
                ExecuteEvents.ExecuteHierarchy(currentLookAtHandler, pointerEventData, ExecuteEvents.pointerClickHandler);
            }
        }
        else
        {
            currentLookAtHandler = null;
        }
    }
}