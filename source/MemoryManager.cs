using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace LootAlert
{
    public class MemoryManager : IDisposable
    {
        private Process process;
        private IntPtr processHandle;
        private IntPtr baseAddress;
        private bool closed;

        #region constructors
        public MemoryManager(int pId)
        {
            process = Process.GetProcessById(pId);
            baseAddress = process.MainModule.BaseAddress;
            Open();
        }
        public MemoryManager(string name) : this(Process.GetProcessesByName(name)[0].Id)
        {
        }

        public void Dispose()
        {
            Close();
        }

        ~MemoryManager()
        {
            Close();
        }

        public bool IsInvalid()
        {
            return process.HasExited;
        }
        #endregion

        #region memory read
        public int ReadInt(int addr, bool addToBase = false)
        {
            if (addToBase)
                addr += (int)baseAddress;
            return BitConverter.ToInt32(ReadMem(addr, 4), 0);
        }
        public int ReadInt(int addr, params int[] offsets)
        {
            int res = ReadInt(addr);
            foreach (int i in offsets)
                res = ReadInt(res + i);
            return res;
        }
        public float ReadFloat(int addr, bool addToBase = false)
        {
            if (addToBase)
                addr += (int)baseAddress;
            return BitConverter.ToSingle(ReadMem(addr, 4), 0);
        }
        public long ReadLong(int addr, bool addToBase = false)
        {
            if (addToBase)
                addr += (int)baseAddress;
            return BitConverter.ToInt64(ReadMem(addr, 8), 0);
        }
        public uint ReadUInt(int addr, bool addToBase = false)
        {
            if (addToBase)
                addr += (int)baseAddress;
            return BitConverter.ToUInt32(ReadMem(addr, 4), 0);
        }
        public string ReadString(int addr, int length, bool ascii = true)
        {
            if (ascii == false)
                return Encoding.Unicode.GetString(ReadMem(addr, length));
            return Encoding.ASCII.GetString(ReadMem(addr, length));
        }
        #endregion

        #region imports
        [DllImport("kernel32.dll")]
        private static extern IntPtr OpenProcess(uint access, bool inheritHandle, int processId);
        private void Open()
        {
            processHandle = OpenProcess(0x10, false, process.Id);
        }

        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool CloseHandle(IntPtr hObject);
        private bool Close()
        {
            if (closed == false)
            {
                closed = true;
                return CloseHandle(processHandle);
            }
            return true;
        }

        [DllImport("kernel32.dll")]
        private static extern void ReadProcessMemory(IntPtr hProcess, IntPtr baseAddress, byte[] buffer, int size, int bytesRead);
        public byte[] ReadMem(int addr, int size)
        {
            byte[] buf = new byte[size];
            ReadProcessMemory(processHandle, (IntPtr)addr, buf, size, 0);
            return buf;
        }
        #endregion
    }
}
