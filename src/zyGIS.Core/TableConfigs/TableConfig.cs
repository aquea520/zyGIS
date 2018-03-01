using Abp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

  
namespace zyGIS.TableConfigs
{
    public class TableConfig : Entity<Guid>
	{
		#region Model
		/// <summary>
        /// 
        /// </summary>
		public string ColumnName { set; get; }
		/// <summary>
        /// 
        /// </summary>
		public string DataType { set; get; }
		/// <summary>
        /// 
        /// </summary>
		public Nullable<int> Precision { set; get; }
		/// <summary>
        /// 
        /// </summary>
		public string DefaultValue { set; get; }
		/// <summary>
        /// 
        /// </summary>
		public string Remark { set; get; }
		/// <summary>
        /// 
        /// </summary>
		public Nullable<bool> IsNull { set; get; }
		/// <summary>
        /// 
        /// </summary>
		public Nullable<bool> PrimaryKey { set; get; }
		/// <summary>
        /// 
        /// </summary>
		public Nullable<bool> Increment { set; get; }

		#endregion

		
	}
}