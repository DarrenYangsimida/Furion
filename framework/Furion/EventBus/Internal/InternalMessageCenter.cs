﻿using Furion.TaskScheduler;
using System;
using System.Collections.Concurrent;
using System.Linq;

namespace Furion.EventBus
{
    /// <summary>
    /// 轻量级消息中心（进程内）
    /// </summary>
    internal sealed class InternalMessageCenter
    {
        /// <summary>
        /// 消息注册队列
        /// </summary>
        private readonly ConcurrentDictionary<string, Action<string, object>[]> MessageHandlerQueues = new();

        /// <summary>
        /// 类型消息 Id 注册表
        /// </summary>
        private readonly ConcurrentBag<string> TypeMessageIdsRegisterTable = new();

        /// <summary>
        /// 私有构造函数
        /// </summary>
        private InternalMessageCenter()
        {
        }

        /// <summary>
        /// 采用延迟加载设计模式处理单例
        /// </summary>
        private static readonly Lazy<InternalMessageCenter> InstanceLock = new(() => new InternalMessageCenter());

        /// <summary>
        /// 获取消息中心对象
        /// </summary>
        internal static InternalMessageCenter Instance => InstanceLock.Value;

        /// <summary>
        /// 订阅消息
        /// </summary>
        /// <param name="messageId"></param>
        /// <param name="messageHandlers"></param>
        internal void Subscribe<T>(string messageId, params Action<string, object>[] messageHandlers)
        {
            Subscribe(typeof(T), messageId, messageHandlers);
        }

        /// <summary>
        /// 发送消息
        /// </summary>
        /// <param name="messageId"></param>
        /// <param name="payload"></param>
        internal void Send(string messageId, object payload)
        {
            if (MessageHandlerQueues.TryGetValue(messageId, out var messageHandlers))
            {
                foreach (var eventHandler in messageHandlers)
                {
                    // 采用后台线程执行
                    SpareTime.DoIt(() => eventHandler?.Invoke(messageId, payload));
                }
            }
        }

        /// <summary>
        /// 取消订阅
        /// </summary>
        /// <param name="messageId"></param>
        internal void Unsubscribe(string messageId)
        {
            if (!MessageHandlerQueues.ContainsKey(messageId)) return;

            MessageHandlerQueues.TryRemove(messageId, out _);
        }

        /// <summary>
        /// 订阅消息
        /// </summary>
        /// <param name="t"></param>
        /// <param name="messageId"></param>
        /// <param name="messageHandlers"></param>
        internal void Subscribe(Type t, string messageId, params Action<string, object>[] messageHandlers)
        {
            // 判断当前类型是否已经注册过
            var uniqueMessageId = $"{t.FullName}_{messageId}";
            if (TypeMessageIdsRegisterTable.Contains(uniqueMessageId)) return;
            TypeMessageIdsRegisterTable.Add(uniqueMessageId);

            // 如果没有包含事件Id，则添加
            if (!MessageHandlerQueues.ContainsKey(messageId)) MessageHandlerQueues.TryAdd(messageId, messageHandlers);
            else
            {
                var combineMessageHandlers = MessageHandlerQueues[messageId].ToList();
                combineMessageHandlers.AddRange(messageHandlers);

                MessageHandlerQueues[messageId] = combineMessageHandlers.ToArray();
            }
        }
    }
}