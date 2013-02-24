﻿using System;
using System.Collections.Generic;
using System.Text;

class Call : IComparable<Call>, IEquatable<int>
{
    // Private Fields
    private static int idCounter = 0; // TODO: typedef

    // Public Properties
    public readonly int Id = 0;
    public readonly DateTime Time = DateTime.MinValue;
    public readonly string DialedPhone = null;
    public readonly TimeSpan Duration = TimeSpan.Zero;

    // Constructors
    public Call(string dialedPhone, TimeSpan duration)
    {
        this.Id = Call.idCounter++;
        this.Time = DateTime.Now;

        this.DialedPhone = dialedPhone;
        this.Duration = duration;
    }

    // Methods
    public override string ToString()
    {
        StringBuilder info = new StringBuilder();

        info.Append("ID: " + this.Id + "\n");
        info.Append("Time: " + this.Time + "\n");
        info.Append("Dialed Phone: " + this.DialedPhone + "\n");
        info.Append("Duration: " + this.Duration);

        return info.ToString();
    }

    public bool Equals(int otherId)
    {
        return this.Id == otherId;
    }

    public int CompareTo(Call other)
    {
        return (int)(this.Duration - other.Duration).TotalSeconds;
    }
}