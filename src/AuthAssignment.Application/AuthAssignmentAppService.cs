using System;
using System.Collections.Generic;
using System.Text;
using AuthAssignment.Localization;
using Volo.Abp.Application.Services;

namespace AuthAssignment;

/* Inherit your application services from this class.
 */
public abstract class AuthAssignmentAppService : ApplicationService
{
    protected AuthAssignmentAppService()
    {
        LocalizationResource = typeof(AuthAssignmentResource);
    }
}
