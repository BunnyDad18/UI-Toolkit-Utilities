using System;
using UnityEngine.UIElements;

public static class ButtonExtensions
{
    public static Button SetText(this Button button, string value)
    {
        button.text = value;
        return button;
    }

    public static Button SetAction(this Button button, Action action)
    {
        button.clicked += action;
        return button;
    }
}