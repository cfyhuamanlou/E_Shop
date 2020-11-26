using E_Shop.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace E_Shop.IDAL
{
    public interface IBaseDal<T> where T : BaseEntity, new()
    {
        /// <summary>
        /// 单个添加
        /// </summary>
        /// <param name="t">添加对象</param>
        /// <returns></returns>
        bool AddEntity(T t);
        /// <summary>
        /// 异步单个添加
        /// </summary>
        /// <param name="t">添加对象</param>
        /// <returns></returns>
        Task<bool> AddEntityAsync(T t);
        /// <summary>
        /// 批量添加
        /// </summary>
        /// <param name="list">对象集合</param>
        /// <returns></returns>
        bool AddListEntity(List<T> list);
        /// <summary>
        /// 异步批量添加
        /// </summary>
        /// <param name="list">对象集合</param>
        /// <returns></returns>
        Task<bool> AddListEntityAsync(List<T> list);
        /// <summary>
        /// 更新
        /// </summary>
        /// <param name="t"></param>
        /// <returns></returns>
        bool UpdateEntity(T t);
        /// <summary>
        /// 更新
        /// </summary>
        /// <param name="t"></param>
        /// <returns></returns>
        bool UpdateEntity(Expression<Func<T, T>> columns, Expression<Func<T, bool>> whereLambda);
        /// <summary>
        /// 异步更新
        /// </summary>
        /// <param name="t"></param>
        /// <returns></returns>
        Task<bool> UpdateEntityAsync(T t);
        /// <summary>
        /// 异步更新
        /// </summary>
        /// <param name="t"></param>
        /// <returns></returns>
        Task<bool> UpdateEntityAsync(Expression<Func<T, T>> columns, Expression<Func<T, bool>> whereLambda);
        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="t"></param>
        /// <returns></returns>
        bool DeleteEntity(T t);
        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="t"></param>
        /// <returns></returns>
        bool DeleteEntity(Expression<Func<T, bool>> whereLambda);
        /// <summary>
        /// 异步删除
        /// </summary>
        /// <param name="t"></param>
        /// <returns></returns>
        Task<bool> DeleteEntityAsync(T t);
        /// <summary>
        /// 异步删除
        /// </summary>
        /// <param name="t"></param>
        /// <returns></returns>
        Task<bool> DeleteEntityAsync(Expression<Func<T, bool>> whereLambda);
        /// <summary>
        /// 查询单个
        /// </summary>
        /// <param name="whereLambda">查询条件</param>
        /// <returns></returns>
        T FindEntity(Expression<Func<T, bool>> whereLambda);
        /// <summary>
        /// 异步查询单个
        /// </summary>
        /// <param name="whereLambda">查询条件</param>
        /// <returns></returns>
        Task<T> FindEntityAsync(Expression<Func<T, bool>> whereLambda);
        /// <summary>
        /// 查询
        /// </summary>
        /// <param name="whereLambda">查询条件</param>
        /// <param name="orderLambda">排序条件</param>
        /// <param name="isAsc">true-升序 false-降序 </param>
        /// <returns></returns>
        List<T> LoadEntities(Expression<Func<T, bool>> whereLambda, Expression<Func<T, object>> orderLambda, bool isAsc);
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
        List<T> LoadPageEntities(Expression<Func<T, bool>> whereLambda, Expression<Func<T, object>> orderLambda, int pageIndex, int pageSize, bool isAsc, out int totalCount);
        

    }
}
