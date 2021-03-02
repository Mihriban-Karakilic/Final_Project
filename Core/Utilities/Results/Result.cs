namespace Core.Utilities.Results
{
    public class Result : IResult
    {
        public Result(bool success, string message) :this(success)
        {
            Message = message;
            //Success = success; Bunu set etme işini alttaki contructor yapacak
        }
        public Result(bool success)
        {
            Success = success;
        }

        public bool Success { get; }

        public string Message { get; }
    }
}