using CamundaClient.Service;
using CamundaClient.Worker;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CamundaClient
{

    public class CamundaClientOptions
    {
        public string RestUsername { get; set; }
        public string RestPassword { get; set; }
        public Uri RestUrl { get; set; }
        public string[] TenantIds { get; set; }
        public bool LongPooling { get; set; }
        public long AsyncResponseTimeout { get; set; } = 30000;//30 seconds
    }
}