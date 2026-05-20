using ApiParchePlanU.Interfaces;
using ApiParchePlanU.Models;
using ApiParchePlanU.DAO;
using ApiParchePlanU.Models.Enums;
using Microsoft.EntityFrameworkCore;

namespace ApiParchePlanU.Services
{
    public class AttendanceService : IAttendanceService
    {
        private readonly ApplicationDbContext _context;

        public AttendanceService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task ConfirmAttendance(string userId, int planId, string status)
        {
            var existing = await _context.Attendances
                .FirstOrDefaultAsync(a => a.UserId == userId && a.PlanId == planId);

            if (existing != null)
            {
                existing.Status = Enum.Parse<AttendanceStatus>(status);
                await _context.SaveChangesAsync();
                return;
            }

            var attendance = new Attendance
            {
                UserId = userId,
                PlanId = planId,
                Status = Enum.Parse<AttendanceStatus>(status)
            };
            _context.Attendances.Add(attendance);
            await _context.SaveChangesAsync();
        }

        public async Task<List<Attendance>> GetAttendances(int planId)
        {
            return await _context.Attendances
                .Where(a => a.PlanId == planId)
                .Include(a => a.user)
                .ToListAsync();
        }
    }
}