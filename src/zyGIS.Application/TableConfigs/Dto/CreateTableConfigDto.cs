using System;
using System.ComponentModel.DataAnnotations;
using Abp.AutoMapper;
using Abp.Runtime.Validation;

  
namespace zyGIS.TableConfigs.Dto
{
	[AutoMapTo(typeof(TableConfig))]
    public class CreateTableConfigDto : IShouldNormalize
	{
		#region Model
		/// <summary>
        /// 
        /// </summary>
		
		[StringLength(50)]
		public string ColumnName { set; get; }
		/// <summary>
        /// 
        /// </summary>
		
		[StringLength(50)]
		public string DataType { set; get; }
		/// <summary>
        /// 
        /// </summary>
		
		
		public Nullable<int> Precision { set; get; }
		/// <summary>
        /// 
        /// </summary>
		
		[StringLength(200)]
		public string DefaultValue { set; get; }
		/// <summary>
        /// 
        /// </summary>
		
		[StringLength(200)]
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

		#region Method
        public void Normalize()
        {

        }
        #endregion


        
	}
}