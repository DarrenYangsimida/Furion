﻿using Furion.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;

namespace Furion.Logging.Extensions
{
    /// <summary>
    /// 字符串日志输出拓展
    /// </summary>
    [SkipScan]
    public static class StringLoggingExtensions
    {
        /// <summary>
        /// 设置消息格式化参数
        /// </summary>
        /// <param name="message"></param>
        /// <param name="args"></param>
        public static StringLoggerPart SetArgs(this string message, params object[] args)
        {
            return new StringLoggerPart().SetMessage(message).SetArgs(args);
        }

        /// <summary>
        /// 设置日志级别
        /// </summary>
        /// <param name="message"></param>
        /// <param name="level"></param>
        public static StringLoggerPart SetLevel(this string message, LogLevel level)
        {
            return new StringLoggerPart().SetMessage(message).SetLevel(level);
        }

        /// <summary>
        /// 设置事件 Id
        /// </summary>
        /// <param name="message"></param>
        /// <param name="eventId"></param>
        public static StringLoggerPart SetEventId(this string message, EventId eventId)
        {
            return new StringLoggerPart().SetMessage(message).SetEventId(eventId);
        }

        /// <summary>
        /// 设置日志分类
        /// </summary>
        /// <param name="message"></param>
        /// <typeparam name="TClass"></typeparam>
        public static StringLoggerPart SetCategory<TClass>(this string message)
        {
            return new StringLoggerPart().SetMessage(message).SetCategory<TClass>();
        }

        /// <summary>
        /// 设置日志分类名
        /// </summary>
        /// <param name="message"></param>
        /// <param name="categoryName"></param>
        public static StringLoggerPart SetCategory(this string message, string categoryName)
        {
            return new StringLoggerPart().SetMessage(message).SetCategory(categoryName);
        }

        /// <summary>
        /// 设置异常对象
        /// </summary>
        public static StringLoggerPart SetException(this string message, Exception exception)
        {
            return new StringLoggerPart().SetMessage(message).SetException(exception);
        }

        /// <summary>
        /// 设置日志服务作用域
        /// </summary>
        /// <param name="message"></param>
        /// <param name="scoped"></param>
        /// <returns></returns>
        public static StringLoggerPart SetLoggerScoped(this string message, IServiceProvider scoped)
        {
            return new StringLoggerPart().SetMessage(message).SetLoggerScoped(scoped);
        }

        /// <summary>
        /// LogInformation
        /// </summary>
        /// <param name="message"></param>
        /// <param name="args"></param>
        public static void LogInformation(this string message, params object[] args)
        {
            new StringLoggerPart().SetMessage(message).SetArgs(args).LogInformation();
        }

        /// <summary>
        /// LogInformation
        /// </summary>
        /// <param name="message"></param>
        /// <param name="eventId"></param>
        /// <param name="args"></param>
        public static void LogInformation(this string message, EventId eventId, params object[] args)
        {
            new StringLoggerPart().SetMessage(message).SetArgs(args).SetEventId(eventId).LogInformation();
        }

        /// <summary>
        /// LogInformation
        /// </summary>
        /// <param name="message"></param>
        /// <param name="exception"></param>
        /// <param name="args"></param>
        public static void LogInformation(this string message, Exception exception, params object[] args)
        {
            new StringLoggerPart().SetMessage(message).SetArgs(args).SetException(exception).LogInformation();
        }

        /// <summary>
        /// LogInformation
        /// </summary>
        /// <param name="message"></param>
        /// <param name="eventId"></param>
        /// <param name="exception"></param>
        /// <param name="args"></param>
        public static void LogInformation(this string message, EventId eventId, Exception exception, params object[] args)
        {
            new StringLoggerPart().SetMessage(message).SetArgs(args).SetEventId(eventId).SetException(exception).LogInformation();
        }

        /// <summary>
        /// LogInformation
        /// </summary>
        /// <typeparam name="TClass"></typeparam>
        /// <param name="message"></param>
        /// <param name="args"></param>
        public static void LogInformation<TClass>(this string message, params object[] args)
        {
            new StringLoggerPart().SetCategory<TClass>().SetMessage(message).SetArgs(args).LogInformation();
        }

