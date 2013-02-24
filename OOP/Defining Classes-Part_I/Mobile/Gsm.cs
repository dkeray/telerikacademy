using System;
using System.Collections.Generic;
using System.Text;

class Gsm
{
    // Private Constants
    private const uint MaxDisplayWidth = 4096;
    private const uint MaxDisplayHeight = 2160;
    private const decimal MaxPrice = 1e6M;

    // Private Fields
    private Display display = null;
    private decimal? price = 0;

    // TODO: Constant
    public static Gsm IPhone4S = new Gsm("iPhone 4s", "Apple", null, 1000,
        new Display(960, 640, 256), new Battery(Battery.Type.LiIon, 60, 10));

    // Properties
    public string Model { get; set; }
    public string Manufacturer { get; set; }
    public string Owner { get; set; }

    public decimal? Price
    {
        get { return this.price; }

        set
        {
            // Null or in range
            if (!(!value.HasValue || (0 <= value && value <= MaxPrice)))
                throw new ArgumentOutOfRangeException();

            this.price = value;
        }
    }

    public Display Display
    {
        get { return this.display; }

        set
        {
            if (value.Width > MaxDisplayWidth)
                throw new ArgumentOutOfRangeException();

            if (value.Height > MaxDisplayHeight)
                throw new ArgumentOutOfRangeException();

            this.display = value;
        }
    }

    public Battery Battery { get; set; }

    public CallHistory CallHistory { get; set; }

    // Constructors
    public Gsm(string model, string manufacturer, string owner = null,
        decimal? price = null, Display display = null, Battery battery = null)
    {
        this.Model = model;
        this.Manufacturer = manufacturer;
        this.Owner = owner;
        this.Price = price;
        this.Display = display;
        this.Battery = battery;

        this.CallHistory = new CallHistory();
    }

    // Methods
    public override string ToString()
    {
        StringBuilder info = new StringBuilder();

        info.Append("Model - " + this.Model + "\n");
        info.Append("Manufacturer - " + this.Manufacturer);
        info.Append("\n");

        if (this.Owner != null)
            info.Append("Owner - " + this.Owner + "\n");

        if (this.Price != null)
            info.Append("Price - " + this.Price + "\n");

        if (this.Display != null)
            info.Append("Display - " + this.Display + "\n");

        if (this.Battery != null)
            info.Append("Battery - " + this.Battery + "\n");

        if (this.CallHistory.Count != 0)
        {
            info.Append("Call History -");

            info.Append(this.CallHistory.ToString());

            info.Append("\n");
        }

        return info.ToString();
    }
}