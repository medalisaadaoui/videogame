#if IAP_ANALYTICS_SERVICE_ENABLED || IAP_ANALYTICS_SERVICE_ENABLED_WITH_SERVICE_COMPONENT
using System;
using Unity.Services.Analytics;

namespace UnityEngine.Purchasing
{
    class AnalyticsTransactionReceipt
    {
        public string transactionReceipt { get; set; }
        public string transactionReceiptSignature { get; set; }
        public TransactionServer? transactionServer { get; set; }
    }
}
#endif
