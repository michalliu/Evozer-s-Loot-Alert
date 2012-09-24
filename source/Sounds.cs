using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Media;
using System.Windows.Forms;
using System.IO;

namespace LootAlert
{
    class Sounds
    {
        private static SoundPlayer standard;
        private static SoundPlayer legendary;
        private static SoundPlayer rare;
        private static SoundPlayer crafting;
        private static SoundPlayer magic;
        private static SoundPlayer goblin;

        private static string legendName = Application.StartupPath + "\\sound_Legendary.wav";
        private static string rareName = Application.StartupPath + "\\sound_Rare.wav";
        private static string craftingName = Application.StartupPath + "\\sound_Crafting.wav";
        private static string magicName = Application.StartupPath + "\\sound_Magic.wav";
        private static string goblinName = Application.StartupPath + "\\sound_Goblin.wav";
        private static string standardName = Application.StartupPath + "\\sound.wav";

        public static void InitSounds()
        {
            if (File.Exists(standardName))
            {
                standard = new SoundPlayer(standardName);
                standard.Load();
            }

            if (File.Exists(legendName))
            {
                legendary = new SoundPlayer(legendName);
                legendary.Load();
            }
            else
                legendary = standard;

            if (File.Exists(rareName))
            {
                rare = new SoundPlayer(rareName);
                rare.Load();
            }
            else
                rare = standard;

            if (File.Exists(craftingName))
            {
                crafting = new SoundPlayer(craftingName);
                crafting.Load();
            }
            else
                crafting = standard;

            if (File.Exists(magicName))
            {
                magic = new SoundPlayer(magicName);
                magic.Load();
            }
            else
                magic = standard;

            if (File.Exists(goblinName))
            {
                goblin = new SoundPlayer(goblinName);
                goblin.Load();
            }
            else
                goblin = standard;
        }

        public static void PlaySound(Sound sound)
        {
            switch (sound)
            {
                case Sound.None: break;
                case Sound.Legendary: legendary.Play(); break;
                case Sound.Rare: rare.Play(); break;
                case Sound.Crafting: crafting.Play(); break;
                case Sound.Magic: magic.Play(); break;
                case Sound.Goblin: goblin.Play(); break;
            }
        }
    }

    public enum Sound
    {
        None,
        Legendary,
        Rare,
        Crafting,
        Magic,
        Goblin
    }
}
