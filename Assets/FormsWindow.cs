using UnityEngine;
using System.Collections;
using System.Linq;

public class FormsWindow : MonoBehaviour 
{
	public CursorCast cursorCast;

	[Header("Form Moving Params")]
	public bool allowMove = false;
	public RectTransform parentRect;
	public RectTransform windowRect;
	public BoxCollider2D headerTrigger;
	public BoxCollider2D blockingLayer;
	bool isMoving;
	bool isMouseHeld;

	void Update () 
	{
		if (!OperatingSystem._Instance.enabled) return;

		if (allowMove)
        {
			if (!isMoving && cursorCast.GetHit(headerTrigger) && !isMouseHeld)
			{
				isMoving = Input.GetMouseButton(0);
			}

			isMouseHeld = Input.GetMouseButton(0);

			if (isMoving)
            {
				isMoving = Input.GetMouseButton(0);
				windowRect.SetParent(cursorCast.windowHolder);
			}
			else windowRect.SetParent(parentRect);
		}
	}
}
