﻿using System.Collections.Generic;

namespace DcmsMobile.DcmsLite.ViewModels.Ship
{
    public class IndexViewModel : ViewModelBase
    {
        private IList<PoModel> _poList;
        public IList<PoModel> PoList
        {
            get
            {
                return _poList ?? (_poList = new PoModel[0]);
            }
            set
            {
                _poList = value;
            }
        }
    }
}