        /// <summary>
        /// LogInformation
        /// </summary>
        /// <typeparam name="TClass"></typeparam>
        /// <param name="message"></param>
        /// <param name="eventId"></param>
        /// <param name="args"></param>
        public static void LogInformation<TClass>(this string message, EventId eventId, params object[] args)
        {
            new StringLoggerPart().SetCategory<TClass>().SetMessage(message).SetArgs(args).SetEventId(eventId).LogInformation();
        }

        /// <summary>
        /// LogInformation
        /// </summary>
        /// <typeparam name="TClass"></typeparam>
        /// <param name="message"></param>
        /// <param name="exception"></param>
        /// <param name="args"></param>
        public static void LogInformation<TClass>(this string message, Exception exception, params object[] args)
        {
            new StringLoggerPart().SetCategory<TClass>().SetMessage(message).SetArgs(args).SetException(exception).LogInformation();
        }

        /// <summary>
        /// LogInformation
        /// </summary>
        /// <typeparam name="TClass"></typeparam>
        /// <param name="message"></param>
        /// <param name="eventId"></param>
        /// <param name="exception"></param>
        /// <param name="args"></param>
        public static void LogInformation<TClass>(this string message, EventId eventId, Exception exception, params object[] args)
        {
            new StringLoggerPart().SetCategory<TClass>().SetMessage(message).SetArgs(args).SetEventId(eventId).SetException(exception).LogInformation();
        }

        /// <summary>
        /// LogWarning
        /// </summary>
        /// <param name="message"></param>
        /// <param name="args"></param>
        public static void LogWarning(this string message, params object[] args)
        {
            new StringLoggerPart().SetMessage(message).SetArgs(args).LogWarning();
        }

        /// <summary>
        /// LogWarning
        /// </summary>
        /// <param name="message"></param>
        /// <param name="eventId"></param>
        /// <param name="args"></param>
        public static void LogWarning(this string message, EventId eventId, params object[] args)
        {
            new StringLoggerPart().SetMessage(message).SetArgs(args).SetEventId(eventId).LogWarning();
        }

        /// <summary>
        /// LogWarning
        /// </summary>
        /// <param name="message"></param>
        /// <param name="exception"></param>
        /// <param name="args"></param>
        public static void LogWarning(this string message, Exception exception, params object[] args)
        {
            new StringLoggerPart().SetMessage(message).SetArgs(args).SetException(exception).LogWarning();
        }

        /// <summary>
        /// LogWarning
        /// </summary>
        /// <param name="message"></param>
        /// <param name="eventId"></param>
        /// <param name="exception"></param>
        /// <param name="args"></param>
        public static void LogWarning(this string message, EventId eventId, Exception exception, params object[] args)
        {
            new StringLoggerPart().SetMessage(message).SetArgs(args).SetEventId(eventId).SetException(exception).LogWarning();
        }

        /// <summary>
        /// LogWarning
        /// </summary>
        /// <typeparam name="TClass"></typeparam>
        /// <param name="message"></param>
        /// <param name="args"></param>
        public static void LogWarning<TClass>(this string message, params object[] args)
        {
            new StringLoggerPart().SetCategory<TClass>().SetMessage(message).SetArgs(args).LogWarning();
        }

        /// <summary>
        /// LogWarning
        /// </summary>
        /// <typeparam name="TClass"></typeparam>
        /// <param name="message"></param>
        /// <param name="eventId"></param>
        /// <param name="args"></param>
        public static void LogWarning<TClass>(this string message, EventId eventId, params object[] args)
        {
            new StringLoggerPart().SetCategory<TClass>().SetMessage(message).SetArgs(args).SetEventId(eventId).LogWarning();
        }

        /// <summary>
        /// LogWarning
        /// </summary>
        /// <typeparam name="TClass"></typeparam>
        /// <param name="message"></param>
        /// <param name="exception"></param>
        /// <param name="args"></param>
        public static void LogWarning<TClass>(this string message, Exception exception, params object[] args)
        {
            new StringLoggerPart().SetCategory<TClass>().SetMessage(message).SetArgs(args).SetException(exception).LogWarning();
        }

        /// <summary>
        /// LogWarning
        /// </summary>
        /// <typeparam name="TClass"></typeparam>
        /// <param name="message"></param>
        /// <param name="eventId"></param>
        /// <param name="exception"></param>
        /// <param name="args"></param>
        public static void LogWarning<TClass>(this string message, EventId eventId, Exception exception, params object[] args)
        {
            new StringLoggerPart().SetCategory<TClass>().SetMessage(message).SetArgs(args).SetEventId(eventId).SetException(exception).LogWarning();
        }

