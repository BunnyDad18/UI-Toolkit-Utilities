using UnityEngine.UIElements;

public static class TextElementExtensions
{
    public static T SetText<T>(this T label, string value) where T : TextElement
    {
        label.text = value;
        label.SetDisplay(!string.IsNullOrEmpty(value));
        return label;
    }
    
    public static Label SetTextBinding(this Label label, string bindingPath)
    {
        label.SetDataBinding(nameof(Label.text), bindingPath);
        return label;
    }
}