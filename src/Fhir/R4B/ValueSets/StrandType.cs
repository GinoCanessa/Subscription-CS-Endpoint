// <auto-generated />
// Built from: hl7.fhir.r4b.core version: 4.1.0
  // Option: "NAMESPACE" = "fhirCsR4"

using fhirCsR4.Models;

namespace fhirCsR4.ValueSets
{
  /// <summary>
  /// Type for strand.
  /// </summary>
  public static class StrandTypeCodes
  {
    /// <summary>
    /// Crick strand of reference sequence.
    /// </summary>
    public static readonly Coding CrickStrandOfReferenceSeq = new Coding
    {
      Code = "crick",
      Display = "Crick strand of referenceSeq",
      System = "http://hl7.org/fhir/strand-type"
    };
    /// <summary>
    /// Watson strand of reference sequence.
    /// </summary>
    public static readonly Coding WatsonStrandOfReferenceSeq = new Coding
    {
      Code = "watson",
      Display = "Watson strand of referenceSeq",
      System = "http://hl7.org/fhir/strand-type"
    };

    /// <summary>
    /// Literal for code: CrickStrandOfReferenceSeq
    /// </summary>
    public const string LiteralCrickStrandOfReferenceSeq = "crick";

    /// <summary>
    /// Literal for code: WatsonStrandOfReferenceSeq
    /// </summary>
    public const string LiteralWatsonStrandOfReferenceSeq = "watson";
  };
}
