﻿namespace MVI4Unity
{
    public abstract class AStateBase
    {
        /// <summary>
        /// 当前触发状态变更的函数标签
        /// </summary>
        public int currentFunTag;

        /// <summary>
        /// 无效的函数标签
        /// 请避免使用这个值来作为枚举值
        /// </summary>
        const int INVAILD_FUN_TAG = -999999999;

        public AStateBase ()
        {
            currentFunTag = INVAILD_FUN_TAG;
        }
    }
}