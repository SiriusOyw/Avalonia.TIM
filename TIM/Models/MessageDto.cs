namespace TIM.Models;

public class MessageDto
{
    public Guid Id { get; set; }
    public string Avatar { get; set; }
    public string Name { get; set; }
    public string Role { get; set; }
    public string Message { get; set; }
    public MessageType Type { get; set; }
    public DateTime CreateTime { get; set; }
}