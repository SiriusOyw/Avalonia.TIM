using Avalonia.Controls;
using Avalonia.Input;
using Avalonia.Interactivity;
using TIM.ViewModels;

namespace TIM.Views;

public partial class MainView : UserControl
{
    private bool _chatPanelStart;

    private bool _startList;

    public MainView()
    {
        InitializeComponent();
    }

    private MainViewModel ViewModel => (MainViewModel)DataContext;

    protected override void OnLoaded(RoutedEventArgs e)
    {
        ViewModel.Chats.Add(new ChatDto
        {
            Description = "sirius：干活了干活了",
            Id = Guid.NewGuid(),
            Image = "",
            Name = "c#/.net core学习群"
        });
        ViewModel.Chats.Add(new ChatDto
        {
            Description = "sirius：干活了干活了",
            Id = Guid.NewGuid(),
            Image = "",
            Name = "进击的码农"
        });
        ViewModel.Chats.Add(new ChatDto
        {
            Description = "sirius：干活了干活了",
            Id = Guid.NewGuid(),
            Image = "",
            Name = ".NET C#爱好者"
        });

        ViewModel.SelectedChat = ViewModel.Chats[0];
    }

    private void List_OnPointterMoved(object? sender, PointerEventArgs e)
    {
        if (_startList) ViewModel.ListWidth = (int)e.GetPosition(this).X - 50;
    }

    private void List_OnPointterPressed(object? sender, PointerPressedEventArgs e)
    {
        _startList = true;
    }

    private void List_OnPointterReleased(object? sender, PointerReleasedEventArgs e)
    {
        _startList = false;
    }

    private void Chat_OnPointerPressed(object? sender, PointerPressedEventArgs e)
    {
        _chatPanelStart = true;
    }

    private void Chat_OnPointerReleased(object? sender, PointerReleasedEventArgs e)
    {
        _chatPanelStart = false;
    }

    private void Chat_OnPointerMoved(object? sender, PointerEventArgs e)
    {
        if (!_chatPanelStart) return;

        if (sender is Border border)
        {
            var chatPanelGrid = this.Find<Grid>("ChatPanelGrid");

            ViewModel.ChatPanelHeight = (int)(chatPanelGrid.Bounds.Height - e.GetPosition(this).Y + 65);
            // ViewModel.ChatPanelHeight = (int)e.GetPosition(this).Y;
        }
    }
}