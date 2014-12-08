﻿
namespace DcmsMobile.PickWaves.Repository.Config
{
    public class PackingRules
    {
        /// <summary>
        /// This is style for which SKU cases are ignored.
        /// </summary>
        public string Style { get; set; }

        public string CaseId { get; set; }

        /// <summary>
        /// This is flag value to tell that the case is ignore or not.
        /// </summary>
        public bool IgnoreFlag { get; set; }

    }
}