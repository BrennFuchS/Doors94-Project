using UnityEngine;
using UnityEngine.EventSystems;

namespace Doors94
{
	[AddComponentMenu("Doors94/MainSystems/CursorBehaviour")]
	public class CursorBehaviour : MonoBehaviour
	{
		internal static CursorBehaviour _Instance;

		[Header("Cursor Values")]
		public RectTransform refRect;
		public RectTransform cursorRect;
		public Vector2 bounds;
		public Vector2 position;
		public float sensitivity;
		public Vector2 mouseInertia;

		void Start()
        {
			_Instance = this;
		}

		void LateUpdate()
		{
			bounds.x = refRect.rect.width / 2;
			bounds.y = refRect.rect.height / 2;

			if (!OperatingSystem._Instance.enabled) return;

			mouseInertia.x = Input.GetAxis("Mouse X") * sensitivity;
			mouseInertia.y = Input.GetAxis("Mouse Y") * sensitivity;

			position.x = Mathf.Clamp(position.x + mouseInertia.x, -bounds.x, bounds.x - 1);
			position.y = Mathf.Clamp(position.y + mouseInertia.y, -(bounds.y - 1), bounds.y);

			cursorRect.localPosition = position;
		}
	}
}