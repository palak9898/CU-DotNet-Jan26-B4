using System;

namespace ConfigUtilityApp
{
    public static class ApplicationConfig
    {

        public static string ApplicationName { get; private set; }
        public static string Environment { get; private set; }
        public static int AccessCount { get; private set; }
        public static bool IsInitialized { get; private set; }

        static ApplicationConfig()
        {
            ApplicationName = "MyApp";
            Environment = "Development";
            AccessCount = 0;
            IsInitialized = false;

            Console.WriteLine("Static constructor executed");
        }


        public static void Initialize(string appName, string environment)
        {
            ApplicationName = appName;
            Environment = environment;
            IsInitialized = true;
            AccessCount++;
        }

        public static string GetConfigurationSummary()
        {
            AccessCount++;

            return $"Application Name: {ApplicationName}\n" +
                   $"Environment: {Environment}\n" +
                   $"Access Count: {AccessCount}\n" +
                   $"Initialized: {IsInitialized}";
        }

        public static void ResetConfiguration()
        {
            ApplicationName = "MyApp";
            Environment = "Development";
            IsInitialized = false;
            AccessCount++;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Initial App Name: " + ApplicationConfig.ApplicationName);
            Console.WriteLine();

            ApplicationConfig.Initialize("AeroCook", "Production");

            string summary = ApplicationConfig.GetConfigurationSummary();
            Console.WriteLine(" Configuration Summary ");
            Console.WriteLine(summary);
            Console.WriteLine();

            ApplicationConfig.ResetConfiguration();

            string resetSummary = ApplicationConfig.GetConfigurationSummary();
            Console.WriteLine(" After Reset ");
            Console.WriteLine(resetSummary);
        }
    }
}