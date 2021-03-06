﻿/*----------------------------------------------------------------
 Copyright (C) 2018 SuperGMS (Grant 巩建春)  本软件的所有源码都可以免费的进行学习交流,切勿用于商业用途

 项目名称： SuperGMS.Config
 文件名：   Configuration
 创建者：   grant(巩建春) nnn987@126.com
 CLR版本：  4.0.30319.42000
 时间：     2018/4/19 11:56:47

 功能描述：

----------------------------------------------------------------*/

using System;

namespace SuperGMS.Config
{
    public class ServerConfig
    {
        /// <summary>
        ///  rpcService
        /// </summary>
        public RpcService RpcService { get; set; }

        public ConfigCenter ConfigCenter { get; set; }
    }
}