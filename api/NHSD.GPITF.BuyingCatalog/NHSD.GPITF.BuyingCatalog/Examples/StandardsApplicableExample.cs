﻿using NHSD.GPITF.BuyingCatalog.Models;
using Swashbuckle.AspNetCore.Examples;

namespace NHSD.GPITF.BuyingCatalog.Examples
{
#pragma warning disable CS1591
  public sealed class StandardsApplicableExample : IExamplesProvider
  {
    public object GetExamples()
    {
      return new StandardsApplicable
      {
        Id = "0F2614F9-2521-414A-A448-0096C0DF3ABE",
        SolutionId = "A3C6830F-2E7C-4545-A4B9-02D20C4C92E1",
        StandardId = "INT2"
      };
    }
  }
#pragma warning restore CS1591
}
