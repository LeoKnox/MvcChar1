using Microsoft.EntityFrameworkCore;
using MvcChar1.Models;

namespace MvcChar1.Data
{
    public class MvcChar1Context : DbContext
    {
        public MvcChar1Context (DbContextOptions<MvcChar1Context> options) : base(options)
        {
        }

        public DbSet<Char1> Char1 { get; set; }
    }
}