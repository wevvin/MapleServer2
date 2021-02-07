using MaplePacketLib2.Tools;
using MapleServer2.Constants;
using MapleServer2.Types;

namespace MapleServer2.Packets
{
    public static class GameMasterPacket
    {
        private enum GameMasterPacketMode : byte
        {
            Mode1 = 0x0,
            Mode2 = 0x1,
            Mode3 = 0x2,
            Mode4 = 0x3,
        }

        public static Packet Test1(IFieldObject<Player> player)
        {
            PacketWriter pWriter = PacketWriter.Of(SendOp.GM_COMMAND);
            pWriter.WriteEnum(GameMasterPacketMode.Mode1);
            pWriter.WriteInt(player.ObjectId);
            pWriter.WriteByte();
            return pWriter;
        }
        
        public static Packet Test2(IFieldObject<Player> player)
        {
            PacketWriter pWriter = PacketWriter.Of(SendOp.GM_COMMAND);
            pWriter.WriteEnum(GameMasterPacketMode.Mode2);
            pWriter.WriteInt(player.ObjectId);
            pWriter.WriteByte();
            return pWriter;
        }
        
        public static Packet Test3(IFieldObject<Player> player)
        {
            PacketWriter pWriter = PacketWriter.Of(SendOp.GM_COMMAND);
            pWriter.WriteEnum(GameMasterPacketMode.Mode3);
            pWriter.WriteInt(player.ObjectId);
            pWriter.WriteByte();
            return pWriter;
        }
        
        public static Packet Test4(IFieldObject<Player> player)
        {
            PacketWriter pWriter = PacketWriter.Of(SendOp.GM_COMMAND);
            pWriter.WriteEnum(GameMasterPacketMode.Mode4);
            pWriter.WriteInt(player.ObjectId);
            pWriter.WriteByte();
            return pWriter;
        }
    }
}
