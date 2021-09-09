// <auto-generated />
// Built from: hl7.fhir.r4b.core version: 4.1.0
  // Option: "NAMESPACE" = "fhirCsR4"

using fhirCsR4.Models;

namespace fhirCsR4.ValueSets
{
  /// <summary>
  /// The assessment of quality, confidence, or certainty.
  /// </summary>
  public static class CertaintyRatingCodes
  {
    /// <summary>
    /// possible reason for increasing quality rating was checked and found to be absent.
    /// </summary>
    public static readonly Coding Absent = new Coding
    {
      Code = "absent",
      Display = "absent",
      System = "http://terminology.hl7.org/CodeSystem/certainty-rating"
    };
    /// <summary>
    /// reduce quality rating by 1.
    /// </summary>
    public static readonly Coding ReduceRating1 = new Coding
    {
      Code = "downcode1",
      Display = "reduce rating: -1",
      System = "http://terminology.hl7.org/CodeSystem/certainty-rating"
    };
    /// <summary>
    /// reduce quality rating by 2.
    /// </summary>
    public static readonly Coding ReduceRating2 = new Coding
    {
      Code = "downcode2",
      Display = "reduce rating: -2",
      System = "http://terminology.hl7.org/CodeSystem/certainty-rating"
    };
    /// <summary>
    /// reduce quality rating by 3.
    /// </summary>
    public static readonly Coding ReduceRating3 = new Coding
    {
      Code = "downcode3",
      Display = "reduce rating: -3",
      System = "http://terminology.hl7.org/CodeSystem/certainty-rating"
    };
    /// <summary>
    /// extremely serious concern.
    /// </summary>
    public static readonly Coding ExtremelySeriousConcern = new Coding
    {
      Code = "extremely-serious-concern",
      Display = "extremely serious concern",
      System = "http://terminology.hl7.org/CodeSystem/certainty-rating"
    };
    /// <summary>
    /// High quality evidence.
    /// </summary>
    public static readonly Coding HighQuality = new Coding
    {
      Code = "high",
      Display = "High quality",
      System = "http://terminology.hl7.org/CodeSystem/certainty-rating"
    };
    /// <summary>
    /// Low quality evidence.
    /// </summary>
    public static readonly Coding LowQuality = new Coding
    {
      Code = "low",
      Display = "Low quality",
      System = "http://terminology.hl7.org/CodeSystem/certainty-rating"
    };
    /// <summary>
    /// Moderate quality evidence.
    /// </summary>
    public static readonly Coding ModerateQuality = new Coding
    {
      Code = "moderate",
      Display = "Moderate quality",
      System = "http://terminology.hl7.org/CodeSystem/certainty-rating"
    };
    /// <summary>
    /// no change to quality rating.
    /// </summary>
    public static readonly Coding NoChangeToRating = new Coding
    {
      Code = "no-change",
      Display = "no change to rating",
      System = "http://terminology.hl7.org/CodeSystem/certainty-rating"
    };
    /// <summary>
    /// no serious concern.
    /// </summary>
    public static readonly Coding NoSeriousConcern = new Coding
    {
      Code = "no-concern",
      Display = "no serious concern",
      System = "http://terminology.hl7.org/CodeSystem/certainty-rating"
    };
    /// <summary>
    /// possible reason for increasing quality rating was checked and found to be present.
    /// </summary>
    public static readonly Coding Present = new Coding
    {
      Code = "present",
      Display = "present",
      System = "http://terminology.hl7.org/CodeSystem/certainty-rating"
    };
    /// <summary>
    /// serious concern.
    /// </summary>
    public static readonly Coding SeriousConcern = new Coding
    {
      Code = "serious-concern",
      Display = "serious concern",
      System = "http://terminology.hl7.org/CodeSystem/certainty-rating"
    };
    /// <summary>
    /// increase quality rating by 1.
    /// </summary>
    public static readonly Coding IncreaseRatingPlus1 = new Coding
    {
      Code = "upcode1",
      Display = "increase rating: +1",
      System = "http://terminology.hl7.org/CodeSystem/certainty-rating"
    };
    /// <summary>
    /// increase quality rating by 2.
    /// </summary>
    public static readonly Coding IncreaseRatingPlus2 = new Coding
    {
      Code = "upcode2",
      Display = "increase rating: +2",
      System = "http://terminology.hl7.org/CodeSystem/certainty-rating"
    };
    /// <summary>
    /// Very low quality evidence.
    /// </summary>
    public static readonly Coding VeryLowQuality = new Coding
    {
      Code = "very-low",
      Display = "Very low quality",
      System = "http://terminology.hl7.org/CodeSystem/certainty-rating"
    };
    /// <summary>
    /// very serious concern.
    /// </summary>
    public static readonly Coding VerySeriousConcern = new Coding
    {
      Code = "very-serious-concern",
      Display = "very serious concern",
      System = "http://terminology.hl7.org/CodeSystem/certainty-rating"
    };

    /// <summary>
    /// Literal for code: Absent
    /// </summary>
    public const string LiteralAbsent = "absent";

    /// <summary>
    /// Literal for code: ReduceRating1
    /// </summary>
    public const string LiteralReduceRating1 = "downcode1";

    /// <summary>
    /// Literal for code: ReduceRating2
    /// </summary>
    public const string LiteralReduceRating2 = "downcode2";

    /// <summary>
    /// Literal for code: ReduceRating3
    /// </summary>
    public const string LiteralReduceRating3 = "downcode3";

    /// <summary>
    /// Literal for code: ExtremelySeriousConcern
    /// </summary>
    public const string LiteralExtremelySeriousConcern = "extremely-serious-concern";

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
    /// Literal for code: NoChangeToRating
    /// </summary>
    public const string LiteralNoChangeToRating = "no-change";

    /// <summary>
    /// Literal for code: NoSeriousConcern
    /// </summary>
    public const string LiteralNoSeriousConcern = "no-concern";

    /// <summary>
    /// Literal for code: Present
    /// </summary>
    public const string LiteralPresent = "present";

    /// <summary>
    /// Literal for code: SeriousConcern
    /// </summary>
    public const string LiteralSeriousConcern = "serious-concern";

    /// <summary>
    /// Literal for code: IncreaseRatingPlus1
    /// </summary>
    public const string LiteralIncreaseRatingPlus1 = "upcode1";

    /// <summary>
    /// Literal for code: IncreaseRatingPlus2
    /// </summary>
    public const string LiteralIncreaseRatingPlus2 = "upcode2";

    /// <summary>
    /// Literal for code: VeryLowQuality
    /// </summary>
    public const string LiteralVeryLowQuality = "very-low";

    /// <summary>
    /// Literal for code: VerySeriousConcern
    /// </summary>
    public const string LiteralVerySeriousConcern = "very-serious-concern";
  };
}
