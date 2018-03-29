# Entities.StaticFooBars.ApiController

[![AppVeyor build status](https://img.shields.io/appveyor/ci/cdorst/entities-staticfoobars-apicontroller.svg?label=AppVeyor&style=for-the-badge)](https://ci.appveyor.com/project/cdorst/entities-staticfoobars-apicontroller)
[![NuGet package status](https://img.shields.io/nuget/v/CDorst.Entities.StaticFooBars.ApiController.svg?label=NuGet&style=for-the-badge)](https://www.nuget.org/packages/CDorst.Entities.StaticFooBars.ApiController)

## Description

ASP.NET Core web API controller for StaticFooBar entities

## Environment Variables

This project depends on this environment variable:

Name | Description
---- | -----------
`LOCAL_NUGET_SOURCE_PATH` | *Required* to build the project, but not required during code execution. This is set to `c:\projects\nuget\cache` on the build server. On your development machine, set this to an empty, existing path. `dotnet restore` will inspect this folder prior to checking NuGet.

## Dependencies

Name | Status
---- | ------
[CDorst.Entities.StaticFooBars.DatabaseContext](https://github.com/CDorst/Entities.StaticFooBars.DatabaseContext) | [![AppVeyor build status](https://img.shields.io/appveyor/ci/cdorst/entities-staticfoobars-databasecontext.svg?label=AppVeyor&style=flat-square)](https://ci.appveyor.com/project/cdorst/entities-staticfoobars-databasecontext) [![NuGet package status](https://img.shields.io/nuget/v/CDorst.Entities.StaticFooBars.DatabaseContext.svg?label=NuGet&style=flat-square)](https://www.nuget.org/packages/CDorst.Entities.StaticFooBars.DatabaseContext)
[CDorst.DevOps.Code.DataAccess.Metapackages.ApiControllers](https://github.com/CDorst/DevOps.Code.DataAccess.Metapackages.ApiControllers) | [![AppVeyor build status](https://img.shields.io/appveyor/ci/cdorst/devops-code-dataaccess-metapackages-apicontrollers.svg?label=AppVeyor&style=flat-square)](https://ci.appveyor.com/project/cdorst/devops-code-dataaccess-metapackages-apicontrollers) [![NuGet package status](https://img.shields.io/nuget/v/CDorst.DevOps.Code.DataAccess.Metapackages.ApiControllers.svg?label=NuGet&style=flat-square)](https://www.nuget.org/packages/CDorst.DevOps.Code.DataAccess.Metapackages.ApiControllers)

## NuGet

This project is published as a NuGet package at [https://www.nuget.org/packages/CDorst.Entities.StaticFooBars.ApiController](https://www.nuget.org/packages/CDorst.Entities.StaticFooBars.ApiController)

## Version

1.0.14

## Metaproject

Entities.StaticFooBars.ApiController is maintained by robots and exists because of a declarative template metaproject. View the metaproject's component directory at [https://github.com/CDorst/Project.Index](https://github.com/CDorst/Project.Index)

