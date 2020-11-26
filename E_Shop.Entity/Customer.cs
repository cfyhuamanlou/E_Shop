using SqlSugar;
using System;
namespace E_Shop.Entity
{
    public class Customer : BaseEntity
    {
        /// <summary>
        /// ��¼��
        /// </summary>
        public string LoginName { get; set; }
        /// <summary>
        /// ����
        /// </summary>
        public string LoginPwd { get; set; }
        /// <summary>
        /// �绰
        /// </summary>
        public string TelPhone { get; set; }
        /// <summary>
        /// ����
        /// </summary>
        public string Email { get; set; }
        /// <summary>
        /// �Ա�
        /// </summary>
        public int Sex { get; set; }
        /// <summary>
        /// ����
        /// </summary>
        public int Age { get; set; }
        /// <summary>
        /// �ǳ�
        /// </summary>
        public string NickName { get; set; }
        /// <summary>
        /// ��������
        /// </summary>
        public DateTime CreateDate { get; set; }

    }
}
