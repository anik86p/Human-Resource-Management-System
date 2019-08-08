using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlipstreamHRM.DAL
{
    class JobTitleInformation
    {
        private string _jobTitleName;
        private string _jobTitleDescription;

        public string JobTitleName
        {
            set
            {
                this._jobTitleName = value;
            }
            get
            {
                return _jobTitleName;
            }
        }

        public string JobTitleDescription
        {
            set
            {
                this._jobTitleDescription = value;
            }
            get
            {
                return _jobTitleDescription;
            }
        }
    }
}
