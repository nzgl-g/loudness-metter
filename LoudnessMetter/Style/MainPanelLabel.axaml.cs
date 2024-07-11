using Avalonia;
using Avalonia.Controls;
using Avalonia.Controls.Primitives;

namespace LoudnessMetter.Style;

public class MainPanelLabel : TemplatedControl
{
  public static readonly StyledProperty<string> LargeTextProperty = AvaloniaProperty.Register<MainPanelLabel, string>(
    nameof(LargeText),"Large Text");

  public string LargeText
  {
    get => GetValue(LargeTextProperty);
    set => SetValue(LargeTextProperty, value);
  }  
  
  public static readonly StyledProperty<string> SmallTextProperty = AvaloniaProperty.Register<MainPanelLabel, string>(
    nameof(SmallText),"Small Text");

  public string SmallText
  {
    get => GetValue(SmallTextProperty);
    set => SetValue(SmallTextProperty, value);
  }
}