// <auto-generated />
// Built from: hl7.fhir.r4b.core version: 4.1.0
  // Option: "NAMESPACE" = "fhirCsR4"

using fhirCsR4.Models;

namespace fhirCsR4.ValueSets
{
  /// <summary>
  /// This value set includes smattering of Adjudication Reason codes.
  /// </summary>
  public static class AdjudicationReasonCodes
  {
    /// <summary>
    /// Not covered
    /// </summary>
    public static readonly Coding NotCovered = new Coding
    {
      Code = "ar001",
      Display = "Not covered",
      System = "http://terminology.hl7.org/CodeSystem/adjudication-reason"
    };
    /// <summary>
    /// Plan Limit Reached
    /// </summary>
    public static readonly Coding PlanLimitReached = new Coding
    {
      Code = "ar002",
      Display = "Plan Limit Reached",
      System = "http://terminology.hl7.org/CodeSystem/adjudication-reason"
    };

    /// <summary>
    /// Literal for code: NotCovered
    /// </summary>
    public const string LiteralNotCovered = "ar001";

    /// <summary>
    /// Literal for code: PlanLimitReached
    /// </summary>
    public const string LiteralPlanLimitReached = "ar002";
  };
}
