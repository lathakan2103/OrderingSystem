﻿using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using GONOrderingSystems.Common.DataModels;
using GONOrderingSystems.Api.Model;

namespace GONOrderingSystems.Controllers.Interface
{
    public interface IOrderApi
    {
        Task<Order> FetchOrder(string orderId);
        Task<string> SubmitOrder([FromBody]SubmitOrderDto submitOrderDto);
        Task<string> CommitOrder([FromBody]CommitOrderDto commitOrderDto);
    }
}
