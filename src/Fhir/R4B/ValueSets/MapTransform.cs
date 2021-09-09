// <auto-generated />
// Built from: hl7.fhir.r4b.core version: 4.1.0
  // Option: "NAMESPACE" = "fhirCsR4"

using fhirCsR4.Models;

namespace fhirCsR4.ValueSets
{
  /// <summary>
  /// How data is copied/created.
  /// </summary>
  public static class MapTransformCodes
  {
    /// <summary>
    /// append(source...) - source is element or string.
    /// </summary>
    public static readonly Coding Append = new Coding
    {
      Code = "append",
      Display = "append",
      System = "http://hl7.org/fhir/map-transform"
    };
    /// <summary>
    /// Create a Coding. Parameters = (system. Code[, display]).
    /// </summary>
    public static readonly Coding C = new Coding
    {
      Code = "c",
      Display = "c",
      System = "http://hl7.org/fhir/map-transform"
    };
    /// <summary>
    /// cast(source, type?) - case source from one type to another. target type can be left as implicit if there is one and only one target type known.
    /// </summary>
    public static readonly Coding Cast = new Coding
    {
      Code = "cast",
      Display = "cast",
      System = "http://hl7.org/fhir/map-transform"
    };
    /// <summary>
    /// Create a CodeableConcept. Parameters = (text) or (system. Code[, display]).
    /// </summary>
    public static readonly Coding Cc = new Coding
    {
      Code = "cc",
      Display = "cc",
      System = "http://hl7.org/fhir/map-transform"
    };
    /// <summary>
    /// copy(source).
    /// </summary>
    public static readonly Coding Copy = new Coding
    {
      Code = "copy",
      Display = "copy",
      System = "http://hl7.org/fhir/map-transform"
    };
    /// <summary>
    /// Create a contact details. Parameters = (value) or (system, value). If no system is provided, the system should be inferred from the content of the value.
    /// </summary>
    public static readonly Coding Cp = new Coding
    {
      Code = "cp",
      Display = "cp",
      System = "http://hl7.org/fhir/map-transform"
    };
    /// <summary>
    /// create(type : string) - type is passed through to the application on the standard API, and must be known by it.
    /// </summary>
    public static readonly Coding Create = new Coding
    {
      Code = "create",
      Display = "create",
      System = "http://hl7.org/fhir/map-transform"
    };
    /// <summary>
    /// Perform a date operation. *Parameters to be documented*.
    /// </summary>
    public static readonly Coding DateOp = new Coding
    {
      Code = "dateOp",
      Display = "dateOp",
      System = "http://hl7.org/fhir/map-transform"
    };
    /// <summary>
    /// escape(source, fmt1, fmt2) - change source from one kind of escaping to another (plain, java, xml, json). note that this is for when the string itself is escaped.
    /// </summary>
    public static readonly Coding Escape = new Coding
    {
      Code = "escape",
      Display = "escape",
      System = "http://hl7.org/fhir/map-transform"
    };
    /// <summary>
    /// Execute the supplied FHIRPath expression and use the value returned by that.
    /// </summary>
    public static readonly Coding Evaluate = new Coding
    {
      Code = "evaluate",
      Display = "evaluate",
      System = "http://hl7.org/fhir/map-transform"
    };
    /// <summary>
    /// Create an identifier. Parameters = (system, value[, type]) where type is a code from the identifier type value set.
    /// </summary>
    public static readonly Coding Id = new Coding
    {
      Code = "id",
      Display = "id",
      System = "http://hl7.org/fhir/map-transform"
    };
    /// <summary>
    /// Return the appropriate string to put in a reference that refers to the resource provided as a parameter.
    /// </summary>
    public static readonly Coding Pointer = new Coding
    {
      Code = "pointer",
      Display = "pointer",
      System = "http://hl7.org/fhir/map-transform"
    };
    /// <summary>
    /// Create a quantity. Parameters = (text) or (value, unit, [system, code]) where text is the natural representation e.g. [comparator]value[space]unit.
    /// </summary>
    public static readonly Coding Qty = new Coding
    {
      Code = "qty",
      Display = "qty",
      System = "http://hl7.org/fhir/map-transform"
    };
    /// <summary>
    /// reference(source : object) - return a string that references the provided tree properly.
    /// </summary>
    public static readonly Coding Reference = new Coding
    {
      Code = "reference",
      Display = "reference",
      System = "http://hl7.org/fhir/map-transform"
    };
    /// <summary>
    /// translate(source, uri_of_map) - use the translate operation.
    /// </summary>
    public static readonly Coding Translate = new Coding
    {
      Code = "translate",
      Display = "translate",
      System = "http://hl7.org/fhir/map-transform"
    };
    /// <summary>
    /// truncate(source, length) - source must be stringy type.
    /// </summary>
    public static readonly Coding Truncate = new Coding
    {
      Code = "truncate",
      Display = "truncate",
      System = "http://hl7.org/fhir/map-transform"
    };
    /// <summary>
    /// Generate a random UUID (in lowercase). No Parameters.
    /// </summary>
    public static readonly Coding Uuid = new Coding
    {
      Code = "uuid",
      Display = "uuid",
      System = "http://hl7.org/fhir/map-transform"
    };

    /// <summary>
    /// Literal for code: Append
    /// </summary>
    public const string LiteralAppend = "append";

    /// <summary>
    /// Literal for code: C
    /// </summary>
    public const string LiteralC = "c";

    /// <summary>
    /// Literal for code: Cast
    /// </summary>
    public const string LiteralCast = "cast";

    /// <summary>
    /// Literal for code: Cc
    /// </summary>
    public const string LiteralCc = "cc";

    /// <summary>
    /// Literal for code: Copy
    /// </summary>
    public const string LiteralCopy = "copy";

    /// <summary>
    /// Literal for code: Cp
    /// </summary>
    public const string LiteralCp = "cp";

    /// <summary>
    /// Literal for code: Create
    /// </summary>
    public const string LiteralCreate = "create";

    /// <summary>
    /// Literal for code: DateOp
    /// </summary>
    public const string LiteralDateOp = "dateOp";

    /// <summary>
    /// Literal for code: Escape
    /// </summary>
    public const string LiteralEscape = "escape";

    /// <summary>
    /// Literal for code: Evaluate
    /// </summary>
    public const string LiteralEvaluate = "evaluate";

    /// <summary>
    /// Literal for code: Id
    /// </summary>
    public const string LiteralId = "id";

    /// <summary>
    /// Literal for code: Pointer
    /// </summary>
    public const string LiteralPointer = "pointer";

    /// <summary>
    /// Literal for code: Qty
    /// </summary>
    public const string LiteralQty = "qty";

    /// <summary>
    /// Literal for code: Reference
    /// </summary>
    public const string LiteralReference = "reference";

    /// <summary>
    /// Literal for code: Translate
    /// </summary>
    public const string LiteralTranslate = "translate";

    /// <summary>
    /// Literal for code: Truncate
    /// </summary>
    public const string LiteralTruncate = "truncate";

    /// <summary>
    /// Literal for code: Uuid
    /// </summary>
    public const string LiteralUuid = "uuid";
  };
}
