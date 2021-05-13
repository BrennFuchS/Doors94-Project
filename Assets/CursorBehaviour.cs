using UnityEngine;
using UnityEngine.EventSystems;

public class CursorBehaviour : MonoBehaviour 
{
	[Header("Cursor Values")]
	public RectTransform refRect;
	public RectTransform cursorRect;
	public Vector2 bounds;
	public Vector2 position;
	public float sensitivity;
	public Vector2 mouseInertia;

	void FixedUpdate()
    {
		bounds.x = refRect.rect.width / 2;
		bounds.y = refRect.rect.height / 2;
	}

	void Update () 
	{
		if (!OperatingSystem._Instance.enabled) return;

		mouseInertia.x = Input.GetAxis("Mouse X");
		mouseInertia.y = Input.GetAxis("Mouse Y");

		position.x = Mathf.FloorToInt(Mathf.Clamp(position.x + (mouseInertia.x * sensitivity), -bounds.x, bounds.x -1));
		position.y = Mathf.FloorToInt(Mathf.Clamp(position.y + (mouseInertia.y * sensitivity), -(bounds.y -1), bounds.y));

		cursorRect.localPosition = position;
	}
}
