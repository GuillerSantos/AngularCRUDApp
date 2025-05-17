namespace AngularCRUDApp.Domain.Commons
{
    public class Response
    {
        #region Properties

        public bool IsSuccess { get; set; }
        public string ErrorMessage { get; set; } = string.Empty;
        public string Message { get; set; } = string.Empty;
        public Dictionary<string, string[]>? ValidationErrors { get; set; }
        public object? Data { get; set; }

        #endregion Properties
    }
}