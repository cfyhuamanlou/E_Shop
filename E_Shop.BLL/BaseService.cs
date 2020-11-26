using E_Shop.Entity;
using E_Shop.IBLL;
using E_Shop.IDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace E_Shop.BLL
{
    public abstract class BaseService<T> : IBaseService<T> where T : BaseEntity, new()
    {

        public IBaseDal<T> CurrentDal { get; set; }

        /// <summary>
        /// 单个添加
        /// </summary>
        /// <param name="t">添加对象</param>
        /// <returns></returns>
        public bool AddEntity(T t)
        {
            return CurrentDal.AddEntity(t);
        }
        /// <summary>
        /// 异步单个添加
        /// </summary>
        /// <param name="t">添加对象</param>
        /// <returns></returns>
        public async Task<bool> AddEntityAsync(T t)
        {
            return await CurrentDal.AddEntityAsync(t);
        }
        /// <summary>
        /// 批量添加
        /// </summary>
        /// <param name="list">对象集合</param>
        /// <returns></returns>
        public bool AddListEntity(List<T> list)
        {
            return CurrentDal.AddListEntity(list);
        }
        /// <summary>
        /// 异步批量添加
        /// </summary>
        /// <param name="list">对象集合</param>
        /// <returns></returns>
        public async Task<bool> AddListEntityAsync(List<T> list)
        {
            return await CurrentDal.AddListEntityAsync(list);
        }
        /// <summary>
        /// 更新
        /// </summary>
        /// <param name="t"></param>
        /// <returns></returns>
        public bool UpdateEntity(T t)
        {
            return CurrentDal.UpdateEntity(t);
        }
        /// <summary>
        /// 更新
        /// </summary>
        /// <param name="columns">更新的列的内容</param>
        /// <param name="whereLambda">更新条件</param>
        /// <returns></returns>
        public bool UpdateEntity(Expression<Func<T, T>> columns, Expression<Func<T, bool>> whereLambda)
        {
            return CurrentDal.UpdateEntity(columns, whereLambda);
        }
        /// <summary>
        /// 异步更新
        /// </summary>
        /// <param name="t"></param>
        /// <returns></returns>
        public async Task<bool> UpdateEntityAsync(T t)
        {
            return await CurrentDal.UpdateEntityAsync(t);
        }
        /// <summary>
        /// 异步更新
        /// </summary>
        /// <param name="columns">更新的列的内容</param>
        /// <param name="whereLambda">更新条件</param>
        /// <returns></returns>
        public async Task<bool> UpdateEntityAsync(Expression<Func<T, T>> columns, Expression<Func<T, bool>> whereLambda)
        {
            return await CurrentDal.UpdateEntityAsync(columns, whereLambda);
        }
        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="t"></param>
        /// <returns></returns>
        public bool DeleteEntity(T t)
        {
            return CurrentDal.DeleteEntity(t);
        }
        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="whereLambda">删除条件</param>
        /// <returns></returns>
        public bool DeleteEntity(Expression<Func<T, bool>> whereLambda)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// 异步删除
        /// </summary>
        /// <param name="t"></param>
        /// <returns></returns>
        public async Task<bool> DeleteEntityAsync(T t)
        {
            return await CurrentDal.DeleteEntityAsync(t);
        }
        /// <summary>
        /// 异步删除
        /// </summary>
        /// <param name="whereLambda">删除条件</param>
        /// <returns></returns>
        public async Task<bool> DeleteEntityAsync(Expression<Func<T, bool>> whereLambda)
        {
            return await CurrentDal.DeleteEntityAsync(whereLambda);
        }
        /// <summary>
        /// 查询单个
        /// </summary>
        /// <param name="whereLambda">查询条件</param>
        /// <returns></returns>
        public T FindEntity(Expression<Func<T, bool>> whereLambda)
        {
            return CurrentDal.FindEntity(whereLambda);
        }
        /// <summary>
        /// 异步查询单个
        /// </summary>
        /// <param name="whereLambda">查询条件</param>
        /// <returns></returns>
        public async Task<T> FindEntityAsync(Expression<Func<T, bool>> whereLambda)
        {
            return await CurrentDal.FindEntityAsync(whereLambda);
        }
        /// <summary>
        /// 查询
        /// </summary>
        /// <param name="whereLambda">查询条件</param>
        /// <param name="orderLambda">排序条件</param>
        /// <param name="isAsc">true-升序 false-降序 </param>
        /// <returns></returns>
        public List<T> LoadEntities(Expression<Func<T, bool>> whereLambda, Expression<Func<T, object>> orderLambda, bool isAsc)
        {
            return CurrentDal.LoadEntities(whereLambda,orderLambda,isAsc);
        }
        /// <summary>
        /// 分页查询
        /// </summary>
        /// <param name="whereLambda">查询条件</param>
        /// <param name="orderLambda">排序条件</param>
        /// <param name="pageIndex">页码</param>
        /// <param name="pageSize">页容量</param>
        /// <param name="isAsc">true-升序 false-降序 </param>
        /// <param name="totalCount">总数</param>
        /// <returns></returns>
        public List<T> LoadPageEntities(Expression<Func<T, bool>> whereLambda, Expression<Func<T, object>> orderLambda, int pageIndex, int pageSize, bool isAsc, out int totalCount)
        {
            return CurrentDal.LoadPageEntities(whereLambda,orderLambda,pageIndex,pageSize,isAsc,out totalCount);
        }

       

        
    }
}
