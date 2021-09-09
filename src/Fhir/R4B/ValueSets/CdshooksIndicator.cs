// <auto-generated />
// Built from: hl7.fhir.r4b.core version: 4.1.0
  // Option: "NAMESPACE" = "fhirCsR4"

using fhirCsR4.Models;

namespace fhirCsR4.ValueSets
{
  /// <summary>
  /// This value set captures the set of indicator codes defined by the CDS Hooks specification.
  /// </summary>
  public static class CdshooksIndicatorCodes
  {
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding TheResponseIsCriticalAndIndicatesTheWorkflowShouldNotBeAllowedToProceed = new Coding
    {
      Code = "critical",
      Display = "The response is critical and indicates the workflow should not be allowed to proceed",
      System = "http://cds-hooks.hl7.org/CodeSystem/indicator"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding TheResponseIsInformational = new Coding
    {
      Code = "info",
      Display = "The response is informational",
      System = "http://cds-hooks.hl7.org/CodeSystem/indicator"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding TheResponseIsAWarning = new Coding
    {
      Code = "warning",
      Display = "The response is a warning",
      System = "http://cds-hooks.hl7.org/CodeSystem/indicator"
    };

    /// <summary>
    /// Literal for code: TheResponseIsCriticalAndIndicatesTheWorkflowShouldNotBeAllowedToProceed
    /// </summary>
    public const string LiteralTheResponseIsCriticalAndIndicatesTheWorkflowShouldNotBeAllowedToProceed = "critical";

    /// <summary>
    /// Literal for code: TheResponseIsInformational
    /// </summary>
    public const string LiteralTheResponseIsInformational = "info";

    /// <summary>
    /// Literal for code: TheResponseIsAWarning
    /// </summary>
    public const string LiteralTheResponseIsAWarning = "warning";
  };
}
