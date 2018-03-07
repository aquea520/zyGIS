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
        /// 表id
        /// </summary>
		public Nullable<int> DBId { set; get; }
        /// <summary>
        /// 是否主键
        /// </summary>
        public Nullable<bool> IsPrimaryKey { set; get; }
        /// <summary>
        /// 字段名称
        /// </summary>
        public string ColumnName { set; get; }
        /// <summary>
        /// 字段类型
        /// </summary>
        public string ColumnType { set; get; }
        /// <summary>
        /// 字节长度
        /// </summary>
        public Nullable<int> ByteLength { set; get; }
        /// <summary>
        /// 字符长度
        /// </summary>
        public Nullable<int> CharLength { set; get; }
        /// <summary>
        /// 小数位
        /// </summary>
        public Nullable<int> Scale { set; get; }
        /// <summary>
        /// 默认值
        /// </summary>
        public string DefaultValue { set; get; }
        /// <summary>
        /// 是否自增列
        /// </summary>
        public Nullable<bool> IsIdentity { set; get; }
        /// <summary>
        /// 是否允许空
        /// </summary>
        public Nullable<bool> IsNullable { set; get; }
        /// <summary>
        /// 描述
        /// </summary>
        public string Remark { set; get; }

		#endregion

		
	}
}