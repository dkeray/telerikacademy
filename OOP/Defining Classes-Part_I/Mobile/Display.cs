using System;
using System.Collections.Generic;
using System.Text;

class Display
{
    // Private Constants
    private const uint MaxWidth = 1980;
    private const uint MaxHeight = 1080;
    private const long MaxNumberOfColors = 65000;

    // Private Fields
    private uint width = 0;
    private uint height = 0;
    private long? numberOfColors = null;

    // Properties
    public uint Width
    {
        get { return this.width; }

        set
        {
            if (value > MaxWidth)
                throw new ArgumentOutOfRangeException();

            this.width = value;
        }
    }

    public uint Height
    {
        get { return this.height; }

        set
        {
            if (value > MaxHeight)
                throw new ArgumentOutOfRangeException();

            this.height = value;
        }
    }

    public long? NumberOfColors
    {
        get { return this.numberOfColors; }

        set
        {
            if (value.GetValueOrDefault() > MaxNumberOfColors)
                throw new ArgumentOutOfRangeException();

            this.numberOfColors = value;
        }
    }

    // Constructors
    public Display(uint width, uint height, long? numberOfColors = null)
    {
        this.Width = width;
        this.Height = height;
        this.NumberOfColors = numberOfColors;
    }

    // Methods
    public override string ToString()
    {
        StringBuilder res = new StringBuilder();
        res.Append("Width: ");
        res.Append(this.Width);
        res.Append("\n");
        res.Append("Height: ");
        res.Append(this.Height);
        res.Append("\n");
        res.Append("Number of Colors: ");
        res.Append(this.NumberOfColors);
        return res.ToString();
    }
}