using UnityEngine;

public static class VisibilityExtension
{
    public static void Show(this GameObject obj) => obj.SetActive(true);
    public static void Hide(this GameObject obj) => obj.SetActive(false);
}
