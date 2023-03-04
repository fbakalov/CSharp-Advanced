﻿
using BirthdayCelebrations.Models.Interfaces;

namespace BirthdayCelebrations.Models
{
    public class Robot
    {
        public Robot(string model, string id)
        {
            Model = model;
            Id = id;
        }
        public string Model { get; private set; }
        public string Id { get; private set; }
    }
}
