namespace ObserverExample
{
    // ConcreteObserver-klass som implementerar IObserver-gränssnittet
    public class CurrentConditionsDisplay : IObserver
    {
        // Fält för att hålla temperatur och luftfuktighet
        private float temperature;
        private float humidity;

        // Referens till ett objekt som implementerar ISubject-gränssnittet
        private ISubject weatherData;

        // Konstruktor som tar ett ISubject-objekt och registrerar CurrentConditionsDisplay som en observer
        public CurrentConditionsDisplay(ISubject weatherData)
        {
            this.weatherData = weatherData;
            // Registrerar denna observer hos subject
            weatherData.RegisterObserver(this);
        }

        // Update-metoden som anropas av subject när dess tillstånd ändras
        public void Update(float temperature, float humidity, float pressure)
        {
            // Uppdaterar temperatur och luftfuktighet med de nya värdena
            this.temperature = temperature;
            this.humidity = humidity;
            // Anropar Display-metoden för att visa de uppdaterade värdena
            Display();
        }

        // Metod för att visa de aktuella väderförhållandena
        public void Display()
        {
            // Skriver ut de aktuella väderförhållandena till konsolen
            Console.WriteLine($"Current conditions: {temperature}ºC degrees and {humidity}% humidity");
        }
    }

}
