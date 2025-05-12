#if UNITY_EDITOR
using UnityEngine.UIElements;

namespace Editor
{
    public static class EditorExtensions
    {
        public static T SetBindingPath<T>(this T element, string bindingPath) where T : IBindable
        {
            element.bindingPath = bindingPath;
            return element;
        }

        public static Foldout SetText(this Foldout foldout, string text)
        {
            foldout.text = text;
            return foldout;
        }
    }
}
#endif