﻿using CSF.Screenplay.Integration;
using CSF.Screenplay.Reporting;
using CSF.Screenplay.SpecFlow;
using CSF.Screenplay.SpecFlow.Tests.Abilities;
using NUnit.Framework;

[assembly: ScreenplayAssembly(typeof(CSF.Screenplay.SpecFlow.Tests.ScreenplayConfig))]

namespace CSF.Screenplay.SpecFlow.Tests
{
  public class ScreenplayConfig : IIntegrationConfig
  {
    public void Configure(IIntegrationConfigBuilder builder)
    {
      builder.UseReporting(config => {
        config
          .SubscribeToActorsCreatedInCast()
          .WithFormattingStrategy<ReportFormatting.TimeSpanFormattingStrategy>()
          .WithScenarioRenderer(JsonScenarioRenderer.CreateForFile(TestContext.CurrentContext.WorkDirectory + "\\SpecFlow.report.json"))
          ;
      });

      builder.ServiceRegistrations.PerScenario.Add(b => {
        b.RegisterType<AddNumbers>();
      });
    }
  }
}
