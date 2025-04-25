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
    
    public static bool Displayed(this VisualElement element)
    {
        return element.style.display == DisplayStyle.Flex;
    }

    public static T SetText<T>(this T label, string value) where T : TextElement
    {
        label.text = value;
        label.Display(value != string.Empty);
        return label;
    }

    public static ProgressBar SetText(this ProgressBar bar, string value)
    {
        bar.title = value;
        return bar;
    }

    public static ProgressBar SetHigh(this ProgressBar bar, float value)
    {
        bar.highValue = value;
        return bar;
    }

    public static Button SetText(this Button button, string value)
    {
        button.text = value;
        return button;
    }

	public static Toggle SetAction(this Toggle toggle, Action<bool> action)
	{
		toggle.RegisterValueChangedCallback((value) => {
			action?.Invoke(value.newValue);
		});
		return toggle;
	}

	public static Toggle SetValue(this Toggle toggle, bool value)
	{
		toggle.value = value;
		return toggle;
	}

	public static Toggle SetText(this Toggle toggle, string value)
	{
		toggle.text = value;
		return toggle;
	}

    public static T Parent<T>(this T element, VisualElement parent) where T : VisualElement
    {
        parent.Add(element);
        return element;
    }

    public static T SetName<T>(this T element, string name) where T : VisualElement
    {
        element.name = name;
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
