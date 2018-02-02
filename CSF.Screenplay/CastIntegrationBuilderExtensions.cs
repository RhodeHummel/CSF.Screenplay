﻿using System;
using CSF.Screenplay.Actors;
using CSF.Screenplay.Integration;

namespace CSF.Screenplay
{
  /// <summary>
  /// Extension methods related to integrating an <see cref="ICast"/> with Screenplay.
  /// </summary>
  public static class CastIntegrationBuilderExtensions
  {
    /// <summary>
    /// Configures the current integration to make use of an <see cref="ICast"/> instance.
    /// This includes dismissing that cast after each scenario.
    /// </summary>
    /// <param name="helper">Helper.</param>
    /// <param name="cast">Cast.</param>
    /// <param name="name">Name.</param>
    public static void UseCast(this IIntegrationConfigBuilder helper, ICast cast = null, string name = null)
    {
      if(helper == null)
        throw new ArgumentNullException(nameof(helper));

      helper.ServiceRegistrations.PerScenario.Add(regBuilder => {
        regBuilder
          .RegisterFactory((IScenario s) => cast?? new Cast(s.Identity))
          .As<ICast>()
          .WithName(name);
      });
    }

    /// <summary>
    /// Configures the current integration to make use of an <see cref="IStage"/> instance.
    /// </summary>
    /// <param name="helper">Helper.</param>
    /// <param name="stage">Stage.</param>
    /// <param name="name">Name.</param>
    public static void UseStage(this IIntegrationConfigBuilder helper, IStage stage = null, string name = null)
    {
      if(helper == null)
        throw new ArgumentNullException(nameof(helper));

      helper.ServiceRegistrations.PerScenario.Add(regBuilder => {
        regBuilder
          .RegisterFactory(() => stage?? new Stage())
          .As<IStage>()
          .WithName(name);
      });
    }
  }
}
