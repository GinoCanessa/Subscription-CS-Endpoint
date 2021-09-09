// <auto-generated />
// Built from: hl7.fhir.r4b.core version: 4.1.0
  // Option: "NAMESPACE" = "fhirCsR4"

using fhirCsR4.Models;

namespace fhirCsR4.ValueSets
{
  /// <summary>
  /// The value set to instantiate this attribute should be drawn from a terminologically robust code system that consists of or contains concepts to support describing the status of the patient towards perceived immunity against a vaccine preventable disease. This value set is provided as a suggestive example.
  /// </summary>
  public static class ImmunizationRecommendationStatusCodes
  {
    /// <summary>
    /// The patient is fully protected and no further doses are recommended.
    /// </summary>
    public static readonly Coding Complete = new Coding
    {
      Code = "complete",
      Display = "Complete",
      System = "http://terminology.hl7.org/CodeSystem/immunization-recommendation-status"
    };
    /// <summary>
    /// The patient is contraindicated for futher doses.
    /// </summary>
    public static readonly Coding Contraindicated = new Coding
    {
      Code = "contraindicated",
      Display = "Contraindicated",
      System = "http://terminology.hl7.org/CodeSystem/immunization-recommendation-status"
    };
    /// <summary>
    /// The patient is due for their next vaccination.
    /// </summary>
    public static readonly Coding Due = new Coding
    {
      Code = "due",
      Display = "Due",
      System = "http://terminology.hl7.org/CodeSystem/immunization-recommendation-status"
    };
    /// <summary>
    /// The patient is immune to the target disease and further immunization against the disease is not likely to provide benefit.
    /// </summary>
    public static readonly Coding Immune = new Coding
    {
      Code = "immune",
      Display = "Immune",
      System = "http://terminology.hl7.org/CodeSystem/immunization-recommendation-status"
    };
    /// <summary>
    /// The patient is considered overdue for their next vaccination.
    /// </summary>
    public static readonly Coding Overdue = new Coding
    {
      Code = "overdue",
      Display = "Overdue",
      System = "http://terminology.hl7.org/CodeSystem/immunization-recommendation-status"
    };

    /// <summary>
    /// Literal for code: Complete
    /// </summary>
    public const string LiteralComplete = "complete";

    /// <summary>
    /// Literal for code: Contraindicated
    /// </summary>
    public const string LiteralContraindicated = "contraindicated";

    /// <summary>
    /// Literal for code: Due
    /// </summary>
    public const string LiteralDue = "due";

    /// <summary>
    /// Literal for code: Immune
    /// </summary>
    public const string LiteralImmune = "immune";

    /// <summary>
    /// Literal for code: Overdue
    /// </summary>
    public const string LiteralOverdue = "overdue";
  };
}
