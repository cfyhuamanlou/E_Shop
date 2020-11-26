using E_Shop.Entity;
using E_Shop.IDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace E_Shop.DAL
{
    public class BaseDal<T> : DbContext<T>, IBaseDal<T> where T : BaseEntity, new()
    {
        /// <summary>
        /// 单个添加
        /// </summary>
        /// <param name="t">添加对象</param>
        /// <returns></returns>
        public bool AddEntity(T t)
        {
            return SimpleDb.Insert(t);
        }
        /// <summary>
        /// 异步单个添加
        /// </summary>
        /// <param name="t">添加对象</param>
        /// <returns></returns>
        public async Task<bool> AddEntityAsync(T t)
        {
            return await SimpleDb.InsertAsync(t);
        }
        /// <summary>
        /// 批量添加
        /// </summary>
        /// <param name="list">对象集合</param>
        /// <returns></returns>
        public bool AddListEntity(List<T> list)
        {
            return SimpleDb.InsertRange(list);
        }
        /// <summary>
        /// 异步批量添加
        /// </summary>
        /// <param name="list">对象集合</param>
        /// <returns></returns>
        public async Task<bool> AddListEntityAsync(List<T> list)
        {
            return await SimpleDb.InsertRangeAsync(list);
        }
        /// <summary>
        /// 更新
        /// </summary>
        /// <param name="t"></param>
        /// <returns></returns>
        public bool UpdateEntity(T t)
        {
            return SimpleDb.Update(t);
        }
        /// <summary>
        /// 更新
        /// </summary>
        /// <param name="columns">要更新的列的内容</param>
        /// <param name="whereLambda">更新条件</param>
        /// <returns></returns>
        public bool UpdateEntity(Expression<Func<T,T>> columns,Expression<Func<T, bool>> whereLambda)
        {
            return SimpleDb.Update(columns,whereLambda);
        }
        /// <summary>
        /// 异步更新
        /// </summary>
        /// <param name="t"></param>
        /// <returns></returns>
        public async Task<bool> UpdateEntityAsync(T t)
        {
            return await SimpleDb.UpdateAsync(t);
        }
        /// <summary>
        /// 异步更新
        /// </summary>
        /// <param name="columns">要更新的列的内容</param>
        /// <param name="whereLambda">更新条件</param>
        /// <returns></returns>
        public async Task<bool> UpdateEntityAsync(Expression<Func<T, T>> columns, Expression<Func<T, bool>> whereLambda)
        {
            return await SimpleDb.UpdateAsync(columns, whereLambda);
        }
        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="t"></param>
        /// <returns></returns>
        public bool DeleteEntity(T t)
        {
            return SimpleDb.Delete(t);
        }
        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="t"></param>
        /// <returns></returns>
        public bool DeleteEntity(Expression<Func<T, bool>> whereLambda)
        {
            return SimpleDb.Delete(whereLambda);
        }
        /// <summary>
        /// 异步删除
        /// </summary>
        /// <param name="t"></param>
        /// <returns></returns>
        public async Task<bool> DeleteEntityAsync(T t)
        {
            return await SimpleDb.DeleteAsync(t);
        }
        /// <summary>
        /// 异步删除
        /// </summary>
        /// <param name="whereLambda"></param>
        /// <returns></returns>
        public async Task<bool> DeleteEntityAsync(Expression<Func<T, bool>> whereLambda)
        {
            return await SimpleDb.DeleteAsync(whereLambda);
        }
        /// <summary>
        /// 查询单个
        /// </summary>
        /// <param name="whereLambda">查询条件</param>
        /// <returns></returns>
        public T FindEntity(Expression<Func<T, bool>> whereLambda)
        {
            return SimpleDb.GetSingle(whereLambda);
        }
        /// <summary>
        /// 异步查询单个
        /// </summary>
        /// <param name="whereLambda">查询条件</param>
        /// <returns></returns>
        public async Task<T> FindEntityAsync(Expression<Func<T, bool>> whereLambda)
        {
            return await SimpleDb.GetSingleAsync(whereLambda);
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
            return Db.Queryable<T>().Where(whereLambda).OrderByIF(isAsc, orderLambda, isAsc ? SqlSugar.OrderByType.Asc : SqlSugar.OrderByType.Desc).ToList();
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
            totalCount = 0;
            return Db.Queryable<T>().Where(whereLambda).OrderByIF(isAsc, orderLambda, isAsc ? SqlSugar.OrderByType.Asc : SqlSugar.OrderByType.Desc).ToPageList(pageIndex, pageSize, ref totalCount);
        }

    }
}
