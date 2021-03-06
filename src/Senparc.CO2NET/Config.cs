﻿#region Apache License Version 2.0
/*----------------------------------------------------------------

Copyright 2018 Jeffrey Su & Suzhou Senparc Network Technology Co.,Ltd.

Licensed under the Apache License, Version 2.0 (the "License"); you may not use this file
except in compliance with the License. You may obtain a copy of the License at

http://www.apache.org/licenses/LICENSE-2.0

Unless required by applicable law or agreed to in writing, software distributed under the
License is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND,
either express or implied. See the License for the specific language governing permissions
and limitations under the License.

Detail: https://github.com/JeffreySu/WeiXinMPSDK/blob/master/license.md

----------------------------------------------------------------*/
#endregion Apache License Version 2.0

/*----------------------------------------------------------------
    Copyright (C) 2018 Senparc
  
    文件名：Config.cs
    文件功能描述：全局配置文件
    
    
    创建标识：Senparc - 20180602
 

    ----  CO2NET   ----
    ----  split from Senparc.Weixin/Config.cs  ----

    修改标识：Senparc - 201806021
    修改描述：v0.1.2 为 DefaultCacheNamespace 设置默认值
   
----------------------------------------------------------------*/


namespace Senparc.CO2NET
{
    /// <summary>
    /// Senparc.CO2NET 全局设置
    /// </summary>
    public class Config
    {
        private static bool _isDebug = false;//TODO:需要考虑分布式的情况，后期需要储存在缓存中

        /// <summary>
        /// 指定是否是Debug状态，如果是，系统会自动输出日志
        /// </summary>
        public static bool IsDebug
        {
            get
            {
                return _isDebug;
            }
            set
            {
                _isDebug = value;

                //if (_isDebug)
                //{
                //    WeixinTrace.Open();
                //}
                //else
                //{
                //    WeixinTrace.Close();
                //}
            }
        }

        /// <summary>
        /// 请求超时设置（以毫秒为单位），默认为10秒。
        /// 说明：此处常量专为提供给方法的参数的默认值，不是方法内所有请求的默认超时时间。
        /// </summary>
        public const int TIME_OUT = 10000;

        /// <summary>
        /// JavaScriptSerializer 类接受的 JSON 字符串的最大长度
        /// </summary>
        public static int MaxJsonLength = int.MaxValue;//TODO:需要考虑分布式的情况，后期需要储存在缓存中


        public static string _defaultCacheNamespace = "DefaultCache";

        /// <summary>
        /// 默认缓存键的第一级命名空间，默认值：DefaultCache
        /// </summary>
        public static string DefaultCacheNamespace
        {
            get
            {
                return _defaultCacheNamespace ?? "DefaultCache";
            }
            set
            {
                _defaultCacheNamespace = value;
            }
        }

        /// <summary>
        /// 网站根目录绝对路径
        /// </summary>
        public static string RootDictionaryPath { get; set; }
    }
}
