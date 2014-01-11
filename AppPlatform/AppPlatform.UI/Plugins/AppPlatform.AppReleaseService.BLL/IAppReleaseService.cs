using System;
using System.Collections.Generic;
using System.Text;

namespace AppPlatform.AppReleaseService.BLL
{
    public interface IAppReleaseService
    {
        void AppUpload();
        void AppUpdate();
        void AppDelete();

    }
}
