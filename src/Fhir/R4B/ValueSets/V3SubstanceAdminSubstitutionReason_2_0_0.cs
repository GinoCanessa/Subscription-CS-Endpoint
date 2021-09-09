// <auto-generated />
// Built from: hl7.fhir.r4b.core version: 4.1.0
  // Option: "NAMESPACE" = "fhirCsR4"

using fhirCsR4.Models;

namespace fhirCsR4.ValueSets
{
  /// <summary>
  /// Value Set: http://terminology.hl7.org/ValueSet/v3-SubstanceAdminSubstitutionReason|2.0.0
  /// </summary>
  public static class V3SubstanceAdminSubstitutionReasonCodes
  {
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding ContinuingTherapy = new Coding
    {
      Code = "CT",
      Display = "continuing therapy",
      System = "http://terminology.hl7.org/CodeSystem/v3-ActReason"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding FormularyPolicy = new Coding
    {
      Code = "FP",
      Display = "formulary policy",
      System = "http://terminology.hl7.org/CodeSystem/v3-ActReason"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding OutOfStock = new Coding
    {
      Code = "OS",
      Display = "out of stock",
      System = "http://terminology.hl7.org/CodeSystem/v3-ActReason"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding RegulatoryRequirement = new Coding
    {
      Code = "RR",
      Display = "regulatory requirement",
      System = "http://terminology.hl7.org/CodeSystem/v3-ActReason"
    };

    /// <summary>
    /// Literal for code: ContinuingTherapy
    /// </summary>
    public const string LiteralContinuingTherapy = "CT";

    /// <summary>
    /// Literal for code: FormularyPolicy
    /// </summary>
    public const string LiteralFormularyPolicy = "FP";

    /// <summary>
    /// Literal for code: OutOfStock
    /// </summary>
    public const string LiteralOutOfStock = "OS";

    /// <summary>
    /// Literal for code: RegulatoryRequirement
    /// </summary>
    public const string LiteralRegulatoryRequirement = "RR";
  };
}