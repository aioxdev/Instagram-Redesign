using Avalonia;
using Avalonia.Controls;
using Avalonia.Controls.Primitives;
using Avalonia.Markup.Xaml;

namespace InstagramReDesign.Components;

public partial class NavBar : UserControl
{
    public NavBar()
    {
        InitializeComponent();
    }

    private void ToggleButton_Checked(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
    {
        foreach (ToggleButton item in navList.Children)
        {
            if(item==sender as ToggleButton)
            {
                item.IsEnabled = false;
            }
            else if(item!=sender as ToggleButton)
            {
                item.IsChecked= false;
                item.IsEnabled = true;
            }
        }
    }
}