﻿using FreeSql;
using System;
using System.Data;
using ZhonTai.Admin.Core.Consts;

namespace ZhonTai.Admin.Core.Attributes;

/// <summary>
/// 启用事物
/// </summary>
[AttributeUsage(AttributeTargets.Method, Inherited = true)]
public class TransactionAttribute : Attribute
{
    /// <summary>
    /// 事务传播方式
    /// </summary>
    public Propagation Propagation { get; set; } = Propagation.Required;

    /// <summary>
    /// 事务隔离级别
    /// </summary>
    public IsolationLevel IsolationLevel { get; set; }

    /// <summary>
    /// 数据库键
    /// </summary>
    public string DbKey { get; set; } = DbKeys.MasterDb;

}