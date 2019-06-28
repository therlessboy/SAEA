﻿/****************************************************************************
*项目名称：SAEA.Http2.Interfaces
*CLR 版本：4.0.30319.42000
*机器名称：WENLI-PC
*命名空间：SAEA.Http2.Interfaces
*类 名 称：ICloseableByteStream
*版 本 号：V1.0.0.0
*创建人： yswenli
*电子邮箱：wenguoli_520@qq.com
*创建时间：2019/6/27 16:25:02
*描述：
*=====================================================================
*修改时间：2019/6/27 16:25:02
*修 改 人： yswenli
*版 本 号： V1.0.0.0
*描    述：
*****************************************************************************/
using System.Threading.Tasks;

namespace SAEA.Http2.Interfaces
{
    public interface ICloseableByteStream
    {
        Task CloseAsync();
    }
}
