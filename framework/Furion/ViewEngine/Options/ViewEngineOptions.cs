﻿using Furion.DependencyInjection;
using Microsoft.CodeAnalysis;
using System.Collections.Generic;
using System.Reflection;

namespace Furion.ViewEngine
{
    /// <summary>
    /// 视图引擎编译选项
    /// </summary>
    [SkipScan]
    public class ViewEngineOptions
    {
        /// <summary>
        /// 构造函数
        /// </summary>
        public ViewEngineOptions()
        {
            ReferencedAssemblies = new HashSet<Assembly>()
            {
                typeof(object).Assembly,
                typeof(ViewEngineModel).Assembly,
                typeof(System.Collections.IList).Assembly,
                typeof(System.Collections.Generic.IEnumerable<>).Assembly,
                Assembly.Load(new AssemblyName("Microsoft.CSharp")),
                Assembly.Load(new AssemblyName("System.Runtime")),
                Assembly.Load(new AssemblyName("System.Linq")),
                Assembly.Load(new AssemblyName("System.Linq.Expressions")),
                Assembly.Load(new AssemblyName("netstandard"))
            };
        }

        /// <summary>
        /// 引用程序集
        /// </summary>
        public HashSet<Assembly> ReferencedAssemblies { get; set; }

        /// <summary>
        /// 元数据引用
        /// </summary>
        public HashSet<MetadataReference> MetadataReferences { get; set; } = new HashSet<MetadataReference>();

        /// <summary>
        /// 模板命名空间
        /// </summary>
        public string TemplateNamespace { get; set; } = "Furion.ViewEngine";

        /// <summary>
        /// 继承
        /// </summary>
        public string Inherits { get; set; } = "Furion.ViewEngine.Template.Models";

        /// <summary>
        /// 默认 Using
        /// </summary>
        public HashSet<string> DefaultUsings { get; set; } = new HashSet<string>()
        {
            "System.Linq",
            "System.Collections",
            "System.Collections.Generic"
        };
    }
}