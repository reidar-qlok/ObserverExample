﻿namespace ObserverExample
{
    public interface IObserver
    {
        void Update(float temperature, float humidity, float pressure);
    }
}
