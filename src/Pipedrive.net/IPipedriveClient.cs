﻿using System;

namespace Pipedrive
{
    public interface IPipedriveClient
    {
        void SetRequestTimeout(TimeSpan timeout);

        IConnection Connection { get; }

        IActivitiesClient Activity { get; }

        IActivityFieldsClient ActivityField { get; }

        IActivityTypesClient ActivityType { get; }

        ICurrenciesClient Currency { get; }

        IDealsClient Deal { get; }

        IDealFieldsClient DealField { get; }

        IOrganizationsClient Organization { get; }

        IOrganizationFieldsClient OrganizationField { get; }

        IPersonsClient Person { get; }

        IPersonFieldsClient PersonField { get; }

        IUsersClient User { get; }
    }
}
