
namespace SharedLibrary.Packets
{
    public interface IClientToServerPacket : IPacket
    {
        public string Key { get; set; }
    }
}