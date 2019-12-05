﻿using System;

namespace FreeSql.DataAnnotations
{
    public class ColumnFluent
    {

        public ColumnFluent(ColumnAttribute column)
        {
            _column = column;
        }

        ColumnAttribute _column;
        /// <summary>
        /// 数据库列名
        /// </summary>
        public ColumnFluent Name(string value)
        {
            _column.Name = value;
            return this;
        }
        /// <summary>
        /// 指定数据库旧的列名，修改实体属性命名时，同时设置此参数为修改之前的值，CodeFirst才可以正确修改数据库字段；否则将视为【新增字段】
        /// </summary>
        public ColumnFluent OldName(string value)
        {
            _column.OldName = value;
            return this;
        }
        /// <summary>
        /// 数据库类型，如： varchar(255)
        /// </summary>
        public ColumnFluent DbType(string value)
        {
            _column.DbType = value;
            return this;
        }

        /// <summary>
        /// 主键
        /// </summary>
        public ColumnFluent IsPrimary(bool value)
        {
            _column.IsPrimary = value;
            return this;
        }
        /// <summary>
        /// 自增标识
        /// </summary>
        public ColumnFluent IsIdentity(bool value)
        {
            _column.IsIdentity = value;
            return this;
        }
        /// <summary>
        /// 是否可DBNull
        /// </summary>
        public ColumnFluent IsNullable(bool value)
        {
            _column.IsNullable = value;
            return this;
        }
        /// <summary>
        /// 忽略此列，不迁移、不插入
        /// </summary>
        public ColumnFluent IsIgnore(bool value)
        {
            _column.IsIgnore = value;
            return this;
        }
        /// <summary>
        /// 乐观锁
        /// </summary>
        public ColumnFluent IsVersion(bool value)
        {
            _column.IsVersion = value;
            return this;
        }
        /// <summary>
        /// 类型映射，比如：可将 enum 属性映射成 typeof(string)
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public ColumnFluent MapType(Type value)
        {
            _column.MapType = value;
            return this;
        }

        /// <summary>
        /// 创建表时字段位置，规则如下：
        /// <para></para>
        /// &gt;0时排前面
        /// <para></para>
        /// =0时排中间(默认)
        /// <para></para>
        /// &lt;0时排后面
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public ColumnFluent Position(short value)
        {
            _column.Position = value;
            return this;
        }

        /// <summary>
        /// 该字段是否可以插入，默认值true，指定为false插入时该字段会被忽略
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public ColumnFluent CanInsert(bool value)
        {
            _column.CanInsert = value;
            return this;
        }
        /// <summary>
        /// 该字段是否可以更新，默认值true，指定为false更新时该字段会被忽略
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public ColumnFluent CanUpdate(bool value)
        {
            _column.CanUpdate = value;
            return this;
        }

        /// <summary>
        /// 标记属性为数据库服务器时间(utc/local)，在插入的时候使用类似 getdate() 执行
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public ColumnFluent ServerTime(DateTimeKind value)
        {
            _column.ServerTime = value;
            return this;
        }

        /// <summary>
        /// 设置长度，针对 string 类型避免 DbType 的繁琐设置<para></para>
        /// ---<para></para>
        /// StringLength = 100 时，对应 DbType：<para></para>
        /// MySql -> varchar(100)<para></para>
        /// SqlServer -> nvarchar(100)<para></para>
        /// PostgreSQL -> varchar(100)<para></para>
        /// Oracle -> nvarchar2(100)<para></para>
        /// Sqlite -> nvarchar(100)<para></para>
        /// ---<para></para>
        /// StringLength = -1 时，对应 DbType：<para></para>
        /// MySql -> text<para></para>
        /// SqlServer -> nvarchar(max)<para></para>
        /// PostgreSQL -> text<para></para>
        /// Oracle -> nvarchar2(4000)<para></para>
        /// Sqlite -> text<para></para>
        /// </summary>
        public ColumnFluent StringLength(int value)
        {
            _column.StringLength = value;
            return this;
        }
    }
}
