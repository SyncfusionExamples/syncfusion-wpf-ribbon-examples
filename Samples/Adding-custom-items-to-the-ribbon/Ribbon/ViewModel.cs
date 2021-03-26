using Syncfusion.Windows.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ribbon
{
    public class ViewModel : NotificationObject
    {
        #region Fields
        /// <summary>
        /// Maintains the Header Row selection.
        /// </summary>
        private bool isHeaderRowChecked = true;

        /// <summary>
        /// Maintains the Total Row selection.
        /// </summary>
        private bool isTotalRowChecked = false;

        /// <summary>
        /// Maintains the Banded Row selection.
        /// </summary>
        private bool isBandedRowChecked = false;

        /// <summary>
        /// Maintains the First Column selection.
        /// </summary>
        private bool isFirstColumnChecked = true;

        /// <summary>
        /// Maintains the Last Column selection.
        /// </summary>
        private bool isLastColumnChecked = false;

        /// <summary>
        /// Maintains the Banded Column selection.
        /// </summary>
        private bool isBandedColumnChecked = false;
        #endregion

        #region Constructor

        public ViewModel()
        {

        }
        #endregion
        #region Properties

        /// <summary>
        /// Gets or sets whether the Header Row is checked.
        /// </summary>
        public bool IsHeaderRowChecked
        {
            get
            {
                return isHeaderRowChecked;
            }
            set
            {
                isHeaderRowChecked = value;
                RaisePropertyChanged("IsHeaderRowChecked");
            }
        }

        /// <summary>
        /// Gets or sets whether the Total Row is checked.
        /// </summary>
        public bool IsTotalRowChecked
        {
            get
            {
                return isTotalRowChecked;
            }
            set
            {
                isTotalRowChecked = value;
                RaisePropertyChanged("IsTotalRowChecked");
            }
        }

        /// <summary>
        /// Gets or sets whether the Banded Row is checked.
        /// </summary>
        public bool IsBandedRowChecked
        {
            get
            {
                return isBandedRowChecked;
            }
            set
            {
                isBandedRowChecked = value;
                RaisePropertyChanged("IsBandedRowChecked");
            }
        }
        /// <summary>
        /// Gets or sets whether the First Column is checked.
        /// </summary>
        public bool IsFirstColumnChecked
        {
            get
            {
                return isFirstColumnChecked;
            }
            set
            {
                isFirstColumnChecked = value;
                RaisePropertyChanged("IsFirstColumnChecked");
            }
        }
        /// <summary>
        /// Gets or sets whether the Last Column is checked.
        /// </summary>
        public bool IsLastColumnChecked
        {
            get
            {
                return isLastColumnChecked;
            }
            set
            {
                isLastColumnChecked = value;
                RaisePropertyChanged("IsLastColumnChecked");
            }
        }
        /// <summary>
        /// Gets or sets whether the Banded Column is checked.
        /// </summary>
        public bool IsBandedColumnChecked
        {
            get
            {
                return isBandedColumnChecked;
            }
            set
            {
                isBandedColumnChecked = value;
                RaisePropertyChanged("IsBandedColumnChecked");
            }
        }
        #endregion
    }
}
