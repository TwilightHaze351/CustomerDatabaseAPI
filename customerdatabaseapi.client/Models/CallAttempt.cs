namespace CustomerDatabaseAPI.Models
{
public class CallAttempt
{
    public int CallAttemptId { get; set; }
    public int CustomerId { get; set; }
    public DateTime Timestamp { get; set; }
    public string Notes { get; set; }
    public virtual Customer Customer { get; set; }
}
