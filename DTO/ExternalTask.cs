﻿using System.Collections.Generic;

namespace CamundaClient.Dto
{
    public class ExternalTask
    {
        public string ActivityId { get; set; }
        public string ActivityInstanceId { get; set; }
        public string ProcessInstanceId { get; set; }
        public string ProcessDefinitionId { get; set; }
        public string Id { get; set; }
        public int? Retries { get; set; }
        public Dictionary<string, Variable> Variables { get; set; }
        public string TopicName { get; set; }
        public string TenantId { get; set; }
        public string WorkerId { get; set; }
        public int? Priority { get; set; }

        public override string ToString() => $"ExternalTask [Id={Id}, ActivityId={ActivityId}]";
    }

}
