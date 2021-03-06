﻿using Prism.Mvvm;
using System;

namespace DataBusinessLayer
{
    public class Debt : BindableBase
    {
        private DateTime _date;
        private int _value;

        public Debt(int value, DateTime date)
        {
            _date = date;
            _value = value;
        }

        public string Date
        {
            get => _date.ToString("O");
        }

        public string DateShort
        {
            get => _date.ToString("d");
        }

        public int DebtValue
        {
            get => _value;
            set => SetProperty(ref _value, value);
        }
    }
}
