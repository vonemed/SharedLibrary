namespace SharedLibrary.Packets.ClientToServer;

public sealed class LoginRequestPacket : IClientToServerPacket
{
    public string Key { get; set; } = "LoginRequest";
    public String UserId { get; set; }

    public LoginRequestPacket(String userId)
    {
        UserId = userId;
    }
}