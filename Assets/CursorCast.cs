using UnityEngine;
using System.Linq;

public class CursorCast : MonoBehaviour 
{
	public RectTransform cursorRect;
	public Transform windowHolder;

	[Header("Trigger detection")]
	public bool hasHit;
	public Collider2D[] orderedCols;
	public Collider2D hitCol;
	public LayerMask mask;

	public Vector2 top_right_corner;
	public Vector2 bottom_left_corner;

	void Update () 
	{
		if (!OperatingSystem._Instance.enabled) return;

		windowHolder.localPosition = cursorRect.localPosition;

		Collider2D[] hitCols = Physics2D.OverlapAreaAll(new Vector2(cursorRect.position.x - top_right_corner.x, cursorRect.position.y - top_right_corner.y), new Vector2(cursorRect.position.x - bottom_left_corner.x, cursorRect.position.y - bottom_left_corner.y), mask);

		if (hitCols.Length > 0)
        {
			hasHit = true;

			Transform[] transforms = hitCols.Select(x => x.transform).ToArray().OrderBy(x => x.GetSiblingIndex()).ToArray();
			orderedCols = transforms.Select(x => x.GetComponent<Collider2D>()).ToArray();

			hitCol = orderedCols[orderedCols.Length - 1];
		}
		else
        {
			hasHit = false;

			orderedCols = new Collider2D[0];
			hitCol = null;
		}
	}

	public bool GetHit(Collider2D trigger) { return hasHit && (trigger == hitCol); }
}
