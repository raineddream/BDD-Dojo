﻿namespace Rain.BDDDojo
{
    public class ParkingCostCalculatorPresenter
    {
        private readonly IParkingCostCalculator _calculator;

        public ParkingCostCalculatorPresenter(IParkingCostCalculator calculator)
        {
            _calculator = calculator;
        }
    }
}