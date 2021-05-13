using UnityEditor;

public static class DeselectAll
{
    [MenuItem("Edit/Deselect All &a", false, -101)]
    static void Deselect()
    {
        Selection.activeGameObject = null;
    }
}