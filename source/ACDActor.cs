using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LootAlert
{
    class ACDActor : Actor
    {
        protected int ACDAddress;
        private int CachedACDID;

        protected int FastAttribGroupID { get { return reader.ReadInt(ACDAddress + 0x120); } }
        public ACDType ACDType { get { return (ACDType)reader.ReadInt(ACDAddress + 0xB0); } }

        public ACDActor(MemoryManager reader, int address)
            : base(reader, address)
        {
            CachedACDID = ACDID;
            GetACDAddress();
        }

        public ACDActor(Actor other)
            : base(other)
        {
            CachedACDID = ACDID;
            GetACDAddress();
        }

        public int GetInt(Attrib attribute)
        {
            return reader.ReadInt(GetAttribute((uint)attribute));
        }

        public float GetFloat(Attrib attribute)
        {
            return reader.ReadFloat(GetAttribute((uint)attribute));
        }

        public override bool IsValid()
        {
            return base.IsValid() && CachedACDID == ACDID && ACDID != -1;
        }

        public override bool Equals(object obj)
        {
            if (obj is ACDActor)
            {
                ACDActor other = (ACDActor)obj;
                return base.Equals(obj) && other.ACDID == CachedACDID && other.ACDAddress == ACDAddress;
            }
            return false;
        }

        private void GetACDAddress()
        {
            int c = reader.ReadInt(DiabloIII.ObjectManager, 0x850, 0);

            short id = (short)(0xFFFF & ACDID);
            int bitShift = reader.ReadInt(c + 0x18C);
            int acd = reader.ReadInt(reader.ReadInt(c + 0x148)) + 4 * (id >> bitShift) + 0x2D0 * (id & ((1 << bitShift) - 1));

            ACDAddress = acd;
        }

        private int GetFastAttribGroup()
        {
            int c = reader.ReadInt(DiabloIII.ObjectManager, 0x844, 0x70);
            ushort id = (ushort)FastAttribGroupID;
            int bitShift = reader.ReadInt(c + 0x18C);
            int group = reader.ReadInt(c + 0x148, 0) + 4 * (id >> bitShift) + 0x180 * (id & ((1 << bitShift) - 1));
            return group;
        }

        private int GetAttribute(uint attrib)
        {
            int group = GetFastAttribGroup();
            int attributeEntry = reader.ReadInt(reader.ReadInt(group + 0x10, 8) + 4 * (reader.ReadInt(group + 0x10, 0x418) & ((int)attrib ^ ((int)attrib >> 16))));
            if (attributeEntry != 0)
            {
                while (reader.ReadInt(attributeEntry + 4) != (int)attrib)
                {
                    attributeEntry = reader.ReadInt(attributeEntry);
                    if (attributeEntry == 0)
                        return -1;
                }
                return attributeEntry + 8;
            }
            return -1;
        }

        //very bad solution but I'm too lazy to make a monster class just for this right now
        public bool IsGoblin()
        {
            return Name.Contains("treasureGoblin");
        }
    }

    public enum ACDType
    {
        Item = 2,
        Player = 7
    }
}
