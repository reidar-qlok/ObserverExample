namespace ObserverExample
{

    // ConcreteSubject class that implements the ISubject interface
    public class WeatherData : ISubject
    {
        // List to hold references to all registered observers
        private List<IObserver> observers;

        // Weather measurements
        private float temperature;
        private float humidity;
        private float pressure;

        // Constructor initializes the observer list
        public WeatherData()
        {
            observers = new List<IObserver>();
        }

        // Method to register a new observer
        public void RegisterObserver(IObserver observer)
        {
            observers.Add(observer);
        }

        // Method to remove an existing observer
        public void RemoveObserver(IObserver observer)
        {
            observers.Remove(observer);
        }

        // Method to notify all registered observers of changes
        public void NotifyObservers()
        {
            foreach (var observer in observers)
            {
                // Call the Update method on each observer
                observer.Update(temperature, humidity, pressure);
            }
        }

        // Method to be called when the measurements have changed
        public void MeasurementsChanged()
        {
            // Notify all observers of the change
            NotifyObservers();
        }

        // Method to set new measurements and notify observers
        public void SetMeasurements(float temperature, float humidity, float pressure)
        {
            // Update weather measurements
            this.temperature = temperature;
            this.humidity = humidity;
            this.pressure = pressure;

            // Notify observers that measurements have changed
            MeasurementsChanged();
        }
    }
}
