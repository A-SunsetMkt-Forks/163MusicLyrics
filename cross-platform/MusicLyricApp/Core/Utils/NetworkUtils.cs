﻿using System.Net.NetworkInformation;
using System.Threading.Tasks;

namespace MusicLyricApp.Core.Utils;

public static class NetworkUtils
{
    private const string TestHostName = "bilibili.com";
    private static readonly Ping Ping = new();
                
    /// <summary>
    /// 检测网络延迟, 检测失败返回-1, 单位为毫秒
    /// </summary>
    /// <param name="timeout">时间限制</param>
    /// <returns>网络延迟</returns>
    /// <exception cref="PingException">检测失败</exception>
    public static long GetWebRoundtripTime(int timeout = 200)
    {
        try
        {
            var info = Ping.Send(TestHostName, timeout);
            if (info.Status == IPStatus.Success)
                return info.RoundtripTime;
            else
                return -1;
        }
        catch (System.Exception)
        {
            return -1;
        }
    }

    /// <summary>
    /// 检测网络延迟的异步版本, 检测失败返回-1, 单位为毫秒
    /// </summary>
    /// <returns>网络延迟</returns>
    public static async Task<long> GetWebRoundtripTimeAsync(int timeout = 200)
    {
        try
        {
            var info = await Ping.SendPingAsync(TestHostName, timeout);
            if (info.Status == IPStatus.Success)
                return info.RoundtripTime;
            else
                return -1;
        }
        catch (System.Exception)
        {
            return -1;
        }
    }
}