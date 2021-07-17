namespace SnackApp.Models
{
    public class ErrorViewModel
    {
        public string RequestId { get; set; }

        // prop for custom message
        public string Message { get; set; }


        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}