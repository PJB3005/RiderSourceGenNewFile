using System;
using Avalonia.Controls;

namespace Project;

public partial class Foo : UserControl
{
    public Foo()
    {
        InitializeComponent();
        
        Console.WriteLine(Foobar.Text);
        Console.WriteLine(Foobar2.Text);
    }
}