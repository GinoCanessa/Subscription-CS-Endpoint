// <auto-generated />
// Built from: hl7.fhir.r4b.core version: 4.1.0
  // Option: "NAMESPACE" = "fhirCsR4"

using fhirCsR4.Models;

namespace fhirCsR4.ValueSets
{
  /// <summary>
  /// This value set includes smattering of Payment Adjustment Reason codes.
  /// </summary>
  public static class PaymentAdjustmentReasonCodes
  {
    /// <summary>
    /// Prior Payment Reversal
    /// </summary>
    public static readonly Coding PriorPaymentReversal = new Coding
    {
      Code = "a001",
      Display = "Prior Payment Reversal",
      System = "http://terminology.hl7.org/CodeSystem/payment-adjustment-reason"
    };
    /// <summary>
    /// Prior Overpayment
    /// </summary>
    public static readonly Coding PriorOverpayment = new Coding
    {
      Code = "a002",
      Display = "Prior Overpayment",
      System = "http://terminology.hl7.org/CodeSystem/payment-adjustment-reason"
    };

    /// <summary>
    /// Literal for code: PriorPaymentReversal
    /// </summary>
    public const string LiteralPriorPaymentReversal = "a001";

    /// <summary>
    /// Literal for code: PriorOverpayment
    /// </summary>
    public const string LiteralPriorOverpayment = "a002";
  };
}
