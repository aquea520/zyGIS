using System.ComponentModel.DataAnnotations;
using Abp.AutoMapper;
using Abp.Runtime.Validation;

  
namespace zyGIS.Peoples.Dto
{
	[AutoMapTo(typeof(People))]
    public class CreatePeopleDto : IShouldNormalize
	{
		#region Model
		/// <summary>
        /// 
        /// </summary>
		
		[StringLength(32)]
		public string name { set; get; }
		/// <summary>
        /// 
        /// </summary>
		[Required]
		
		public int age { set; get; }
		/// <summary>
        /// 
        /// </summary>
		[Required]
		
		public int age1 { set; get; }
		/// <summary>
        /// 
        /// </summary>
		[Required]
		
		public int sex { set; get; }

		#endregion

		#region Method
        public void Normalize()
        {

        }
        #endregion


        
	}
}