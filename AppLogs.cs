namespace DotnetStarter
{
    public class AppLogs
    {
        public string Message { get; set; } = "Mesaj bulunamadi";
        public string? ClassName { get; internal set; }
        public int DataCount { get; set; }
        public long DurationMs { get; set; }
        public string? LogType { get; set; }
        public long LastId { get; set; }
        internal object? Data { get; set; }
        public string? DataDate { get; set; }
    }
}
