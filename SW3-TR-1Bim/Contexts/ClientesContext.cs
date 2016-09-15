using SW3_TR_1Bim.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace SW3_TR_1Bim.Contexts
{
    public class ClientesContext : DbContext
    {

        public ClientesContext() : base("TR_1Bim") { }

        public DbSet<Cliente> Clientes { get; set; }

    }
}