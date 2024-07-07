﻿namespace Adapter;

class Program 
{
    static void Main(string[] args)
    {
        var wildDog = new WildDog();
        var wildDogAdapter = new WildDogAdapter(wildDog);

        var hunter = new Hunter();
        hunter.Hunt(wildDogAdapter);
    }
}