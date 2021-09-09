// <auto-generated />
// Built from: hl7.fhir.r4b.core version: 4.1.0
  // Option: "NAMESPACE" = "fhirCsR4"

using fhirCsR4.Models;

namespace fhirCsR4.ValueSets
{
  /// <summary>
  /// Value Set of codes that specify additional clinical information about the patient or specimen to report the supporting and/or suspected diagnosis and clinical findings on requests for interpreted diagnostic studies.
  /// </summary>
  public static class V20916Codes
  {
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding PatientWasFastingPriorToTheProcedure = new Coding
    {
      Code = "F",
      Display = "Patient was fasting prior to the procedure.",
      System = "http://terminology.hl7.org/CodeSystem/v2-0916"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding FastingNotAskedOfThePatientAtTimeOfProcedure = new Coding
    {
      Code = "FNA",
      Display = "Fasting not asked of the patient at time of procedure.",
      System = "http://terminology.hl7.org/CodeSystem/v2-0916"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding ThePatientIndicatedTheyDidNotFastPriorToTheProcedure = new Coding
    {
      Code = "NF",
      Display = "The patient indicated they did not fast prior to the procedure.",
      System = "http://terminology.hl7.org/CodeSystem/v2-0916"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding NotGivenPatientWasNotAskedAtTheTimeOfTheProcedure = new Coding
    {
      Code = "NG",
      Display = "Not Given - Patient was not asked at the time of the procedure.",
      System = "http://terminology.hl7.org/CodeSystem/v2-0916"
    };

    /// <summary>
    /// Literal for code: PatientWasFastingPriorToTheProcedure
    /// </summary>
    public const string LiteralPatientWasFastingPriorToTheProcedure = "F";

    /// <summary>
    /// Literal for code: FastingNotAskedOfThePatientAtTimeOfProcedure
    /// </summary>
    public const string LiteralFastingNotAskedOfThePatientAtTimeOfProcedure = "FNA";

    /// <summary>
    /// Literal for code: ThePatientIndicatedTheyDidNotFastPriorToTheProcedure
    /// </summary>
    public const string LiteralThePatientIndicatedTheyDidNotFastPriorToTheProcedure = "NF";

    /// <summary>
    /// Literal for code: NotGivenPatientWasNotAskedAtTheTimeOfTheProcedure
    /// </summary>
    public const string LiteralNotGivenPatientWasNotAskedAtTheTimeOfTheProcedure = "NG";
  };
}
