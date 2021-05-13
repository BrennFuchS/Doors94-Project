using UnityEngine;

public class Deformable : MonoBehaviour
{
	public MeshFilter meshFilter;
	public float Hardness = 0.5f;
	public bool DeformMeshCollider = true;
	public float UpdateFrequency;
	public float MaxVertexMov;
	public Color32 DeformedVertexColor = Color.gray;
	public Texture2D HardnessMap;
}
