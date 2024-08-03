using System;
using UnityEngine.UIElements;
using Object = UnityEngine.Object;

public class VisualElementSingleton<T> : VisualElement where T : VisualElement
{
    private static T _instance;

    public static T Instance
    {
        get
        {
            if (_instance != null) return _instance;
            
            UIDocument uiDocument = Object.FindFirstObjectByType<UIDocument>();
            _instance = uiDocument.rootVisualElement.Q<T>();
            
            if (_instance != null) return _instance;
            
            _instance = Activator.CreateInstance<T>();
            uiDocument.rootVisualElement.Add(_instance);

            return _instance;
        }
    }
}
