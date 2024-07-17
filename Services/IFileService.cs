namespace PhoneBookWithFile.Services
{
    internal interface IFileService
    {
        void AddNameAndNumber(string nameAndNumber);
        void ClearFile();

        void RemoveNameAndNumber(string nameAndNumber);
        void ReplaceNumberAndName(string nameAndNumber);
        string ReadFile();
        void EnsureFileExists();

    }
}