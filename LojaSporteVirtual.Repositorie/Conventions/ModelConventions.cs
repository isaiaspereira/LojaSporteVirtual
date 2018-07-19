using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaSporteVirtual.Repositorie.Conventions
{
    public class ModelConventions : Convention
    {
        public ModelConventions()
        {

            Properties()
                .Where(c => c.Name == c.DeclaringType.Name + "Id")
                .Configure(c => c.IsKey());

            Properties()
                .Where(c => c.DeclaringType.Name == "string")
                .Configure(c => c.HasColumnType("varchar")
                .HasMaxLength(200));
        }
    }
}
