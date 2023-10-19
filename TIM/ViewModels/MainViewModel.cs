namespace TIM.ViewModels;

public class MainViewModel : ViewModelBase
{
    private int _chatPanelHeight = 240;

    private ObservableCollection<ChatDto> _chats = new();
    private int _listWidth = 280;

    private ChatDto _selectedChat;

    public int ListWidth
    {
        get => _listWidth;
        set => this.RaiseAndSetIfChanged(ref _listWidth, value);
    }

    public int ChatPanelHeight
    {
        get => _chatPanelHeight;
        set => this.RaiseAndSetIfChanged(ref _chatPanelHeight, value);
    }

    public ObservableCollection<ChatDto> Chats
    {
        get => _chats;
        set => this.RaiseAndSetIfChanged(ref _chats, value);
    }

    public ChatDto SelectedChat
    {
        get => _selectedChat;
        set => this.RaiseAndSetIfChanged(ref _selectedChat, value);
    }
    
    public MessageViewModel MessageViewModel { get; set; } = new();
}