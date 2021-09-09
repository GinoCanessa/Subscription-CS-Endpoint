// <auto-generated />
// Built from: hl7.fhir.r4b.core version: 4.1.0
  // Option: "NAMESPACE" = "fhirCsR4"

using fhirCsR4.Models;

namespace fhirCsR4.ValueSets
{
  /// <summary>
  /// The type of measure (includes codes from 2.16.840.1.113883.1.11.20368).
  /// </summary>
  public static class MeasureTypeCodes
  {
    /// <summary>
    /// A measure that combines multiple component measures in to a single quality measure.
    /// </summary>
    public static readonly Coding Composite = new Coding
    {
      Code = "composite",
      Display = "Composite",
      System = "http://terminology.hl7.org/CodeSystem/measure-type"
    };
    /// <summary>
    /// A measure that indicates the result of the performance (or non-performance) of a function or process.
    /// </summary>
    public static readonly Coding Outcome = new Coding
    {
      Code = "outcome",
      Display = "Outcome",
      System = "http://terminology.hl7.org/CodeSystem/measure-type"
    };
    /// <summary>
    /// A measure that focuses on patient-reported information such as patient engagement or patient experience measures.
    /// </summary>
    public static readonly Coding PatientReportedOutcome = new Coding
    {
      Code = "patient-reported-outcome",
      Display = "Patient Reported Outcome",
      System = "http://terminology.hl7.org/CodeSystem/measure-type"
    };
    /// <summary>
    /// A measure which focuses on a process which leads to a certain outcome, meaning that a scientific basis exists for believing that the process, when executed well, will increase the probability of achieving a desired outcome.
    /// </summary>
    public static readonly Coding Process = new Coding
    {
      Code = "process",
      Display = "Process",
      System = "http://terminology.hl7.org/CodeSystem/measure-type"
    };
    /// <summary>
    /// A measure that focuses on a health care provider's capacity, systems, and processes to provide high-quality care.
    /// </summary>
    public static readonly Coding Structure = new Coding
    {
      Code = "structure",
      Display = "Structure",
      System = "http://terminology.hl7.org/CodeSystem/measure-type"
    };

    /// <summary>
    /// Literal for code: Composite
    /// </summary>
    public const string LiteralComposite = "composite";

    /// <summary>
    /// Literal for code: Outcome
    /// </summary>
    public const string LiteralOutcome = "outcome";

    /// <summary>
    /// Literal for code: PatientReportedOutcome
    /// </summary>
    public const string LiteralPatientReportedOutcome = "patient-reported-outcome";

    /// <summary>
    /// Literal for code: Process
    /// </summary>
    public const string LiteralProcess = "process";

    /// <summary>
    /// Literal for code: Structure
    /// </summary>
    public const string LiteralStructure = "structure";
  };
}
