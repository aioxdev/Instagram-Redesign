using Avalonia.Controls;
using Avalonia.Input;

namespace InstagramReDesign
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        protected override void OnPointerPressed(PointerPressedEventArgs e)
        {
            this.BeginMoveDrag(e);
        }
    }
}