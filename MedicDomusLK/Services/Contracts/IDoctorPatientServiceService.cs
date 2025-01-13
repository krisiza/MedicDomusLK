namespace MedicDomusLK.Services.Contracts
{
    public interface IDoctorPatientServiceService
    {
        Task<bool> IsHourFree(DateTime start, string doctorId);
    }
}
