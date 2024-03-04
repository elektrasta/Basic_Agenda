using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;

namespace DatabaseCreate
{
    //veritabanını kurduk
    public class Users
    {

        public Users()
        {
            Agende = new List<Agenda>();
            Fisiere = new List<Fisier>();
        }

        [Key]
        public int UserId { get; set; }
        [Required(ErrorMessage = "kullanıcı adı gereklidir")]
        public string Username { get; set; }
        [Required(ErrorMessage = "Şifre gerekli")]
        public string Password { get; set; }

        [Required]
        public virtual ICollection<Agenda> Agende { get; set; }

        [Required]
        public virtual ICollection<Fisier> Fisiere { get; set; }
    }

    public class Agenda
    {
        public Agenda()
        {
            //Users = new Users();
        }

        [System.ComponentModel.DataAnnotations.Schema.ForeignKey("Users")]
        public int UserId { get; set; }
        
        [Required]
        public DateTime data_si_ora { get; set; }
        public string notita { get; set; }
        [Required]
        public string titlu { get; set; }

        [Key]
        public int Id { get; set; }

        [Required]
        public virtual Users Users { get; set; }

    }

    public class Fisier
    {
        [Key]
        public int FisierId { get; set; }

        [System.ComponentModel.DataAnnotations.Schema.ForeignKey("Users")]
        public int UserId { get; set; }

        [Required]
        public String NumeReal { get; set; }
        public String NumeCriptat { get; set; }
        public bool Open { get; set; }
        public String ShareList { get; set; }
        public DateTime data_si_ora { get; set; }

        [Required]
        public virtual Users Users { get; set; }
    }

    public class AgendaDBContext : DbContext
    {

        public AgendaDBContext()
            : base("AgendaDBConnectionString")
        {
            //Database.SetInitializer<AgendaDBContext>(new CreateDatabaseIfNotExists<AgendaDBContext>());
            Database.SetInitializer<AgendaDBContext>(new DropCreateDatabaseIfModelChanges<AgendaDBContext>());
            //Database.SetInitializer<AgendaDBContext>(new DropCreateDatabaseAlways<AgendaDBContext>());
            //Database.SetInitializer<AgendaDBContext>(new SchoolDBInitializer());
        }
        public DbSet<Users> Users { get; set; }
        public DbSet<Agenda> Agenda { get; set; }
        public DbSet<Fisier> Fisiere { get; set; }
    }

}
