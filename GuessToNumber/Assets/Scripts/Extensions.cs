using UnityEngine;

public static class Extensions
{
    public static GameObject Tag(this string tagName)
    {
        if (string.IsNullOrEmpty(tagName) || string.IsNullOrWhiteSpace(tagName))
            return default;

        return GameObject.FindWithTag(tagName);
    }
    public static T Then<T>(this GameObject gameObject) where T : Component
    {
        if (gameObject is null)
            return default;

        return gameObject.GetComponent<T>();
    }
}