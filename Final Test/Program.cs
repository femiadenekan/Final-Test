﻿// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");


using System;
using System.Collections.Generic;
using System.Linq;

public class ValueTypeCollection<T> where T : struct
{
    private List<T> collection;

    public ValueTypeCollection()
    {
        collection = new List<T>();
    }

    public void AddItem(T item)
    {
        collection.Add(item);
    }

    public T GetItem(int index)
    {
        if (index < 0 || index >= collection.Count)
        {
            throw new IndexOutOfRangeException("Index is out of range.");
        }

        return collection[index];
    }

    public List<T> GetSortedDescending()
    {
        return collection.OrderByDescending(x => x).ToList();
    }
}

