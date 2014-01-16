using System;
using System.Collections.Generic;
using System.Text;

namespace AppPlatform.AppReleaseService.BLL
{
    public interface IAppReleaseService
    {
        bool AppUpload(object App);
        bool AppUpdate(object App);
        bool AppDelete(object App);

    }
}
