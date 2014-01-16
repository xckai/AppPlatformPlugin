using System;
using System.Collections.Generic;
using System.Text;

namespace AppPlatform.GroupService.BLL
{
    public interface IGroupService
    {
        void GroupListGet();
        void GroupInfoGet(object GroupID);
        bool GroupAdd(object Group);
        bool GroupUpdate(object Group);
        bool GroupDelete(object GroupID);

    }
}
