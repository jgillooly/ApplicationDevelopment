﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Cool_RPG.UI
{
    internal class Character : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;

        public const int baseStat = 10;

        string name;
        public int strength { get; set; }
        public int dexterity { get; set; }
        public int constitution { get; set; }
        public int intelligence { get; set; }
        public int wisdom { get; set; }
        public int charisma { get; set; }

        private void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }

        }

        public int Strength
        {
            get
            {
                return strength;
            }
            set
            {
                strength = value + baseStat;
                NotifyPropertyChanged();
            }
        }

        public int Dexterity
        {
            get
            {
                return dexterity;
            }
            set
            {
                dexterity = value + baseStat;
                NotifyPropertyChanged();
            }
        }

        public int Constitution
        {
            get
            {
                return constitution;
            }
            set
            {
                constitution = value + baseStat;
                NotifyPropertyChanged();
            }
        }

        public int Intelligence
        {
            get
            {
                return intelligence;
            }
            set
            {
                intelligence = value + baseStat;
                NotifyPropertyChanged();
            }
        }

        public int Wisdom
        {
            get
            {
                return wisdom;
            }
            set
            {
                wisdom = value + baseStat;
                NotifyPropertyChanged();
            }
        }

        public int Charisma
        {
            get
            {
                return charisma;
            }
            set
            {
                charisma = value + baseStat;
                NotifyPropertyChanged();
            }
        }

        public void ResetStats()
        {
            Strength = 0;
            Dexterity = 0;
            Constitution = 0;
            Intelligence = 0;
            Wisdom = 0;
            Charisma = 0;

        }
    }
}
