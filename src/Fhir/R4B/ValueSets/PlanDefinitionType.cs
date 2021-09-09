// <auto-generated />
// Built from: hl7.fhir.r4b.core version: 4.1.0
  // Option: "NAMESPACE" = "fhirCsR4"

using fhirCsR4.Models;

namespace fhirCsR4.ValueSets
{
  /// <summary>
  /// The type of PlanDefinition.
  /// </summary>
  public static class PlanDefinitionTypeCodes
  {
    /// <summary>
    /// Defines a desired/typical sequence of clinical activities including preconditions, triggers and temporal relationships.
    /// </summary>
    public static readonly Coding ClinicalProtocol = new Coding
    {
      Code = "clinical-protocol",
      Display = "Clinical Protocol",
      System = "http://terminology.hl7.org/CodeSystem/plan-definition-type"
    };
    /// <summary>
    /// A decision support rule of the form [on Event] if Condition then Action. It is intended to be a shareable, computable definition of actions that should be taken whenever some condition is met in response to a particular event or events.
    /// </summary>
    public static readonly Coding ECARule = new Coding
    {
      Code = "eca-rule",
      Display = "ECA Rule",
      System = "http://terminology.hl7.org/CodeSystem/plan-definition-type"
    };
    /// <summary>
    /// A pre-defined and approved group of orders related to a particular clinical condition (e.g. hypertension treatment and monitoring) or stage of care (e.g. hospital admission to Coronary Care Unit). An order set is used as a checklist for the clinician when managing a patient with a specific condition. It is a structured collection of orders relevant to that condition and presented to the clinician in a computerized provider order entry (CPOE) system.
    /// </summary>
    public static readonly Coding OrderSet = new Coding
    {
      Code = "order-set",
      Display = "Order Set",
      System = "http://terminology.hl7.org/CodeSystem/plan-definition-type"
    };
    /// <summary>
    /// Defines the steps for a group of one or more systems in an event flow process along with the step constraints, sequence, pre-conditions and decision points to complete a particular objective.
    /// </summary>
    public static readonly Coding WorkflowDefinition = new Coding
    {
      Code = "workflow-definition",
      Display = "Workflow Definition",
      System = "http://terminology.hl7.org/CodeSystem/plan-definition-type"
    };

    /// <summary>
    /// Literal for code: ClinicalProtocol
    /// </summary>
    public const string LiteralClinicalProtocol = "clinical-protocol";

    /// <summary>
    /// Literal for code: ECARule
    /// </summary>
    public const string LiteralECARule = "eca-rule";

    /// <summary>
    /// Literal for code: OrderSet
    /// </summary>
    public const string LiteralOrderSet = "order-set";

    /// <summary>
    /// Literal for code: WorkflowDefinition
    /// </summary>
    public const string LiteralWorkflowDefinition = "workflow-definition";
  };
}
