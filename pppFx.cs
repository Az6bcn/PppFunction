using System;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.Extensions.Logging;

namespace SlotSizeFunc
{
    public static class pppFx
    {
        [FunctionName("pppFx")]
        public static void Run([TimerTrigger("0 * 12 * * 6")] TimerInfo myTimer, ILogger log)
        {
            log.LogInformation($"C# Timer trigger function executed at: {DateTime.Now}");
        }
    }
}
