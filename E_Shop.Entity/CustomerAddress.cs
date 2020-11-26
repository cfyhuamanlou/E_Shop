using System;
namespace E_Shop.Entity
{
    public class CustomerAddress : BaseEntity
    {
        /// <summary>
        /// 用户Id
        /// </summary>
        public int CustomerId { get; set; }
        /// <summary>
        /// 收货电话
        /// </summary>
        public string TelPhone { get; set; }
        /// <summary>
        /// 收货人
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 收货地址
        /// </summary>
        public string Address { get; set; }
        /// <summary>
        /// 是否默认地址
        /// </summary>
        public int IsDefault { get; set; }
        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime CreateDate { get; set; }

    }
}