        /// <summary>
        /// LogError
        /// </summary>
        /// <param name="message"></param>
        /// <param name="args"></param>
        public static void LogError(this string message, params object[] args)
        {
            new StringLoggerPart().SetMessage(message).SetArgs(args).LogError();
        }

        /// <summary>
        /// LogError
        /// </summary>
        /// <param name="message"></param>
        /// <param name="eventId"></param>
        /// <param name="args"></param>
        public static void LogError(this string message, EventId eventId, params object[] args)
        {
            new StringLoggerPart().SetMessage(message).SetArgs(args).SetEventId(eventId).LogError();
        }

        /// <summary>
        /// LogError
        /// </summary>
        /// <param name="message"></param>
        /// <param name="exception"></param>
        /// <param name="args"></param>
        public static void LogError(this string message, Exception exception, params object[] args)
        {
            new StringLoggerPart().SetMessage(message).SetArgs(args).SetException(exception).LogError();
        }

        /// <summary>
        /// LogError
        /// </summary>
        /// <param name="message"></param>
        /// <param name="eventId"></param>
        /// <param name="exception"></param>
        /// <param name="args"></param>
        public static void LogError(this string message, EventId eventId, Exception exception, params object[] args)
        {
            new StringLoggerPart().SetMessage(message).SetArgs(args).SetEventId(eventId).SetException(exception).LogError();
        }

        /// <summary>
        /// LogError
        /// </summary>
        /// <typeparam name="TClass"></typeparam>
        /// <param name="message"></param>
        /// <param name="args"></param>
        public static void LogError<TClass>(this string message, params object[] args)
        {
            new StringLoggerPart().SetCategory<TClass>().SetMessage(message).SetArgs(args).LogError();
        }

        /// <summary>
        /// LogError
        /// </summary>
        /// <typeparam name="TClass"></typeparam>
        /// <param name="message"></param>
        /// <param name="eventId"></param>
        /// <param name="args"></param>
        public static void LogError<TClass>(this string message, EventId eventId, params object[] args)
        {
            new StringLoggerPart().SetCategory<TClass>().SetMessage(message).SetArgs(args).SetEventId(eventId).LogError();
        }

        /// <summary>
        /// LogError
        /// </summary>
        /// <typeparam name="TClass"></typeparam>
        /// <param name="message"></param>
        /// <param name="exception"></param>
        /// <param name="args"></param>
        public static void LogError<TClass>(this string message, Exception exception, params object[] args)
        {
            new StringLoggerPart().SetCategory<TClass>().SetMessage(message).SetArgs(args).SetException(exception).LogError();
        }

        /// <summary>
        /// LogError
        /// </summary>
        /// <typeparam name="TClass"></typeparam>
        /// <param name="message"></param>
        /// <param name="eventId"></param>
        /// <param name="exception"></param>
        /// <param name="args"></param>
        public static void LogError<TClass>(this string message, EventId eventId, Exception exception, params object[] args)
        {
            new StringLoggerPart().SetCategory<TClass>().SetMessage(message).SetArgs(args).SetEventId(eventId).SetException(exception).LogError();
        }

        /// <summary>
        /// LogDebug
        /// </summary>
        /// <param name="message"></param>
        /// <param name="args"></param>
        public static void LogDebug(this string message, params object[] args)
        {
            new StringLoggerPart().SetMessage(message).SetArgs(args).LogDebug();
        }

        /// <summary>
        /// LogDebug
        /// </summary>
        /// <param name="message"></param>
        /// <param name="eventId"></param>
        /// <param name="args"></param>
        public static void LogDebug(this string message, EventId eventId, params object[] args)
        {
            new StringLoggerPart().SetMessage(message).SetArgs(args).SetEventId(eventId).LogDebug();
        }

        /// <summary>
        /// LogDebug
        /// </summary>
        /// <param name="message"></param>
        /// <param name="exception"></param>
        /// <param name="args"></param>
        public static void LogDebug(this string message, Exception exception, params object[] args)
        {
            new StringLoggerPart().SetMessage(message).SetArgs(args).SetException(exception).LogDebug();
        }

