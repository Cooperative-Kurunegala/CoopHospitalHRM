using HR_Application_CO_OP_HOS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HR_Application_CO_OP_HOS.Services
{
    public interface IRelatedPartyLeaveTypeService
    {
        IEnumerable<RelatedPartyLeaveType> GetAll();
        RelatedPartyLeaveType Get(int id);
        void Create(RelatedPartyLeaveType RelatedPartyLeaveType);
        void Update(RelatedPartyLeaveType RelatedPartyLeaveType);
        void Delete(int id);
    }
}