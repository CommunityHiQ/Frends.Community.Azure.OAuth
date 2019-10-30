# Frends.Community.Azure.OAuth

FRENDS Community Task for Azure OAuth related operations.


- [Installing](#installing)
- [Tasks](#tasks)
     - [GetAccessToken](#getaccesstoken)
- [Building](#building)
- [Contributing](#contributing)
- [Change Log](#change-log)

# Installing

You can install the task via FRENDS UI Task View or you can find the nuget package from the following nuget feed
'Insert nuget feed here'

# Tasks

## GetAccessToken
Authenticates and gets JWT access token.

### Properties

| Property | Type | Description | Example |
| -------- | -------- | -------- | -------- |
| AuthContextURL | string | Argument for new AuthenticationContext(*AuthContextURL*) | 'https://login.windows.net/{{TenantId}}' |
| Resource | string | Resource name for authContext.AcquireTokenAsync(*Resource*, credential) | 'https://management.azure.com/' |
| ClientId | string | Client ID from Azure | 'XXXXXXXX-XXXX-XXXX-XXXX-XXXXXXXXXXXX' |
| ClientSecret | string | Client Secret from Azure | 'AzureClientSecretPassword' |

### Returns

| Property | Type | Description | Example |
| -------- | -------- | -------- | -------- |
| Access token | string | JWT Access token | |

# Building

Clone a copy of the repo

`git clone https://github.com/CommunityHiQ/Frends.Community.Azure.OAuth`

Restore dependencies

`dotnet restore`

Rebuild the project

`dotnet build`

Run Tests

`dotnet test Frends.Community.Azure.OAuth.Tests`

Create a nuget package

`dotnet pack Frends.Community.Azure.OAuth`

# Contributing
When contributing to this repository, please first discuss the change you wish to make via issue, email, or any other method with the owners of this repository before making a change.

1. Fork the repo on GitHub
2. Clone the project to your own machine
3. Commit changes to your own branch
4. Push your work back up to your fork
5. Submit a Pull request so that we can review your changes

NOTE: Be sure to merge the latest from "upstream" before making a pull request!
# Change Log

| Version | Changes |
| ----- | ----- |
| 1.0.1 | First version |
