﻿using System;

namespace RawData
{
    class Car
    {
        public Car(
        string model,
        int speed,
        int power,
        int weight,
        string type,
        double tyre1pressure,
        int tyre1age,
        double tyre2pressure,
        int tyre2age,
        double tyre3pressure,
        int tyre3age,
        double tyre4pressure,
        int tyre4age)
        {

            Model = model;
            Engine = new(speed, power);
            Cargo = new(weight, type);
            Tires = new Tire[4];
            Tires[0] = new(tyre1age, tyre1pressure);
            Tires[1] = new(tyre2age, tyre2pressure);
            Tires[2] = new(tyre3age, tyre3pressure);
            Tires[3] = new(tyre4age, tyre4pressure);
        }

        public string Model { get; set; }
        public Engine Engine { get; set; }
        public Cargo Cargo { get; set; }
        public Tire[] Tires { get; set; }
    }
}
