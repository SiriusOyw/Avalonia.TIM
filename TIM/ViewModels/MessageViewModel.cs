namespace TIM.ViewModels;

public class MessageViewModel : ViewModelBase
{
    private ObservableCollection<MessageDto> _messages = new();

    public ObservableCollection<MessageDto> Messages
    {
        get => _messages;
        set => this.RaiseAndSetIfChanged(ref _messages, value);
    }
}