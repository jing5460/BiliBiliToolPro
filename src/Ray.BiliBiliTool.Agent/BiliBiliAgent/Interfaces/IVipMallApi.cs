﻿using Ray.BiliBiliTool.Agent.Attributes;
using Ray.BiliBiliTool.Agent.BiliBiliAgent.Dtos;
using Ray.BiliBiliTool.Agent.BiliBiliAgent.Dtos.ViewMall;
using WebApiClientCore.Attributes;

namespace Ray.BiliBiliTool.Agent.BiliBiliAgent.Interfaces;

[Header("Host", "show.bilibili.com")]
[LogFilter]
public interface IVipMallApi
{
    [HttpPost("/api/activity/fire/common/event/dispatch")]
    Task<BiliApiResponse> ViewVipMallAsync(
        [JsonContent] ViewVipMallRequest request,
        [Header("Cookie")] string ck
    );
}
