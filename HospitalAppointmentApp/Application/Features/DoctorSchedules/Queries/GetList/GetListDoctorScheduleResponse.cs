namespace Application.Features.DoctorSchedules.Queries.GetList
{
    public class GetListDoctorScheduleResponse
    {
        public int Id { get; set; }
        public DateTime AvailableDate { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public int DoctorId { get; set; }
    }
}
