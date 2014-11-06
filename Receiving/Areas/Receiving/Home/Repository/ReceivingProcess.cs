﻿using System;

namespace DcmsMobile.Receiving.Areas.Receiving.Home.Repository
{
    public class ReceivingProcess
    {
        public int ProcessId { get; set; }

        public string ProNumber { get; set; }

        public string CarrierId { get; set; }

        public string CarrierName { get; set; }

        public DateTime? ProDate { get; set; }

        public string OperatorName { get; set; }

        public DateTime? StartDate { get; set; }

        public int PalletCount { get; set; }

        public int CartonCount { get; set; }

        public int? ExpectedCartons { get; set; }

        public int? PalletLimit { get; set; }

        public string PriceSeasonCode { get; set; }

        public string SpotCheckAreaId { get; set; }

        public string ReceivingAreaId { get; set; }

        public DateTime? ReceivingEndDate { get; set; }
    }
}



//$Id$