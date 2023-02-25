﻿using System;

namespace CustomThreeuple
{
    public class CustomThreeuple<T1, T2, T3>
    {
        private string item1;
        private string item2;
        private string item3;

        public T1 Item1 { get; set; }
        public T2 Item2 { get; set; }
        public T3 Item3 { get; set; }

        public override string ToString()
        {
            return $"{Item1} -> {Item2} -> {Item3}";
        }
    }
}
