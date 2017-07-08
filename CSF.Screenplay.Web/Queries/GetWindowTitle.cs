﻿using System;
using CSF.Screenplay.Actors;
using CSF.Screenplay.Performables;
using CSF.Screenplay.Web.Abilities;

namespace CSF.Screenplay.Web.Queries
{
  public class GetWindowTitle : Performable<string>
  {
    protected override string GetReport(INamed actor)
    {
      return $"{actor.Name} reads the window title.";
    }

    protected override string PerformAs(IPerformer actor)
    {
      var ability = actor.GetAbility<BrowseTheWeb>();
      return ability.WebDriver.Title;
    }
  }
}
