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
		
		
		public Nullable<int> DBId { set; get; }
		/// <summary>
        /// 
        /// </summary>
		
		
		public Nullable<bool> IsPrimaryKey { set; get; }
		/// <summary>
        /// 
        /// </summary>
		
		[StringLength(50)]
		public string ColumnName { set; get; }
		/// <summary>
        /// 
        /// </summary>
		
		[StringLength(50)]
		public string ColumnType { set; get; }
		/// <summary>
        /// 
        /// </summary>
		
		
		public Nullable<int> ByteLength { set; get; }
		/// <summary>
        /// 
        /// </summary>
		
		
		public Nullable<int> CharLength { set; get; }
		/// <summary>
        /// 
        /// </summary>
		
		
		public Nullable<int> Scale { set; get; }
		/// <summary>
        /// 
        /// </summary>
		
		[StringLength(200)]
		public string DefaultValue { set; get; }
		/// <summary>
        /// 
        /// </summary>
		
		
		public Nullable<bool> IsIdentity { set; get; }
		/// <summary>
        /// 
        /// </summary>
		
		
		public Nullable<bool> IsNullable { set; get; }
		/// <summary>
        /// 
        /// </summary>
		
		[StringLength(200)]
		public string Remark { set; get; }

		#endregion

		#region Method
        public void Normalize()
        {

        }
        #endregion


        
	}
}