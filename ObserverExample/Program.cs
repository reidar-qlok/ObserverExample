namespace ObserverExample
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Skapa en instans av WeatherData som fungerar som vårt Subject
            WeatherData weatherData = new WeatherData();

            // Skapa en instans av CurrentConditionsDisplay som fungerar som en Observer
            // och registrerar sig själv till weatherData
            CurrentConditionsDisplay currentDisplay = new CurrentConditionsDisplay(weatherData);

            // Ändra väderdata och observera att CurrentConditionsDisplay notifieras och uppdateras
            weatherData.SetMeasurements(28, 65, 1010.6f); // Sätter temperaturen till 28 grader Celsius, luftfuktigheten till 65% och trycket till 1010.6 hPa
            weatherData.SetMeasurements(18, 70, 912.7f);
            weatherData.SetMeasurements(12, 90, 788.6f);
        }
    }
}
