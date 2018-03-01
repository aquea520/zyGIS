using Abp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace zyGIS.Form
{
    public class Form : Entity<Guid>
    {
        public virtual string Name { get; set; }

        public Form() {

        }


    }
}
