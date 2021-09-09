// <auto-generated />
// Built from: hl7.fhir.r4b.core version: 4.1.0
  // Option: "NAMESPACE" = "fhirCsR4"

using fhirCsR4.Models;

namespace fhirCsR4.ValueSets
{
  /// <summary>
  /// This value set includes Example Coverage Financial Exception Codes.
  /// </summary>
  public static class CoverageFinancialExceptionCodes
  {
    /// <summary>
    /// Children in the foster care have all copays and deductibles waived.
    /// </summary>
    public static readonly Coding FosterChild = new Coding
    {
      Code = "foster",
      Display = "Foster child",
      System = "http://terminology.hl7.org/CodeSystem/ex-coverage-financial-exception"
    };
    /// <summary>
    /// Retired persons have all copays and deductibles reduced.
    /// </summary>
    public static readonly Coding Retired = new Coding
    {
      Code = "retired",
      Display = "Retired",
      System = "http://terminology.hl7.org/CodeSystem/ex-coverage-financial-exception"
    };

    /// <summary>
    /// Literal for code: FosterChild
    /// </summary>
    public const string LiteralFosterChild = "foster";

    /// <summary>
    /// Literal for code: Retired
    /// </summary>
    public const string LiteralRetired = "retired";
  };
}
