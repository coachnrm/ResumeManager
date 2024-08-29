using Microsoft.EntityFrameworkCore;
using ResumeManager.Models;


namespace ResumeManager.Data;
public class AppicationDbContext : DbContext
{
    public AppicationDbContext(DbContextOptions<AppicationDbContext> options):base(options)
    {

    }

    public virtual DbSet<Applicant> Applicants {get; set;}
    public virtual DbSet<Experience> Experiences {get; set;}
}