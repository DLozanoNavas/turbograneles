namespace Italcol.Turbograneles.Application.Dtos.Port
{
    public class PortResponseEnvelope<T>
    {
        public bool Success { get; set; }
        public string Message { get; set; }
        public DateTime Timestamp { get; set; }
        public string LocalTime { get; set; }
        public int StatusCode { get; set; }
        public T Data { get; set; }
        public string UniqueRequestId { get; set; }
    }
}
