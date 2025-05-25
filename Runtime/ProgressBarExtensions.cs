using UnityEngine.UIElements;

public static class ProgressBarExtensions
{
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
}