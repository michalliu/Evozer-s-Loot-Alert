using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LootAlert
{
    class SNOReader
    {
        private const int defptr = 0x3C;
        private const int defcount = 0x10C;
        private const int deflink = 0x148;

        private Dictionary<int, int> data;

        public SNOReader(MemoryManager reader, int address)
        {
            data = new Dictionary<int, int>();

            int ptr = reader.ReadInt(address, defptr);
            int count = reader.ReadInt(ptr + defcount);
            int curOff = reader.ReadInt(ptr + deflink) + 0xC;

            for (int i = 0; i <= 4096; i++)
            {
                int curSNOoff = reader.ReadInt(curOff);
                int curSNOid = reader.ReadInt(curSNOoff);

                if (curSNOoff == 0 && curSNOid == 0)
                    break;

                data.Add(curSNOid, curSNOoff);

                curOff += 0x10;
            }
        }

        public int GetAddressFromID(int id)
        {
            if (data.ContainsKey(id))
                return data[id];
            return -1;
        }
    }
}
