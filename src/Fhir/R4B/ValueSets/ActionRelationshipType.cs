// <auto-generated />
// Built from: hl7.fhir.r4b.core version: 4.1.0
  // Option: "NAMESPACE" = "fhirCsR4"

using fhirCsR4.Models;

namespace fhirCsR4.ValueSets
{
  /// <summary>
  /// Defines the types of relationships between actions.
  /// </summary>
  public static class ActionRelationshipTypeCodes
  {
    /// <summary>
    /// The action must be performed after the related action.
    /// </summary>
    public static readonly Coding After = new Coding
    {
      Code = "after",
      Display = "After",
      System = "http://hl7.org/fhir/action-relationship-type"
    };
    /// <summary>
    /// The action must be performed after the end of the related action.
    /// </summary>
    public static readonly Coding AfterEnd = new Coding
    {
      Code = "after-end",
      Display = "After End",
      System = "http://hl7.org/fhir/action-relationship-type"
    };
    /// <summary>
    /// The action must be performed after the start of the related action.
    /// </summary>
    public static readonly Coding AfterStart = new Coding
    {
      Code = "after-start",
      Display = "After Start",
      System = "http://hl7.org/fhir/action-relationship-type"
    };
    /// <summary>
    /// The action must be performed before the related action.
    /// </summary>
    public static readonly Coding Before = new Coding
    {
      Code = "before",
      Display = "Before",
      System = "http://hl7.org/fhir/action-relationship-type"
    };
    /// <summary>
    /// The action must be performed before the end of the related action.
    /// </summary>
    public static readonly Coding BeforeEnd = new Coding
    {
      Code = "before-end",
      Display = "Before End",
      System = "http://hl7.org/fhir/action-relationship-type"
    };
    /// <summary>
    /// The action must be performed before the start of the related action.
    /// </summary>
    public static readonly Coding BeforeStart = new Coding
    {
      Code = "before-start",
      Display = "Before Start",
      System = "http://hl7.org/fhir/action-relationship-type"
    };
    /// <summary>
    /// The action must be performed concurrent with the related action.
    /// </summary>
    public static readonly Coding Concurrent = new Coding
    {
      Code = "concurrent",
      Display = "Concurrent",
      System = "http://hl7.org/fhir/action-relationship-type"
    };
    /// <summary>
    /// The action must be performed concurrent with the end of the related action.
    /// </summary>
    public static readonly Coding ConcurrentWithEnd = new Coding
    {
      Code = "concurrent-with-end",
      Display = "Concurrent With End",
      System = "http://hl7.org/fhir/action-relationship-type"
    };
    /// <summary>
    /// The action must be performed concurrent with the start of the related action.
    /// </summary>
    public static readonly Coding ConcurrentWithStart = new Coding
    {
      Code = "concurrent-with-start",
      Display = "Concurrent With Start",
      System = "http://hl7.org/fhir/action-relationship-type"
    };

    /// <summary>
    /// Literal for code: After
    /// </summary>
    public const string LiteralAfter = "after";

    /// <summary>
    /// Literal for code: AfterEnd
    /// </summary>
    public const string LiteralAfterEnd = "after-end";

    /// <summary>
    /// Literal for code: AfterStart
    /// </summary>
    public const string LiteralAfterStart = "after-start";

    /// <summary>
    /// Literal for code: Before
    /// </summary>
    public const string LiteralBefore = "before";

    /// <summary>
    /// Literal for code: BeforeEnd
    /// </summary>
    public const string LiteralBeforeEnd = "before-end";

    /// <summary>
    /// Literal for code: BeforeStart
    /// </summary>
    public const string LiteralBeforeStart = "before-start";

    /// <summary>
    /// Literal for code: Concurrent
    /// </summary>
    public const string LiteralConcurrent = "concurrent";

    /// <summary>
    /// Literal for code: ConcurrentWithEnd
    /// </summary>
    public const string LiteralConcurrentWithEnd = "concurrent-with-end";

    /// <summary>
    /// Literal for code: ConcurrentWithStart
    /// </summary>
    public const string LiteralConcurrentWithStart = "concurrent-with-start";
  };
}
