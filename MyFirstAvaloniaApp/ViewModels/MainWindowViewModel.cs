using Avalonia.Media;
using ReactiveUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace MyFirstAvaloniaApp.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        SolidColorBrush colorBrush;

        public MainWindowViewModel()
        {
            ColorBrush = new SolidColorBrush(Colors.Violet);
            ButtonClick = ReactiveCommand.Create<Color, Color>(newColorBrush => ColorBrush.Color = newColorBrush );
        }

        public SolidColorBrush ColorBrush
        {
            get => colorBrush;
            set
            {
                this.RaiseAndSetIfChanged(ref colorBrush, value);
            }
        }
        public ReactiveCommand<Color, Color> ButtonClick { get; }
    }
}
