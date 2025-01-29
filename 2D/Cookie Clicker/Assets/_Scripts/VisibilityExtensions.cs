using UnityEngine;

public static class VisibilityExtensions
{
    public static void Show(this GameObject gameObject) => gameObject.SetActive(true);
    public static void Hide(this GameObject gameObject) => gameObject.SetActive(false);
    public static void Toogle(this GameObject gameObject) => gameObject.SetActive(!gameObject.activeSelf);
}
