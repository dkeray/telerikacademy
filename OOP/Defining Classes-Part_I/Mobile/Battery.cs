﻿using System;
using System.Collections.Generic;
using System.Text;

class Battery
{
    public enum Type { LiIon, NiMH, NiCd }; // static by default

    // Private Constants
    private const uint MaxIdleHours = 100;
    private const uint MaxTalkHours = 10;

    // Private Fields
    private uint? hoursIdle = null;
    private uint? hoursTalk = null;

    // Properties
    public Type Model { get; set; }

    public uint? HoursIdle
    {
        get { return this.hoursIdle; }

        set
        {
            if (value.GetValueOrDefault() > MaxIdleHours)
                throw new ArgumentOutOfRangeException();

            this.hoursIdle = value;
        }
    }

    public uint? HoursTalk
    {
        get { return this.hoursTalk; }

        set
        {
            if (value.GetValueOrDefault() > MaxTalkHours)
                throw new ArgumentOutOfRangeException();

            this.hoursTalk = value;
        }
    }

    // Constructors
    public Battery(Type model, uint? hoursIdle = null, uint? hoursTalk = null)
    {
        this.Model = model;
        this.HoursIdle = hoursIdle;
        this.HoursTalk = hoursTalk;
    }

    // Methods
    public override string ToString()
    {
        StringBuilder res = new StringBuilder();
        res.Append("Model: ");
        res.Append(this.Model);
        res.Append("\n");

        res.Append("Hours Idle: ");
        res.Append(this.HoursIdle);
        res.Append("\n");
        res.Append("Hours Talk: ");
        res.Append(this.HoursTalk);

        return res.ToString();
    }
}