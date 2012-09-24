using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LootAlert
{
    class Actor
    {
        private int address;
        protected MemoryManager reader;
        private int CachedID;

        protected int ActorID { get { return reader.ReadInt(address + 0x0); } }
        protected int ACDID { get { return reader.ReadInt(address + 0x4); } }
        protected string Name { get { return reader.ReadString(address + 0x8, 0x80); } }
        protected int ActorSNOID { get { return reader.ReadInt(address + 0x88); } }
        protected int WorldID { get { return reader.ReadInt(address + 0xD8); } }
        protected int SceneID { get { return reader.ReadInt(address + 0xDC); } }

        public Actor(MemoryManager reader, int address)
        {
            this.reader = reader;
            this.address = address;
            CachedID = ActorID;
        }

        public Actor(Actor other)
        {
            this.address = other.address;
            this.reader = other.reader;
            CachedID = ActorID;
        }

        public override bool Equals(object obj)
        {
            if (obj is Actor)
            {
                Actor other = (Actor)obj;
                return ActorSNOID == other.ActorSNOID && CachedID == other.ActorID && other.address == address;
            }
            return false;
        }

        public virtual bool IsValid()
        {
            return ActorID == CachedID && ActorID != -1;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