        /// <summary>
        /// LogDebug
        /// </summary>
        /// <param name="message"></param>
        /// <param name="eventId"></param>
        /// <param name="exception"></param>
        /// <param name="args"></param>
        public static void LogDebug(this string message, EventId eventId, Exception exception, params object[] args)
        {
            new StringLoggerPart().SetMessage(message).SetArgs(args).SetEventId(eventId).SetException(exception).LogDebug();
        }

        /// <summary>
        /// LogDebug
        /// </summary>
        /// <typeparam name="TClass"></typeparam>
        /// <param name="message"></param>
        /// <param name="args"></param>
        public static void LogDebug<TClass>(this string message, params object[] args)
        {
            new StringLoggerPart().SetCategory<TClass>().SetMessage(message).SetArgs(args).LogDebug();
        }

        /// <summary>
        /// LogDebug
        /// </summary>
        /// <typeparam name="TClass"></typeparam>
        /// <param name="message"></param>
        /// <param name="eventId"></param>
        /// <param name="args"></param>
        public static void LogDebug<TClass>(this string message, EventId eventId, params object[] args)
        {
            new StringLoggerPart().SetCategory<TClass>().SetMessage(message).SetArgs(args).SetEventId(eventId).LogDebug();
        }

        /// <summary>
        /// LogDebug
        /// </summary>
        /// <typeparam name="TClass"></typeparam>
        /// <param name="message"></param>
        /// <param name="exception"></param>
        /// <param name="args"></param>
        public static void LogDebug<TClass>(this string message, Exception exception, params object[] args)
        {
            new StringLoggerPart().SetCategory<TClass>().SetMessage(message).SetArgs(args).SetException(exception).LogDebug();
        }

        /// <summary>
        /// LogDebug
        /// </summary>
        /// <typeparam name="TClass"></typeparam>
        /// <param name="message"></param>
        /// <param name="eventId"></param>
        /// <param name="exception"></param>
        /// <param name="args"></param>
        public static void LogDebug<TClass>(this string message, EventId eventId, Exception exception, params object[] args)
        {
            new StringLoggerPart().SetCategory<TClass>().SetMessage(message).SetArgs(args).SetEventId(eventId).SetException(exception).LogDebug();
        }

        /// <summary>
        /// LogTrace
        /// </summary>
        /// <param name="message"></param>
        /// <param name="args"></param>
        public static void LogTrace(this string message, params object[] args)
        {
            new StringLoggerPart().SetMessage(message).SetArgs(args).LogTrace();
        }

        /// <summary>
        /// LogTrace
        /// </summary>
        /// <param name="message"></param>
        /// <param name="eventId"></param>
        /// <param name="args"></param>
        public static void LogTrace(this string message, EventId eventId, params object[] args)
        {
            new StringLoggerPart().SetMessage(message).SetArgs(args).SetEventId(eventId).LogTrace();
        }

        /// <summary>
        /// LogTrace
        /// </summary>
        /// <param name="message"></param>
        /// <param name="exception"></param>
        /// <param name="args"></param>
        public static void LogTrace(this string message, Exception exception, params object[] args)
        {
            new StringLoggerPart().SetMessage(message).SetArgs(args).SetException(exception).LogTrace();
        }

        /// <summary>
        /// LogTrace
        /// </summary>
        /// <param name="message"></param>
        /// <param name="eventId"></param>
        /// <param name="exception"></param>
        /// <param name="args"></param>
        public static void LogTrace(this string message, EventId eventId, Exception exception, params object[] args)
        {
            new StringLoggerPart().SetMessage(message).SetArgs(args).SetEventId(eventId).SetException(exception).LogTrace();
        }

        /// <summary>
        /// LogTrace
        /// </summary>
        /// <typeparam name="TClass"></typeparam>
        /// <param name="message"></param>
        /// <param name="args"></param>
        public static void LogTrace<TClass>(this string message, params object[] args)
        {
            new StringLoggerPart().SetCategory<TClass>().SetMessage(message).SetArgs(args).LogTrace();
        }

        /// <summary>
        /// LogTrace
        /// </summary>
        /// <typeparam name="TClass"></typeparam>
        /// <param name="message"></param>
        /// <param name="eventId"></param>
        /// <param name="args"></param>
        public static void LogTrace<TClass>(this string message, EventId eventId, params object[] args)
        {
            new StringLoggerPart().SetCategory<TClass>().SetMessage(message).SetArgs(args).SetEventId(eventId).LogTrace();
        }

