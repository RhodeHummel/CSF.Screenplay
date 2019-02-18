﻿using System;
using CSF.Screenplay.Integration;
using CSF.Screenplay.NUnit;
using CSF.Screenplay.Reporting;
using CSF.Screenplay.WebApis.ObjectFormatters;
using NUnit.Framework;

[assembly: ScreenplayAssembly(typeof(CSF.Screenplay.WebApis.Tests.ScreenplayConfig))]

namespace CSF.Screenplay.WebApis.Tests
{
  public class ScreenplayConfig : IIntegrationConfig
  {
    public void Configure(IIntegrationConfigBuilder builder)
    {
      builder.UseWebApis("http://localhost:63444/api/");
      builder.UseReporting(config => {
        config
          .SubscribeToActorsCreatedInCast()
          .WithFormattingStrategy<TimeoutExceptionFormatter>()
          .WithFormattingStrategy<WebApiExceptionFormatter>()
          .WithScenarioRenderer(JsonScenarioRenderer.CreateForFile(TestContext.CurrentContext.WorkDirectory + "\\JsonApis.report.json"))
          ;
      });
    }
  }
}
