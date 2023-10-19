using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using TIM.ViewModels;

namespace TIM.Components;

public partial class MessageView : UserControl
{
    public MessageView()
    {
        InitializeComponent();

        DataContextChanged += (sender, args) =>
        {
            ViewModel.Messages.Add(new MessageDto()
            {
                Id = Guid.NewGuid(),
                Avatar = "",
                CreateTime = DateTime.Now,
                Message = "Hello Avalonia!",
                Name = "sirius",
                Type = MessageType.Text,
                Role = "【管理员】"
            });
            ViewModel.Messages.Add(new MessageDto()
            {
                Id = Guid.NewGuid(),
                Avatar = "",
                CreateTime = DateTime.Now,
                Message = "Hello Avalonia!",
                Name = "sirius",
                Type = MessageType.Text,
                Role = "【管理员】"
            });
            ViewModel.Messages.Add(new MessageDto()
            {
                Id = Guid.NewGuid(),
                Avatar = "",
                CreateTime = DateTime.Now,
                Message = "Hello Avalonia!",
                Name = "sirius",
                Type = MessageType.Text,
                Role = "【管理员】"
            });
            ViewModel.Messages.Add(new MessageDto()
            {
                Id = Guid.NewGuid(),
                Avatar = "",
                CreateTime = DateTime.Now,
                Message = "Hello Avalonia!",
                Name = "sirius",
                Type = MessageType.Text,
                Role = "【管理员】"
            });
            ViewModel.Messages.Add(new MessageDto()
            {
                Id = Guid.NewGuid(),
                Avatar = "",
                CreateTime = DateTime.Now,
                Message = "Hello Avalonia!",
                Name = "sirius",
                Type = MessageType.Text,
                Role = "【管理员】"
            });
            ViewModel.Messages.Add(new MessageDto()
            {
                Id = Guid.NewGuid(),
                Avatar = "",
                CreateTime = DateTime.Now,
                Message = "Hello Avalonia!",
                Name = "sirius",
                Type = MessageType.Text,
                Role = "【管理员】"
            });
            ViewModel.Messages.Add(new MessageDto()
            {
                Id = Guid.NewGuid(),
                Avatar = "",
                CreateTime = DateTime.Now,
                Message = "Hello Avalonia!",
                Name = "sirius",
                Type = MessageType.Text,
                Role = "【管理员】"
            });
            ViewModel.Messages.Add(new MessageDto()
            {
                Id = Guid.NewGuid(),
                Avatar = "",
                CreateTime = DateTime.Now,
                Message = "Hello Avalonia!",
                Name = "sirius",
                Type = MessageType.Text,
                Role = "【管理员】"
            });
            ViewModel.Messages.Add(new MessageDto()
            {
                Id = Guid.NewGuid(),
                Avatar = "",
                CreateTime = DateTime.Now,
                Message = "Hello Avalonia!",
                Name = "sirius",
                Type = MessageType.Text,
                Role = "【管理员】"
            });
        };
    }

    private MessageViewModel ViewModel => (MessageViewModel)DataContext;

    private void InitializeComponent()
    {
        AvaloniaXamlLoader.Load(this);
    }
}