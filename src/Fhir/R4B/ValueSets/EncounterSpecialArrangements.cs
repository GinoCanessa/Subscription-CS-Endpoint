// <auto-generated />
// Built from: hl7.fhir.r4b.core version: 4.1.0
  // Option: "NAMESPACE" = "fhirCsR4"

using fhirCsR4.Models;

namespace fhirCsR4.ValueSets
{
  /// <summary>
  /// This value set defines a set of codes that can be used to indicate the kinds of special arrangements in place for a patients visit.
  /// </summary>
  public static class EncounterSpecialArrangementsCodes
  {
    /// <summary>
    /// An additional bed made available for a person accompanying the patient, for example a parent accompanying a child.
    /// </summary>
    public static readonly Coding AdditionalBedding = new Coding
    {
      Code = "add-bed",
      Display = "Additional bedding",
      System = "http://terminology.hl7.org/CodeSystem/encounter-special-arrangements"
    };
    /// <summary>
    /// A person who accompanies a patient to provide assistive services necessary for the patient's care during the encounter.
    /// </summary>
    public static readonly Coding Attendant = new Coding
    {
      Code = "att",
      Display = "Attendant",
      System = "http://terminology.hl7.org/CodeSystem/encounter-special-arrangements"
    };
    /// <summary>
    /// The patient has a guide dog and the location used for the encounter should be able to support the presence of the service animal.
    /// </summary>
    public static readonly Coding GuideDog = new Coding
    {
      Code = "dog",
      Display = "Guide dog",
      System = "http://terminology.hl7.org/CodeSystem/encounter-special-arrangements"
    };
    /// <summary>
    /// The patient is not fluent in the local language and requires an interpreter to be available. Refer to the Patient.Language property for the type of interpreter required.
    /// </summary>
    public static readonly Coding Interpreter = new Coding
    {
      Code = "int",
      Display = "Interpreter",
      System = "http://terminology.hl7.org/CodeSystem/encounter-special-arrangements"
    };
    /// <summary>
    /// The patient requires a wheelchair to be made available for the encounter.
    /// </summary>
    public static readonly Coding Wheelchair = new Coding
    {
      Code = "wheel",
      Display = "Wheelchair",
      System = "http://terminology.hl7.org/CodeSystem/encounter-special-arrangements"
    };

    /// <summary>
    /// Literal for code: AdditionalBedding
    /// </summary>
    public const string LiteralAdditionalBedding = "add-bed";

    /// <summary>
    /// Literal for code: Attendant
    /// </summary>
    public const string LiteralAttendant = "att";

    /// <summary>
    /// Literal for code: GuideDog
    /// </summary>
    public const string LiteralGuideDog = "dog";

    /// <summary>
    /// Literal for code: Interpreter
    /// </summary>
    public const string LiteralInterpreter = "int";

    /// <summary>
    /// Literal for code: Wheelchair
    /// </summary>
    public const string LiteralWheelchair = "wheel";
  };
}
