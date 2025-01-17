﻿using Furion.ConfigurableOptions;
using Microsoft.Extensions.Configuration;
using System;

namespace Furion
{
    /// <summary>
    /// 应用全局配置
    /// </summary>
    public sealed class AppSettingsOptions : IConfigurableOptions<AppSettingsOptions>
    {
        /// <summary>
        /// 集成 MiniProfiler 组件
        /// </summary>
        public bool? InjectMiniProfiler { get; set; }

        /// <summary>
        /// 是否启用规范化文档
        /// </summary>
        public bool? InjectSpecificationDocument { get; set; }

        /// <summary>
        /// 是否启用引用程序集扫描
        /// </summary>
        public bool? EnabledReferenceAssemblyScan { get; set; }

        /// <summary>
        /// 外部程序集
        /// </summary>
        public string[] ExternalAssemblies { get; set; }

        /// <summary>
        /// 是否打印数据库连接信息到 MiniProfiler 中
        /// </summary>
        public bool? PrintDbConnectionInfo { get; set; }

        /// <summary>
        /// 配置支持的包前缀名
        /// </summary>
        public string[] SupportPackageNamePrefixs { get; set; }

        /// <summary>
        /// 后期配置
        /// </summary>
        /// <param name="options"></param>
        /// <param name="configuration"></param>
        public void PostConfigure(AppSettingsOptions options, IConfiguration configuration)
        {
            options.InjectMiniProfiler ??= true;
            options.InjectSpecificationDocument ??= true;
            options.EnabledReferenceAssemblyScan ??= false;
            options.ExternalAssemblies ??= Array.Empty<string>();
            options.PrintDbConnectionInfo ??= true;
            options.SupportPackageNamePrefixs ??= Array.Empty<string>();
        }
    }
}