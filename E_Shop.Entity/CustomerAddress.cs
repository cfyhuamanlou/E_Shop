using System;
namespace E_Shop.Entity
{
    public class CustomerAddress : BaseEntity
    {
        /// <summary>
        /// �û�Id
        /// </summary>
        public int CustomerId { get; set; }
        /// <summary>
        /// �ջ��绰
        /// </summary>
        public string TelPhone { get; set; }
        /// <summary>
        /// �ջ���
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// �ջ���ַ
        /// </summary>
        public string Address { get; set; }
        /// <summary>
        /// �Ƿ�Ĭ�ϵ�ַ
        /// </summary>
        public int IsDefault { get; set; }
        /// <summary>
        /// ����ʱ��
        /// </summary>
        public DateTime CreateDate { get; set; }

    }
}
