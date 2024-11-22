﻿using CalculatorSOLID.Services.Interfaces;

namespace CalculatorSOLID.Services
{
    public class SubtractionOperation : IOperation
    {
        public double Execute(double value1, double value2)
        {
            return value1 - value2;
        }
    }
}