﻿using System;

public class Cash : PaymentMethod
{
    public override void Pay(decimal amount)
    {
        Console.WriteLine($"Paying {amount} using Cash");
    }
}
