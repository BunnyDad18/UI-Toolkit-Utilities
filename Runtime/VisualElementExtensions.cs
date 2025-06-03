using Unity.Properties;
using UnityEngine;
using UnityEngine.UIElements;

public static class VisualElementExtensions
{
    public static T SetDisplay<T>(this T visualElement, bool display) where T : VisualElement
    {
        visualElement.style.display = display ? DisplayStyle.Flex : DisplayStyle.None;
        return visualElement;
    }
    
    public static bool GetDisplayed(this VisualElement element)
    {
        return element.style.display == DisplayStyle.Flex;
    }
    
    public static T SetParent<T>(this T element, VisualElement parent) where T : VisualElement
    {
        parent.Add(element);
        return element;
    }

    public static T SetDataSource<T>(this T element, object dataSource) where T : VisualElement
    {
        element.dataSource = dataSource;
        return element;
    }

    public static T SetDataBinding<T>(this T element, string bindingTarget, string bindingSource, BindingMode mode = BindingMode.TwoWay)
        where T : VisualElement
    {
        element.SetBinding(bindingTarget, new DataBinding() { dataSourcePath = new PropertyPath(bindingSource), bindingMode = mode});
        return element;
    }

    public static T SetName<T>(this T element, string name) where T : VisualElement
    {
        element.name = name;
        return element;
    }

    public static T SetClasses<T>(this T element, params string[] classes) where T : VisualElement
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

    public static T SetPosition<T>(this T element, Vector3 position) where T : VisualElement
    {
        element.style.bottom = position.y;
        element.style.left = position.x;
        return element;
    }

    public static Vector2 GetPosition<T>(this T element) where T : VisualElement
    {
        return new Vector2(element.style.left.value.value, element.style.top.value.value);
    }
}
