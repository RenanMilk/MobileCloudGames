using System.Data.Entity;

namespace MobileMilk.Models.Contexto
{
    public class MeuContexto : DbContext
    {
        public MeuContexto() : base("strConn")
        {

        }

        public System.Data.Entity.DbSet<Web.Models.MobileMilk.Models.Item> Items { get; set; }
    }
}