        /// <summary>
        /// LogTrace
        /// </summary>
        /// <typeparam name="TClass"></typeparam>
        /// <param name="message"></param>
        /// <param name="exception"></param>
        /// <param name="args"></param>
        public static void LogTrace<TClass>(this string message, Exception exception, params object[] args)
        {
            new StringLoggerPart().SetCategory<TClass>().SetMessage(message).SetArgs(args).SetException(exception).LogTrace();
        }

        /// <summary>
        /// LogTrace
        /// </summary>
        /// <typeparam name="TClass"></typeparam>
        /// <param name="message"></param>
        /// <param name="eventId"></param>
        /// <param name="exception"></param>
        /// <param name="args"></param>
        public static void LogTrace<TClass>(this string message, EventId eventId, Exception exception, params object[] args)
        {
            new StringLoggerPart().SetCategory<TClass>().SetMessage(message).SetArgs(args).SetEventId(eventId).SetException(exception).LogTrace();
        }

        /// <summary>
        /// LogCritical
        /// </summary>
        /// <param name="message"></param>
        /// <param name="args"></param>
        public static void LogCritical(this string message, params object[] args)
        {
            new StringLoggerPart().SetMessage(message).SetArgs(args).LogCritical();
        }

        /// <summary>
        /// LogCritical
        /// </summary>
        /// <param name="message"></param>
        /// <param name="eventId"></param>
        /// <param name="args"></param>
        public static void LogCritical(this string message, EventId eventId, params object[] args)
        {
            new StringLoggerPart().SetMessage(message).SetArgs(args).SetEventId(eventId).LogCritical();
        }

        /// <summary>
        /// LogCritical
        /// </summary>
        /// <param name="message"></param>
        /// <param name="exception"></param>
        /// <param name="args"></param>
        public static void LogCritical(this string message, Exception exception, params object[] args)
        {
            new StringLoggerPart().SetMessage(message).SetArgs(args).SetException(exception).LogCritical();
        }

        /// <summary>
        /// LogCritical
        /// </summary>
        /// <param name="message"></param>
        /// <param name="eventId"></param>
        /// <param name="exception"></param>
        /// <param name="args"></param>
        public static void LogCritical(this string message, EventId eventId, Exception exception, params object[] args)
        {
            new StringLoggerPart().SetMessage(message).SetArgs(args).SetEventId(eventId).SetException(exception).LogCritical();
        }

        /// <summary>
        /// LogCritical
        /// </summary>
        /// <typeparam name="TClass"></typeparam>
        /// <param name="message"></param>
        /// <param name="args"></param>
        public static void LogCritical<TClass>(this string message, params object[] args)
        {
            new StringLoggerPart().SetCategory<TClass>().SetMessage(message).SetArgs(args).LogCritical();
        }

        /// <summary>
        /// LogCritical
        /// </summary>
        /// <typeparam name="TClass"></typeparam>
        /// <param name="message"></param>
        /// <param name="eventId"></param>
        /// <param name="args"></param>
        public static void LogCritical<TClass>(this string message, EventId eventId, params object[] args)
        {
            new StringLoggerPart().SetCategory<TClass>().SetMessage(message).SetArgs(args).SetEventId(eventId).LogCritical();
        }

        /// <summary>
        /// LogCritical
        /// </summary>
        /// <typeparam name="TClass"></typeparam>
        /// <param name="message"></param>
        /// <param name="exception"></param>
        /// <param name="args"></param>
        public static void LogCritical<TClass>(this string message, Exception exception, params object[] args)
        {
            new StringLoggerPart().SetCategory<TClass>().SetMessage(message).SetArgs(args).SetException(exception).LogCritical();
        }

        /// <summary>
        /// LogCritical
        /// </summary>
        /// <typeparam name="TClass"></typeparam>
        /// <param name="message"></param>
        /// <param name="eventId"></param>
        /// <param name="exception"></param>
        /// <param name="args"></param>
        public static void LogCritical<TClass>(this string message, EventId eventId, Exception exception, params object[] args)
        {
            new StringLoggerPart().SetCategory<TClass>().SetMessage(message).SetArgs(args).SetEventId(eventId).SetException(exception).LogCritical();
        }
    }
}