// <auto-generated />
// Built from: hl7.fhir.r4b.core version: 4.1.0
  // Option: "NAMESPACE" = "fhirCsR4"

using fhirCsR4.Models;

namespace fhirCsR4.ValueSets
{
  /// <summary>
  /// The media type of the expression language.
  /// </summary>
  public static class ExpressionLanguageCodes
  {
    /// <summary>
    /// FHIR's RESTful query syntax - typically independent of base URL.
    /// </summary>
    public static readonly Coding FHIRQuery = new Coding
    {
      Code = "application/x-fhir-query",
      Display = "FHIR Query",
      System = "http://hl7.org/fhir/expression-language"
    };
    /// <summary>
    /// Clinical Quality Language.
    /// </summary>
    public static readonly Coding CQL = new Coding
    {
      Code = "text/cql",
      Display = "CQL",
      System = "http://hl7.org/fhir/expression-language"
    };
    /// <summary>
    /// FHIRPath.
    /// </summary>
    public static readonly Coding FHIRPath = new Coding
    {
      Code = "text/fhirpath",
      Display = "FHIRPath",
      System = "http://hl7.org/fhir/expression-language"
    };

    /// <summary>
    /// Literal for code: FHIRQuery
    /// </summary>
    public const string LiteralFHIRQuery = "application/x-fhir-query";

    /// <summary>
    /// Literal for code: CQL
    /// </summary>
    public const string LiteralCQL = "text/cql";

    /// <summary>
    /// Literal for code: FHIRPath
    /// </summary>
    public const string LiteralFHIRPath = "text/fhirpath";
  };
}
