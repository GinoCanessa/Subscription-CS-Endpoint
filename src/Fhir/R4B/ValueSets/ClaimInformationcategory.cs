// <auto-generated />
// Built from: hl7.fhir.r4b.core version: 4.1.0
  // Option: "NAMESPACE" = "fhirCsR4"

using fhirCsR4.Models;

namespace fhirCsR4.ValueSets
{
  /// <summary>
  /// This value set includes sample Information Category codes.
  /// </summary>
  public static class ClaimInformationcategoryCodes
  {
    /// <summary>
    /// Materials attached such as images, documents and resources.
    /// </summary>
    public static readonly Coding Attachment = new Coding
    {
      Code = "attachment",
      Display = "Attachment",
      System = "http://terminology.hl7.org/CodeSystem/claiminformationcategory"
    };
    /// <summary>
    /// Discharge status and discharge to locations.
    /// </summary>
    public static readonly Coding Discharge = new Coding
    {
      Code = "discharge",
      Display = "Discharge",
      System = "http://terminology.hl7.org/CodeSystem/claiminformationcategory"
    };
    /// <summary>
    /// An indication that the patient was unable to work, the period if known otherwise a Yes/No (boolean).
    /// </summary>
    public static readonly Coding EmploymentImpacted = new Coding
    {
      Code = "employmentimpacted",
      Display = "EmploymentImpacted",
      System = "http://terminology.hl7.org/CodeSystem/claiminformationcategory"
    };
    /// <summary>
    /// Insurance policy exceptions.
    /// </summary>
    public static readonly Coding Exception = new Coding
    {
      Code = "exception",
      Display = "Exception",
      System = "http://terminology.hl7.org/CodeSystem/claiminformationcategory"
    };
    /// <summary>
    /// The external cause of an illness or injury.
    /// </summary>
    public static readonly Coding ExternalCaause = new Coding
    {
      Code = "externalcause",
      Display = "External Caause",
      System = "http://terminology.hl7.org/CodeSystem/claiminformationcategory"
    };
    /// <summary>
    /// An indication that the patient was hospitalized, the period if known otherwise a Yes/No (boolean).
    /// </summary>
    public static readonly Coding Hospitalized = new Coding
    {
      Code = "hospitalized",
      Display = "Hospitalized",
      System = "http://terminology.hl7.org/CodeSystem/claiminformationcategory"
    };
    /// <summary>
    /// Codes conveying additional situation and condition information.
    /// </summary>
    public static readonly Coding Information = new Coding
    {
      Code = "info",
      Display = "Information",
      System = "http://terminology.hl7.org/CodeSystem/claiminformationcategory"
    };
    /// <summary>
    /// Materials being forwarded, e.g. Models, molds, images, documents.
    /// </summary>
    public static readonly Coding MaterialsForwarded = new Coding
    {
      Code = "material",
      Display = "Materials Forwarded",
      System = "http://terminology.hl7.org/CodeSystem/claiminformationcategory"
    };
    /// <summary>
    /// Teeth which are missing for any reason, for example: prior extraction, never developed.
    /// </summary>
    public static readonly Coding MissingTooth = new Coding
    {
      Code = "missingtooth",
      Display = "Missing Tooth",
      System = "http://terminology.hl7.org/CodeSystem/claiminformationcategory"
    };
    /// <summary>
    /// Period, start or end dates of aspects of the Condition.
    /// </summary>
    public static readonly Coding Onset = new Coding
    {
      Code = "onset",
      Display = "Onset",
      System = "http://terminology.hl7.org/CodeSystem/claiminformationcategory"
    };
    /// <summary>
    /// Other information identified by the type.system.
    /// </summary>
    public static readonly Coding Other = new Coding
    {
      Code = "other",
      Display = "Other",
      System = "http://terminology.hl7.org/CodeSystem/claiminformationcategory"
    };
    /// <summary>
    /// The reason for the patient visit.
    /// </summary>
    public static readonly Coding PatientReasonForVisit = new Coding
    {
      Code = "patientreasonforvisit",
      Display = "Patient Reason for Visit",
      System = "http://terminology.hl7.org/CodeSystem/claiminformationcategory"
    };
    /// <summary>
    /// The type of prosthesis and date of supply if a previously supplied prosthesis.
    /// </summary>
    public static readonly Coding Prosthesis = new Coding
    {
      Code = "prosthesis",
      Display = "Prosthesis",
      System = "http://terminology.hl7.org/CodeSystem/claiminformationcategory"
    };
    /// <summary>
    /// Nature and date of the related event e.g. Last exam, service, X-ray etc.
    /// </summary>
    public static readonly Coding RelatedServices = new Coding
    {
      Code = "related",
      Display = "Related Services",
      System = "http://terminology.hl7.org/CodeSystem/claiminformationcategory"
    };

    /// <summary>
    /// Literal for code: Attachment
    /// </summary>
    public const string LiteralAttachment = "attachment";

    /// <summary>
    /// Literal for code: Discharge
    /// </summary>
    public const string LiteralDischarge = "discharge";

    /// <summary>
    /// Literal for code: EmploymentImpacted
    /// </summary>
    public const string LiteralEmploymentImpacted = "employmentimpacted";

    /// <summary>
    /// Literal for code: Exception
    /// </summary>
    public const string LiteralException = "exception";

    /// <summary>
    /// Literal for code: ExternalCaause
    /// </summary>
    public const string LiteralExternalCaause = "externalcause";

    /// <summary>
    /// Literal for code: Hospitalized
    /// </summary>
    public const string LiteralHospitalized = "hospitalized";

    /// <summary>
    /// Literal for code: Information
    /// </summary>
    public const string LiteralInformation = "info";

    /// <summary>
    /// Literal for code: MaterialsForwarded
    /// </summary>
    public const string LiteralMaterialsForwarded = "material";

    /// <summary>
    /// Literal for code: MissingTooth
    /// </summary>
    public const string LiteralMissingTooth = "missingtooth";

    /// <summary>
    /// Literal for code: Onset
    /// </summary>
    public const string LiteralOnset = "onset";

    /// <summary>
    /// Literal for code: Other
    /// </summary>
    public const string LiteralOther = "other";

    /// <summary>
    /// Literal for code: PatientReasonForVisit
    /// </summary>
    public const string LiteralPatientReasonForVisit = "patientreasonforvisit";

    /// <summary>
    /// Literal for code: Prosthesis
    /// </summary>
    public const string LiteralProsthesis = "prosthesis";

    /// <summary>
    /// Literal for code: RelatedServices
    /// </summary>
    public const string LiteralRelatedServices = "related";
  };
}
