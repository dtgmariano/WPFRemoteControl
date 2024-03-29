﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows;
using System.Windows.Media;

namespace WPF_RemoteControl_with_USBUIRT
{
    public class RCModel : INotifyPropertyChanged
    {
        #region Constructor
        public RCModel()
        {
            Energy = false;
            Volume = 50;
            Channel = 1;
        }
        #endregion

        private bool myEnergy;
        public bool Energy
        {
            get { return myEnergy; }
            set
            {
                if (value != this.myEnergy)
                {
                    myEnergy = value;
                    NotifyPropertyChanged("Energy");
                }
            }
        }

        private int myChannel;
        public int Channel
        {
            get { return myChannel; }
            set
            {
                if (value != this.myChannel)
                {
                    myChannel = value;
                    NotifyPropertyChanged("Channel");
                }
            }
        }

        private int myVolume;
        public int Volume
        {
            get { return myVolume; }
            set
            {
                if (value != this.myVolume)
                {
                    myVolume = value;
                    NotifyPropertyChanged("Volume");
                }
            }
        }

        #region PropertyChanged Methods
        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyPropertyChanged(String info)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(info));
            }
        }
        #endregion
    }
}
