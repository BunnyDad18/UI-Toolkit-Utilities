using System;
using UnityEngine.UIElements;

public static class ListViewExtensions
{
    public static ListView SetMakeItem(this ListView listView, Func<VisualElement> function)
    {
        listView.makeItem = function;
        return listView;
    }

    public static ListView SetMakeItem<T>(this ListView listView) where T : VisualElement
    {
        listView.makeItem = Activator.CreateInstance<T>;
        return listView;
    }

    public static ListView SetBindItem<T>(this ListView listView, Action<T, int> action) where T : VisualElement
    {
        listView.bindItem = ((element, i) => action?.Invoke(element as T, i));
        return listView;
    }

    public static ListView SetBindItem<T,T2>(this ListView listView, Action<T, T2> action) where T : VisualElement
    {
        listView.bindItem = (element, i) =>
        {
            action?.Invoke(element as T, (T2)listView.itemsSource[i]);
        };
        return listView;
    }

    public static ListView SetItemsBinding(this ListView listView, string bindingPath)
    {
        listView.SetDataBinding(nameof(ListView.itemsSource), bindingPath);
        return listView;
    }

    public static ListView SetFixedHeight(this ListView listView, int fixedHeight)
    {
        listView.fixedItemHeight = fixedHeight;
        return listView;
    }
}
