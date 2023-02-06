﻿using System;
using System.Text;

namespace GenericBoxOfString;

public class Box<T> where T : IComparable<T>
{
    private List<T> items;

    public Box()
    {
        items = new List<T>();
    }

    public void Add(T item)
    {
        items.Add(item);
    }

    public void Swap(int index1, int index2)
    {
        T temp = items[index1];
        items[index1] = items[index2];
        items[index2] = temp;
    }

    public int CountOfBigger(T comperer)
    {
        int count = 0;

        foreach (T item in this.items)
        {
            if (item.CompareTo(comperer) == 1)
            {
                count++;
            }
        }

        return count;
    }

    public override string ToString()
    {
        StringBuilder sb = new();
        foreach (T item in this.items)
        {
            sb.AppendLine($"{item.GetType()}: {item}");
        }

        return sb.ToString().TrimEnd();
    }
}
