using System;
using SiteIreneEgler.Models.ViewModels;

namespace SiteIreneEgler.Models.ViewModels
{
    public class ErrorViewModel
    {
        public string RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}