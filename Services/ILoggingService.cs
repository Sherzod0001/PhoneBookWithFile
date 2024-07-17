namespace PhoneBookWithFile.Services
{
    internal interface ILoggingService
    {
        public void LoggerMenu();
        public void LoggerForAdd();
        public void LoggerForRemove();
        public void LoggerExcepion(string message);
        public void LogInformation(string message);

    }
}