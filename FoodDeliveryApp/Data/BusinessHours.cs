namespace FoodDeliveryApp.Data
{
    public class BusinessHours
    {
        public DateTime StartTime { get; init; }
        public DateTime EndTime { get; init; }

        public BusinessHours(DateTime startTime, DateTime endTime) 
        { 
            StartTime = startTime;
            EndTime = endTime;
        }
    }
}