﻿using System;
using CSF.Screenplay.Actors;
using CSF.Screenplay.Performables;
using CSF.Screenplay.Web.Abilities;
using CSF.Screenplay.Web.Actions;
using CSF.Screenplay.Web.Models;
using OpenQA.Selenium;

namespace CSF.Screenplay.Web.Queries
{
  public class GetConvertedValue<T> : TargettedAction<T>
  {
    protected override string GetReport(INamed actor)
    {
      return $"{actor.Name} reads {Target.GetName()}.";
    }

    protected override T PerformAs(IPerformer actor, BrowseTheWeb ability, IWebElement element)
    {
      var stringValue = element.Text;
      return (T) Convert.ChangeType(stringValue, typeof(T));
    }

    public GetConvertedValue(ITarget target) : base(target) {}
  }
}
