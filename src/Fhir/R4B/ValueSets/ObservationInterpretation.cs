// <auto-generated />
// Built from: hl7.fhir.r4b.core version: 4.1.0
  // Option: "NAMESPACE" = "fhirCsR4"

using fhirCsR4.Models;

namespace fhirCsR4.ValueSets
{
  /// <summary>
  /// A categorical assessment, providing a rough qualitative interpretation of the observation value,    such as “normal”/ “abnormal”,”low” / “high”, “better” / “worse”, “susceptible” / “resistant”, “expected”/ “not expected”.    The value set is intended to be for ANY use where coded representation of an interpretation is needed.   
  ///    
  ///    Notes:
  ///    
  ///    This is being communicated in v2.x in OBX-8 (Observation Interpretation), in v3 in ObservationInterpretation (CWE) in R1 (Representative Realm) and in FHIR in    Observation.interpretation. Historically these values come from the laboratory domain, and these codes are extensively    used. The value set binding is extensible, so codes outside the value set that are needed for interpretation concepts    (i.e. particular meanings) that are not included in the value set can be used, and these new codes may also be added to    the value set and published in a future version.
  /// </summary>
  public static class ObservationInterpretationCodes
  {
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding GeneticObservationInterpretation = new Coding
    {
      Code = "_GeneticObservationInterpretation",
      Display = "GeneticObservationInterpretation",
      System = "http://terminology.hl7.org/CodeSystem/v3-ObservationInterpretation"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding ObservationInterpretationChange = new Coding
    {
      Code = "_ObservationInterpretationChange",
      Display = "ObservationInterpretationChange",
      System = "http://terminology.hl7.org/CodeSystem/v3-ObservationInterpretation"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding ObservationInterpretationExceptions = new Coding
    {
      Code = "_ObservationInterpretationExceptions",
      Display = "ObservationInterpretationExceptions",
      System = "http://terminology.hl7.org/CodeSystem/v3-ObservationInterpretation"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding ObservationInterpretationNormality = new Coding
    {
      Code = "_ObservationInterpretationNormality",
      Display = "ObservationInterpretationNormality",
      System = "http://terminology.hl7.org/CodeSystem/v3-ObservationInterpretation"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding ObservationInterpretationSusceptibility = new Coding
    {
      Code = "_ObservationInterpretationSusceptibility",
      Display = "ObservationInterpretationSusceptibility",
      System = "http://terminology.hl7.org/CodeSystem/v3-ObservationInterpretation"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding OffScaleLow = new Coding
    {
      Code = "<",
      Display = "Off scale low",
      System = "http://terminology.hl7.org/CodeSystem/v3-ObservationInterpretation"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding OffScaleHigh = new Coding
    {
      Code = ">",
      Display = "Off scale high",
      System = "http://terminology.hl7.org/CodeSystem/v3-ObservationInterpretation"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding Abnormal = new Coding
    {
      Code = "A",
      Display = "Abnormal",
      System = "http://terminology.hl7.org/CodeSystem/v3-ObservationInterpretation"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding CriticalAbnormal = new Coding
    {
      Code = "AA",
      Display = "Critical abnormal",
      System = "http://terminology.hl7.org/CodeSystem/v3-ObservationInterpretation"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding Better = new Coding
    {
      Code = "B",
      Display = "Better",
      System = "http://terminology.hl7.org/CodeSystem/v3-ObservationInterpretation"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding Carrier = new Coding
    {
      Code = "CAR",
      Display = "Carrier",
      System = "http://terminology.hl7.org/CodeSystem/v3-ObservationInterpretation"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding SignificantChangeDown = new Coding
    {
      Code = "D",
      Display = "Significant change down",
      System = "http://terminology.hl7.org/CodeSystem/v3-ObservationInterpretation"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding Detected = new Coding
    {
      Code = "DET",
      Display = "Detected",
      System = "http://terminology.hl7.org/CodeSystem/v3-ObservationInterpretation"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding Equivocal = new Coding
    {
      Code = "E",
      Display = "Equivocal",
      System = "http://terminology.hl7.org/CodeSystem/v3-ObservationInterpretation"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding OutsideThreshold = new Coding
    {
      Code = "EX",
      Display = "outside threshold",
      System = "http://terminology.hl7.org/CodeSystem/v3-ObservationInterpretation"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding Expected = new Coding
    {
      Code = "EXP",
      Display = "Expected",
      System = "http://terminology.hl7.org/CodeSystem/v3-ObservationInterpretation"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding High = new Coding
    {
      Code = "H",
      Display = "High",
      System = "http://terminology.hl7.org/CodeSystem/v3-ObservationInterpretation"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding CriticalHigh = new Coding
    {
      Code = "HH",
      Display = "Critical high",
      System = "http://terminology.hl7.org/CodeSystem/v3-ObservationInterpretation"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding SignificantlyHigh = new Coding
    {
      Code = "HU",
      Display = "Significantly high",
      System = "http://terminology.hl7.org/CodeSystem/v3-ObservationInterpretation"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding AboveHighThreshold = new Coding
    {
      Code = "HX",
      Display = "above high threshold",
      System = "http://terminology.hl7.org/CodeSystem/v3-ObservationInterpretation"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding Intermediate = new Coding
    {
      Code = "I",
      Display = "Intermediate",
      System = "http://terminology.hl7.org/CodeSystem/v3-ObservationInterpretation"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding InsufficientEvidence = new Coding
    {
      Code = "IE",
      Display = "Insufficient evidence",
      System = "http://terminology.hl7.org/CodeSystem/v3-ObservationInterpretation"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding Indeterminate = new Coding
    {
      Code = "IND",
      Display = "Indeterminate",
      System = "http://terminology.hl7.org/CodeSystem/v3-ObservationInterpretation"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding Low = new Coding
    {
      Code = "L",
      Display = "Low",
      System = "http://terminology.hl7.org/CodeSystem/v3-ObservationInterpretation"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding CriticalLow = new Coding
    {
      Code = "LL",
      Display = "Critical low",
      System = "http://terminology.hl7.org/CodeSystem/v3-ObservationInterpretation"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding SignificantlyLow = new Coding
    {
      Code = "LU",
      Display = "Significantly low",
      System = "http://terminology.hl7.org/CodeSystem/v3-ObservationInterpretation"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding BelowLowThreshold = new Coding
    {
      Code = "LX",
      Display = "below low threshold",
      System = "http://terminology.hl7.org/CodeSystem/v3-ObservationInterpretation"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding Normal = new Coding
    {
      Code = "N",
      Display = "Normal",
      System = "http://terminology.hl7.org/CodeSystem/v3-ObservationInterpretation"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding NoCLSIDefinedBreakpoint = new Coding
    {
      Code = "NCL",
      Display = "No CLSI defined breakpoint",
      System = "http://terminology.hl7.org/CodeSystem/v3-ObservationInterpretation"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding NotDetected = new Coding
    {
      Code = "ND",
      Display = "Not detected",
      System = "http://terminology.hl7.org/CodeSystem/v3-ObservationInterpretation"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding Negative = new Coding
    {
      Code = "NEG",
      Display = "Negative",
      System = "http://terminology.hl7.org/CodeSystem/v3-ObservationInterpretation"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding NonReactive = new Coding
    {
      Code = "NR",
      Display = "Non-reactive",
      System = "http://terminology.hl7.org/CodeSystem/v3-ObservationInterpretation"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding NonSusceptible = new Coding
    {
      Code = "NS",
      Display = "Non-susceptible",
      System = "http://terminology.hl7.org/CodeSystem/v3-ObservationInterpretation"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding ObservationInterpretationDetection = new Coding
    {
      Code = "ObservationInterpretationDetection",
      Display = "ObservationInterpretationDetection",
      System = "http://terminology.hl7.org/CodeSystem/v3-ObservationInterpretation"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding ObservationInterpretationExpectation = new Coding
    {
      Code = "ObservationInterpretationExpectation",
      Display = "ObservationInterpretationExpectation",
      System = "http://terminology.hl7.org/CodeSystem/v3-ObservationInterpretation"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding Positive = new Coding
    {
      Code = "POS",
      Display = "Positive",
      System = "http://terminology.hl7.org/CodeSystem/v3-ObservationInterpretation"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding Resistant = new Coding
    {
      Code = "R",
      Display = "Resistant",
      System = "http://terminology.hl7.org/CodeSystem/v3-ObservationInterpretation"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding ReactivityObservationInterpretation = new Coding
    {
      Code = "ReactivityObservationInterpretation",
      Display = "ReactivityObservationInterpretation",
      System = "http://terminology.hl7.org/CodeSystem/v3-ObservationInterpretation"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding Reactive = new Coding
    {
      Code = "RR",
      Display = "Reactive",
      System = "http://terminology.hl7.org/CodeSystem/v3-ObservationInterpretation"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding Susceptible = new Coding
    {
      Code = "S",
      Display = "Susceptible",
      System = "http://terminology.hl7.org/CodeSystem/v3-ObservationInterpretation"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding SusceptibleDoseDependent = new Coding
    {
      Code = "SDD",
      Display = "Susceptible-dose dependent",
      System = "http://terminology.hl7.org/CodeSystem/v3-ObservationInterpretation"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding SynergyResistant = new Coding
    {
      Code = "SYN-R",
      Display = "Synergy - resistant",
      System = "http://terminology.hl7.org/CodeSystem/v3-ObservationInterpretation"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding SynergySusceptible = new Coding
    {
      Code = "SYN-S",
      Display = "Synergy - susceptible",
      System = "http://terminology.hl7.org/CodeSystem/v3-ObservationInterpretation"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding SignificantChangeUp = new Coding
    {
      Code = "U",
      Display = "Significant change up",
      System = "http://terminology.hl7.org/CodeSystem/v3-ObservationInterpretation"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding Unexpected = new Coding
    {
      Code = "UNE",
      Display = "Unexpected",
      System = "http://terminology.hl7.org/CodeSystem/v3-ObservationInterpretation"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding Worse = new Coding
    {
      Code = "W",
      Display = "Worse",
      System = "http://terminology.hl7.org/CodeSystem/v3-ObservationInterpretation"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding WeaklyReactive = new Coding
    {
      Code = "WR",
      Display = "Weakly reactive",
      System = "http://terminology.hl7.org/CodeSystem/v3-ObservationInterpretation"
    };

    /// <summary>
    /// Literal for code: GeneticObservationInterpretation
    /// </summary>
    public const string LiteralGeneticObservationInterpretation = "_GeneticObservationInterpretation";

    /// <summary>
    /// Literal for code: ObservationInterpretationChange
    /// </summary>
    public const string LiteralObservationInterpretationChange = "_ObservationInterpretationChange";

    /// <summary>
    /// Literal for code: ObservationInterpretationExceptions
    /// </summary>
    public const string LiteralObservationInterpretationExceptions = "_ObservationInterpretationExceptions";

    /// <summary>
    /// Literal for code: ObservationInterpretationNormality
    /// </summary>
    public const string LiteralObservationInterpretationNormality = "_ObservationInterpretationNormality";

    /// <summary>
    /// Literal for code: ObservationInterpretationSusceptibility
    /// </summary>
    public const string LiteralObservationInterpretationSusceptibility = "_ObservationInterpretationSusceptibility";

    /// <summary>
    /// Literal for code: OffScaleLow
    /// </summary>
    public const string LiteralOffScaleLow = "<";

    /// <summary>
    /// Literal for code: OffScaleHigh
    /// </summary>
    public const string LiteralOffScaleHigh = ">";

    /// <summary>
    /// Literal for code: Abnormal
    /// </summary>
    public const string LiteralAbnormal = "A";

    /// <summary>
    /// Literal for code: CriticalAbnormal
    /// </summary>
    public const string LiteralCriticalAbnormal = "AA";

    /// <summary>
    /// Literal for code: Better
    /// </summary>
    public const string LiteralBetter = "B";

    /// <summary>
    /// Literal for code: Carrier
    /// </summary>
    public const string LiteralCarrier = "CAR";

    /// <summary>
    /// Literal for code: SignificantChangeDown
    /// </summary>
    public const string LiteralSignificantChangeDown = "D";

    /// <summary>
    /// Literal for code: Detected
    /// </summary>
    public const string LiteralDetected = "DET";

    /// <summary>
    /// Literal for code: Equivocal
    /// </summary>
    public const string LiteralEquivocal = "E";

    /// <summary>
    /// Literal for code: OutsideThreshold
    /// </summary>
    public const string LiteralOutsideThreshold = "EX";

    /// <summary>
    /// Literal for code: Expected
    /// </summary>
    public const string LiteralExpected = "EXP";

    /// <summary>
    /// Literal for code: High
    /// </summary>
    public const string LiteralHigh = "H";

    /// <summary>
    /// Literal for code: CriticalHigh
    /// </summary>
    public const string LiteralCriticalHigh = "HH";

    /// <summary>
    /// Literal for code: SignificantlyHigh
    /// </summary>
    public const string LiteralSignificantlyHigh = "HU";

    /// <summary>
    /// Literal for code: AboveHighThreshold
    /// </summary>
    public const string LiteralAboveHighThreshold = "HX";

    /// <summary>
    /// Literal for code: Intermediate
    /// </summary>
    public const string LiteralIntermediate = "I";

    /// <summary>
    /// Literal for code: InsufficientEvidence
    /// </summary>
    public const string LiteralInsufficientEvidence = "IE";

    /// <summary>
    /// Literal for code: Indeterminate
    /// </summary>
    public const string LiteralIndeterminate = "IND";

    /// <summary>
    /// Literal for code: Low
    /// </summary>
    public const string LiteralLow = "L";

    /// <summary>
    /// Literal for code: CriticalLow
    /// </summary>
    public const string LiteralCriticalLow = "LL";

    /// <summary>
    /// Literal for code: SignificantlyLow
    /// </summary>
    public const string LiteralSignificantlyLow = "LU";

    /// <summary>
    /// Literal for code: BelowLowThreshold
    /// </summary>
    public const string LiteralBelowLowThreshold = "LX";

    /// <summary>
    /// Literal for code: Normal
    /// </summary>
    public const string LiteralNormal = "N";

    /// <summary>
    /// Literal for code: NoCLSIDefinedBreakpoint
    /// </summary>
    public const string LiteralNoCLSIDefinedBreakpoint = "NCL";

    /// <summary>
    /// Literal for code: NotDetected
    /// </summary>
    public const string LiteralNotDetected = "ND";

    /// <summary>
    /// Literal for code: Negative
    /// </summary>
    public const string LiteralNegative = "NEG";

    /// <summary>
    /// Literal for code: NonReactive
    /// </summary>
    public const string LiteralNonReactive = "NR";

    /// <summary>
    /// Literal for code: NonSusceptible
    /// </summary>
    public const string LiteralNonSusceptible = "NS";

    /// <summary>
    /// Literal for code: ObservationInterpretationDetection
    /// </summary>
    public const string LiteralObservationInterpretationDetection = "ObservationInterpretationDetection";

    /// <summary>
    /// Literal for code: ObservationInterpretationExpectation
    /// </summary>
    public const string LiteralObservationInterpretationExpectation = "ObservationInterpretationExpectation";

    /// <summary>
    /// Literal for code: Positive
    /// </summary>
    public const string LiteralPositive = "POS";

    /// <summary>
    /// Literal for code: Resistant
    /// </summary>
    public const string LiteralResistant = "R";

    /// <summary>
    /// Literal for code: ReactivityObservationInterpretation
    /// </summary>
    public const string LiteralReactivityObservationInterpretation = "ReactivityObservationInterpretation";

    /// <summary>
    /// Literal for code: Reactive
    /// </summary>
    public const string LiteralReactive = "RR";

    /// <summary>
    /// Literal for code: Susceptible
    /// </summary>
    public const string LiteralSusceptible = "S";

    /// <summary>
    /// Literal for code: SusceptibleDoseDependent
    /// </summary>
    public const string LiteralSusceptibleDoseDependent = "SDD";

    /// <summary>
    /// Literal for code: SynergyResistant
    /// </summary>
    public const string LiteralSynergyResistant = "SYN-R";

    /// <summary>
    /// Literal for code: SynergySusceptible
    /// </summary>
    public const string LiteralSynergySusceptible = "SYN-S";

    /// <summary>
    /// Literal for code: SignificantChangeUp
    /// </summary>
    public const string LiteralSignificantChangeUp = "U";

    /// <summary>
    /// Literal for code: Unexpected
    /// </summary>
    public const string LiteralUnexpected = "UNE";

    /// <summary>
    /// Literal for code: Worse
    /// </summary>
    public const string LiteralWorse = "W";

    /// <summary>
    /// Literal for code: WeaklyReactive
    /// </summary>
    public const string LiteralWeaklyReactive = "WR";
  };
}
