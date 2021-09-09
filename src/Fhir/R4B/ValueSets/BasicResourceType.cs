// <auto-generated />
// Built from: hl7.fhir.r4b.core version: 4.1.0
  // Option: "NAMESPACE" = "fhirCsR4"

using fhirCsR4.Models;

namespace fhirCsR4.ValueSets
{
  /// <summary>
  /// This value set defines codes for resources not yet supported by (or which will never be supported by) FHIR.  Many of the codes listed here will eventually be turned into official resources.  However, there is no guarantee that any particular resource will be created nor that the scope will be exactly as defined by the codes presented here.  Codes in this set will be deprecated if/when formal resources are defined that encompass these concepts.
  /// </summary>
  public static class BasicResourceTypeCodes
  {
    /// <summary>
    /// A financial instrument used to track costs, charges or other amounts.
    /// </summary>
    public static readonly Coding Account = new Coding
    {
      Code = "account",
      Display = "Account",
      System = "http://terminology.hl7.org/CodeSystem/basic-resource-type"
    };
    /// <summary>
    /// The determination of what will be paid against a particular invoice based on coverage, plan rules, etc.
    /// </summary>
    public static readonly Coding InvoiceAdjudication = new Coding
    {
      Code = "adjudicat",
      Display = "Invoice Adjudication",
      System = "http://terminology.hl7.org/CodeSystem/basic-resource-type"
    };
    /// <summary>
    /// An occurrence of a non-care-related event in the healthcare domain, such as approvals, reviews, etc.
    /// </summary>
    public static readonly Coding AdministrativeActivity = new Coding
    {
      Code = "adminact",
      Display = "Administrative Activity",
      System = "http://terminology.hl7.org/CodeSystem/basic-resource-type"
    };
    /// <summary>
    /// An undesired reaction caused by exposure to some agent (e.g. a medication, immunization, food, or environmental agent).
    /// </summary>
    public static readonly Coding AdverseEvent = new Coding
    {
      Code = "advevent",
      Display = "Adverse Event",
      System = "http://terminology.hl7.org/CodeSystem/basic-resource-type"
    };
    /// <summary>
    /// A request that a time be scheduled for a type of service for a specified patient, potentially subject to other constraints
    /// </summary>
    public static readonly Coding AppointmentRequest = new Coding
    {
      Code = "aptmtreq",
      Display = "Appointment Request",
      System = "http://terminology.hl7.org/CodeSystem/basic-resource-type"
    };
    /// <summary>
    /// An assertion of permission for an activity or set of activities to occur, possibly subject to particular limitations; e.g. surgical consent, information disclosure consent, etc.
    /// </summary>
    public static readonly Coding Consent = new Coding
    {
      Code = "consent",
      Display = "Consent",
      System = "http://terminology.hl7.org/CodeSystem/basic-resource-type"
    };
    /// <summary>
    /// The specification of a set of food and/or other nutritional material to be delivered to a patient.
    /// </summary>
    public static readonly Coding Diet = new Coding
    {
      Code = "diet",
      Display = "Diet",
      System = "http://terminology.hl7.org/CodeSystem/basic-resource-type"
    };
    /// <summary>
    /// Record of a situation where a subject was exposed to a substance.  Usually of interest to public health.
    /// </summary>
    public static readonly Coding Exposure = new Coding
    {
      Code = "exposure",
      Display = "Exposure",
      System = "http://terminology.hl7.org/CodeSystem/basic-resource-type"
    };
    /// <summary>
    /// A formalized inquiry into the circumstances surrounding a particular unplanned event or potential event for the purposes of identifying possible causes and contributing factors for the event
    /// </summary>
    public static readonly Coding Investigation = new Coding
    {
      Code = "investigation",
      Display = "Investigation",
      System = "http://terminology.hl7.org/CodeSystem/basic-resource-type"
    };
    /// <summary>
    /// A request for payment for goods and/or services.  Includes the idea of a healthcare insurance claim.
    /// </summary>
    public static readonly Coding Invoice = new Coding
    {
      Code = "invoice",
      Display = "Invoice",
      System = "http://terminology.hl7.org/CodeSystem/basic-resource-type"
    };
    /// <summary>
    /// An adjudication of what would be paid under an insurance plan for a hypothetical claim for goods or services
    /// </summary>
    public static readonly Coding Predetermination = new Coding
    {
      Code = "predetermine",
      Display = "Predetermination",
      System = "http://terminology.hl7.org/CodeSystem/basic-resource-type"
    };
    /// <summary>
    /// A request for a pre-determination of the cost that would be paid under an insurance plan for a hypothetical claim for goods or services
    /// </summary>
    public static readonly Coding PreDeterminationRequest = new Coding
    {
      Code = "predetreq",
      Display = "Pre-determination Request",
      System = "http://terminology.hl7.org/CodeSystem/basic-resource-type"
    };
    /// <summary>
    /// A set of (possibly conditional) steps to be taken to achieve some aim.  Includes study protocols, treatment protocols, emergency protocols, etc.
    /// </summary>
    public static readonly Coding Protocol = new Coding
    {
      Code = "protocol",
      Display = "Protocol",
      System = "http://terminology.hl7.org/CodeSystem/basic-resource-type"
    };
    /// <summary>
    /// A request that care of a particular type be provided to a patient.  Could involve the transfer of care, a consult, etc.
    /// </summary>
    public static readonly Coding Referral = new Coding
    {
      Code = "referral",
      Display = "Referral",
      System = "http://terminology.hl7.org/CodeSystem/basic-resource-type"
    };
    /// <summary>
    /// An investigation to determine information about a particular therapy or product
    /// </summary>
    public static readonly Coding Study = new Coding
    {
      Code = "study",
      Display = "Study",
      System = "http://terminology.hl7.org/CodeSystem/basic-resource-type"
    };
    /// <summary>
    /// The transition of a patient or set of material from one location to another
    /// </summary>
    public static readonly Coding Transfer = new Coding
    {
      Code = "transfer",
      Display = "Transfer",
      System = "http://terminology.hl7.org/CodeSystem/basic-resource-type"
    };

