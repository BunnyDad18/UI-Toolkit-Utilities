using System;
using System.Collections.Generic;
using UnityEngine.UIElements;

public static class VisualElementExtensions
{
    public static void Display(this VisualElement element, bool enabled)
    {
        if (element == null) return;
        element.style.display = enabled ? DisplayStyle.Flex : DisplayStyle.None;
    }
    
    public static void SetText(this Label label, string value)
    {
        label.text = value;
        label.Display(value != string.Empty);
    }

    public static T Parent<T>(this T element, VisualElement parent) where T : VisualElement
    {
        parent.Add(element);
        return element;
    }

    public static T AddToClassList<T>(this T element, params string[] classes) where T : VisualElement
    {
        foreach (string item in classes)
        {
            element.AddToClassList(item);
        }
        return element;
    }

    public static T RemoveClasses<T>(this T element, params string[] classes) where T : VisualElement
    {
        foreach(string item in classes)
        {
            element.RemoveFromClassList(item);
        }
        return element;
    }

    public static Button SetAction(this Button button, Action action)
    {
        button.clicked += action;
        return button;
    }
}
