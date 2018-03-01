using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.Text;

  
namespace zyGIS.Peoples
{
    public class People : FullAuditedEntity<Guid>
	{
		#region Model
		/// <summary>
        /// 
        /// </summary>
		public virtual string name { set; get; }
		/// <summary>
        /// 
        /// </summary>
		public virtual int age { set; get; }
		/// <summary>
        /// 
        /// </summary>
		public virtual int age1 { set; get; }
		/// <summary>
        /// 
        /// </summary>
		public virtual int sex { set; get; }

		#endregion

		
	}
}