    /// <summary>
    /// Literal for code: Account
    /// </summary>
    public const string LiteralAccount = "account";

    /// <summary>
    /// Literal for code: InvoiceAdjudication
    /// </summary>
    public const string LiteralInvoiceAdjudication = "adjudicat";

    /// <summary>
    /// Literal for code: AdministrativeActivity
    /// </summary>
    public const string LiteralAdministrativeActivity = "adminact";

    /// <summary>
    /// Literal for code: AdverseEvent
    /// </summary>
    public const string LiteralAdverseEvent = "advevent";

    /// <summary>
    /// Literal for code: AppointmentRequest
    /// </summary>
    public const string LiteralAppointmentRequest = "aptmtreq";

    /// <summary>
    /// Literal for code: Consent
    /// </summary>
    public const string LiteralConsent = "consent";

    /// <summary>
    /// Literal for code: Diet
    /// </summary>
    public const string LiteralDiet = "diet";

    /// <summary>
    /// Literal for code: Exposure
    /// </summary>
    public const string LiteralExposure = "exposure";

    /// <summary>
    /// Literal for code: Investigation
    /// </summary>
    public const string LiteralInvestigation = "investigation";

    /// <summary>
    /// Literal for code: Invoice
    /// </summary>
    public const string LiteralInvoice = "invoice";

    /// <summary>
    /// Literal for code: Predetermination
    /// </summary>
    public const string LiteralPredetermination = "predetermine";

    /// <summary>
    /// Literal for code: PreDeterminationRequest
    /// </summary>
    public const string LiteralPreDeterminationRequest = "predetreq";

    /// <summary>
    /// Literal for code: Protocol
    /// </summary>
    public const string LiteralProtocol = "protocol";

    /// <summary>
    /// Literal for code: Referral
    /// </summary>
    public const string LiteralReferral = "referral";

    /// <summary>
    /// Literal for code: Study
    /// </summary>
    public const string LiteralStudy = "study";

    /// <summary>
    /// Literal for code: Transfer
    /// </summary>
    public const string LiteralTransfer = "transfer";
  };
}
