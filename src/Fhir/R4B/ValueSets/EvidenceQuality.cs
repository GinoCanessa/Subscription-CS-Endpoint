// <auto-generated />
// Built from: hl7.fhir.r4b.core version: 4.1.0
  // Option: "NAMESPACE" = "fhirCsR4"

using fhirCsR4.Models;

namespace fhirCsR4.ValueSets
{
  /// <summary>
  /// A rating system that describes the quality of evidence such as the GRADE, DynaMed, or Oxford CEBM systems.
  /// </summary>
  public static class EvidenceQualityCodes
  {
    /// <summary>
    /// High quality evidence.
    /// </summary>
    public static readonly Coding HighQuality = new Coding
    {
      Code = "high",
      Display = "High quality",
      System = "http://terminology.hl7.org/CodeSystem/evidence-quality"
    };
    /// <summary>
    /// Low quality evidence.
    /// </summary>
    public static readonly Coding LowQuality = new Coding
    {
      Code = "low",
      Display = "Low quality",
      System = "http://terminology.hl7.org/CodeSystem/evidence-quality"
    };
    /// <summary>
    /// Moderate quality evidence.
    /// </summary>
    public static readonly Coding ModerateQuality = new Coding
    {
      Code = "moderate",
      Display = "Moderate quality",
      System = "http://terminology.hl7.org/CodeSystem/evidence-quality"
    };
    /// <summary>
    /// Very low quality evidence.
    /// </summary>
    public static readonly Coding VeryLowQuality = new Coding
    {
      Code = "very-low",
      Display = "Very low quality",
      System = "http://terminology.hl7.org/CodeSystem/evidence-quality"
    };

    /// <summary>
    /// Literal for code: HighQuality
    /// </summary>
    public const string LiteralHighQuality = "high";

    /// <summary>
    /// Literal for code: LowQuality
    /// </summary>
    public const string LiteralLowQuality = "low";

    /// <summary>
    /// Literal for code: ModerateQuality
    /// </summary>
    public const string LiteralModerateQuality = "moderate";

    /// <summary>
    /// Literal for code: VeryLowQuality
    /// </summary>
    public const string LiteralVeryLowQuality = "very-low";
  };
}
