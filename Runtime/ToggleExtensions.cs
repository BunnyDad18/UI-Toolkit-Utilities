using System;
using UnityEngine.UIElements;

public static class ToggleExtensions
{
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
}