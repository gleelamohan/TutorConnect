using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TutorConnectBusinessContracts;
using TutorConnectDataContracts;
using TutorConnectData = TutorConnectData.TutorConnectData;

namespace TutorConnectBusiness
{
    public class TutorConnectBusiness : ITutorConnectBusiness
    {
        private readonly ITutorConnectData _order;

        public TutorConnectBusiness(ITutorConnectData order)
        {
            this._order = order;
        }
        public void CheckOut()
        {
            _order.Process();
        }
    }
}
