// <auto-generated />
// Built from: hl7.fhir.r4b.core version: 4.1.0
  // Option: "NAMESPACE" = "fhirCsR4"

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using fhirCsR4.Serialization;

namespace fhirCsR4.Models
{
  /// <summary>
  /// There SHOULD be at least one destination, but in some circumstances, the source system is unaware of any particular destination system.
  /// </summary>
  [JsonConverter(typeof(fhirCsR4.Serialization.JsonStreamComponentConverter<MessageHeaderDestination>))]
  public class MessageHeaderDestination : BackboneElement,  IFhirJsonSerializable {
    /// <summary>
    /// The id may be a non-resolvable URI for systems that do not use standard network-based addresses.
    /// </summary>
    public string Endpoint { get; set; }
    /// <summary>
    /// Extension container element for Endpoint
    /// </summary>
    public Element _Endpoint { get; set; }
    /// <summary>
    /// Human-readable name for the target system.
    /// </summary>
    public string Name { get; set; }
    /// <summary>
    /// Extension container element for Name
    /// </summary>
    public Element _Name { get; set; }
    /// <summary>
    /// Allows data conveyed by a message to be addressed to a particular person or department when routing to a specific application isn't sufficient.
    /// </summary>
    public Reference Receiver { get; set; }
    /// <summary>
    /// Identifies the target end system in situations where the initial message transmission is to an intermediary system.
    /// </summary>
    public Reference Target { get; set; }
    /// <summary>
    /// Serialize to a JSON object
    /// </summary>
    public new void SerializeJson(Utf8JsonWriter writer, JsonSerializerOptions options, bool includeStartObject = true)
    {
      if (includeStartObject)
      {
        writer.WriteStartObject();
      }
      ((fhirCsR4.Models.BackboneElement)this).SerializeJson(writer, options, false);

      if (!string.IsNullOrEmpty(Name))
      {
        writer.WriteString("name", (string)Name!);
      }

      if (_Name != null)
      {
        writer.WritePropertyName("_name");
        _Name.SerializeJson(writer, options);
      }

      if (Target != null)
      {
        writer.WritePropertyName("target");
        Target.SerializeJson(writer, options);
      }

      if (!string.IsNullOrEmpty(Endpoint))
      {
        writer.WriteString("endpoint", (string)Endpoint!);
      }

      if (_Endpoint != null)
      {
        writer.WritePropertyName("_endpoint");
        _Endpoint.SerializeJson(writer, options);
      }

      if (Receiver != null)
      {
        writer.WritePropertyName("receiver");
        Receiver.SerializeJson(writer, options);
      }

      if (includeStartObject)
      {
        writer.WriteEndObject();
      }
    }
    /// <summary>
    /// Deserialize a JSON property
    /// </summary>
    public new void DeserializeJsonProperty(ref Utf8JsonReader reader, JsonSerializerOptions options, string propertyName)
    {
      switch (propertyName)
      {
        case "endpoint":
          Endpoint = reader.GetString();
          break;

        case "_endpoint":
          _Endpoint = new fhirCsR4.Models.Element();
          _Endpoint.DeserializeJson(ref reader, options);
          break;

        case "name":
          Name = reader.GetString();
          break;

        case "_name":
          _Name = new fhirCsR4.Models.Element();
          _Name.DeserializeJson(ref reader, options);
          break;

        case "receiver":
          Receiver = new fhirCsR4.Models.Reference();
          Receiver.DeserializeJson(ref reader, options);
          break;

        case "target":
          Target = new fhirCsR4.Models.Reference();
          Target.DeserializeJson(ref reader, options);
          break;

        default:
          ((fhirCsR4.Models.BackboneElement)this).DeserializeJsonProperty(ref reader, options, propertyName);
          break;
      }
    }

    /// <summary>
    /// Deserialize a JSON object
    /// </summary>
    public new void DeserializeJson(ref Utf8JsonReader reader, JsonSerializerOptions options)
    {
      string propertyName;

      while (reader.Read())
      {
        if (reader.TokenType == JsonTokenType.EndObject)
        {
          return;
        }

        if (reader.TokenType == JsonTokenType.PropertyName)
        {
          propertyName = reader.GetString();
          reader.Read();
          this.DeserializeJsonProperty(ref reader, options, propertyName);
        }
      }

      throw new JsonException();
    }
  }
  /// <summary>
  /// The source application from which this message originated.
  /// </summary>
  [JsonConverter(typeof(fhirCsR4.Serialization.JsonStreamComponentConverter<MessageHeaderSource>))]
  public class MessageHeaderSource : BackboneElement,  IFhirJsonSerializable {
    /// <summary>
    /// An e-mail, phone, website or other contact point to use to resolve issues with message communications.
    /// </summary>
    public ContactPoint Contact { get; set; }
    /// <summary>
    /// The id may be a non-resolvable URI for systems that do not use standard network-based addresses.
    /// </summary>
    public string Endpoint { get; set; }
    /// <summary>
    /// Extension container element for Endpoint
    /// </summary>
    public Element _Endpoint { get; set; }
    /// <summary>
    /// Human-readable name for the source system.
    /// </summary>
    public string Name { get; set; }
    /// <summary>
    /// Extension container element for Name
    /// </summary>
    public Element _Name { get; set; }
    /// <summary>
    /// May include configuration or other information useful in debugging.
    /// </summary>
    public string Software { get; set; }
    /// <summary>
    /// Extension container element for Software
    /// </summary>
    public Element _Software { get; set; }
    /// <summary>
    /// Can convey versions of multiple systems in situations where a message passes through multiple hands.
    /// </summary>
    public string Version { get; set; }
    /// <summary>
    /// Extension container element for Version
    /// </summary>
    public Element _Version { get; set; }
    /// <summary>
    /// Serialize to a JSON object
    /// </summary>
    public new void SerializeJson(Utf8JsonWriter writer, JsonSerializerOptions options, bool includeStartObject = true)
    {
      if (includeStartObject)
      {
        writer.WriteStartObject();
      }
      ((fhirCsR4.Models.BackboneElement)this).SerializeJson(writer, options, false);

      if (!string.IsNullOrEmpty(Name))
      {
        writer.WriteString("name", (string)Name!);
      }

      if (_Name != null)
      {
        writer.WritePropertyName("_name");
        _Name.SerializeJson(writer, options);
      }

      if (!string.IsNullOrEmpty(Software))
      {
        writer.WriteString("software", (string)Software!);
      }

      if (_Software != null)
      {
        writer.WritePropertyName("_software");
        _Software.SerializeJson(writer, options);
      }

      if (!string.IsNullOrEmpty(Version))
      {
        writer.WriteString("version", (string)Version!);
      }

      if (_Version != null)
      {
        writer.WritePropertyName("_version");
        _Version.SerializeJson(writer, options);
      }

      if (Contact != null)
      {
        writer.WritePropertyName("contact");
        Contact.SerializeJson(writer, options);
      }

      if (!string.IsNullOrEmpty(Endpoint))
      {
        writer.WriteString("endpoint", (string)Endpoint!);
      }

      if (_Endpoint != null)
      {
        writer.WritePropertyName("_endpoint");
        _Endpoint.SerializeJson(writer, options);
      }

      if (includeStartObject)
      {
        writer.WriteEndObject();
      }
    }
    /// <summary>
    /// Deserialize a JSON property
    /// </summary>
    public new void DeserializeJsonProperty(ref Utf8JsonReader reader, JsonSerializerOptions options, string propertyName)
    {
      switch (propertyName)
      {
        case "contact":
          Contact = new fhirCsR4.Models.ContactPoint();
          Contact.DeserializeJson(ref reader, options);
          break;

        case "endpoint":
          Endpoint = reader.GetString();
          break;

        case "_endpoint":
          _Endpoint = new fhirCsR4.Models.Element();
          _Endpoint.DeserializeJson(ref reader, options);
          break;

        case "name":
          Name = reader.GetString();
          break;

        case "_name":
          _Name = new fhirCsR4.Models.Element();
          _Name.DeserializeJson(ref reader, options);
          break;

        case "software":
          Software = reader.GetString();
          break;

        case "_software":
          _Software = new fhirCsR4.Models.Element();
          _Software.DeserializeJson(ref reader, options);
          break;

        case "version":
          Version = reader.GetString();
          break;

        case "_version":
          _Version = new fhirCsR4.Models.Element();
          _Version.DeserializeJson(ref reader, options);
          break;

        default:
          ((fhirCsR4.Models.BackboneElement)this).DeserializeJsonProperty(ref reader, options, propertyName);
          break;
      }
    }

    /// <summary>
    /// Deserialize a JSON object
    /// </summary>
    public new void DeserializeJson(ref Utf8JsonReader reader, JsonSerializerOptions options)
    {
      string propertyName;

      while (reader.Read())
      {
        if (reader.TokenType == JsonTokenType.EndObject)
        {
          return;
        }

        if (reader.TokenType == JsonTokenType.PropertyName)
        {
          propertyName = reader.GetString();
          reader.Read();
          this.DeserializeJsonProperty(ref reader, options, propertyName);
        }
      }

      throw new JsonException();
    }
  }
  /// <summary>
  /// Information about the message that this message is a response to.  Only present if this message is a response.
  /// </summary>
  [JsonConverter(typeof(fhirCsR4.Serialization.JsonStreamComponentConverter<MessageHeaderResponse>))]
  public class MessageHeaderResponse : BackboneElement,  IFhirJsonSerializable {
    /// <summary>
    /// This is a generic response to the request message. Specific data for the response will be found in MessageHeader.focus.
    /// </summary>
    public string Code { get; set; }
    /// <summary>
    /// Extension container element for Code
    /// </summary>
    public Element _Code { get; set; }
    /// <summary>
    /// This SHALL be contained in the bundle. If any of the issues are errors, the response code SHALL be an error.
    /// </summary>
    public Reference Details { get; set; }
    /// <summary>
    /// The MessageHeader.id of the message to which this message is a response.
    /// </summary>
    public string Identifier { get; set; }
    /// <summary>
    /// Extension container element for Identifier
    /// </summary>
    public Element _Identifier { get; set; }
    /// <summary>
    /// Serialize to a JSON object
    /// </summary>
    public new void SerializeJson(Utf8JsonWriter writer, JsonSerializerOptions options, bool includeStartObject = true)
    {
      if (includeStartObject)
      {
        writer.WriteStartObject();
      }
      ((fhirCsR4.Models.BackboneElement)this).SerializeJson(writer, options, false);

      if (!string.IsNullOrEmpty(Identifier))
      {
        writer.WriteString("identifier", (string)Identifier!);
      }

      if (_Identifier != null)
      {
        writer.WritePropertyName("_identifier");
        _Identifier.SerializeJson(writer, options);
      }

      if (!string.IsNullOrEmpty(Code))
      {
        writer.WriteString("code", (string)Code!);
      }

      if (_Code != null)
      {
        writer.WritePropertyName("_code");
        _Code.SerializeJson(writer, options);
      }

      if (Details != null)
      {
        writer.WritePropertyName("details");
        Details.SerializeJson(writer, options);
      }

      if (includeStartObject)
      {
        writer.WriteEndObject();
      }
    }
    /// <summary>
    /// Deserialize a JSON property
    /// </summary>
    public new void DeserializeJsonProperty(ref Utf8JsonReader reader, JsonSerializerOptions options, string propertyName)
    {
      switch (propertyName)
      {
        case "code":
          Code = reader.GetString();
          break;

        case "_code":
          _Code = new fhirCsR4.Models.Element();
          _Code.DeserializeJson(ref reader, options);
          break;

        case "details":
          Details = new fhirCsR4.Models.Reference();
          Details.DeserializeJson(ref reader, options);
          break;

        case "identifier":
          Identifier = reader.GetString();
          break;

        case "_identifier":
          _Identifier = new fhirCsR4.Models.Element();
          _Identifier.DeserializeJson(ref reader, options);
          break;

        default:
          ((fhirCsR4.Models.BackboneElement)this).DeserializeJsonProperty(ref reader, options, propertyName);
          break;
      }
    }

    /// <summary>
    /// Deserialize a JSON object
    /// </summary>
    public new void DeserializeJson(ref Utf8JsonReader reader, JsonSerializerOptions options)
    {
      string propertyName;

      while (reader.Read())
      {
        if (reader.TokenType == JsonTokenType.EndObject)
        {
          return;
        }

        if (reader.TokenType == JsonTokenType.PropertyName)
        {
          propertyName = reader.GetString();
          reader.Read();
          this.DeserializeJsonProperty(ref reader, options, propertyName);
        }
      }

      throw new JsonException();
    }
  }
  /// <summary>
  /// Code Values for the MessageHeader.response.code field
  /// </summary>
  public static class MessageHeaderResponseCodeCodes {
    public const string OK = "ok";
    public const string TRANSIENT_ERROR = "transient-error";
    public const string FATAL_ERROR = "fatal-error";
  }
  /// <summary>
  /// The header for a message exchange that is either requesting or responding to an action.  The reference(s) that are the subject of the action as well as other information related to the action are typically transmitted in a bundle in which the MessageHeader resource instance is the first resource in the bundle.
  /// </summary>
  [JsonConverter(typeof(fhirCsR4.Serialization.JsonStreamComponentConverter<MessageHeader>))]
  public class MessageHeader : DomainResource,  IFhirJsonSerializable {
    /// <summary>
    /// Resource Type Name
    /// </summary>
    public override string ResourceType => "MessageHeader";
    /// <summary>
    /// Usually only for the request but can be used in a response.
    /// </summary>
    public Reference Author { get; set; }
    /// <summary>
    /// Permanent link to the MessageDefinition for this message.
    /// </summary>
    public string Definition { get; set; }
    /// <summary>
    /// Extension container element for Definition
    /// </summary>
    public Element _Definition { get; set; }
    /// <summary>
    /// There SHOULD be at least one destination, but in some circumstances, the source system is unaware of any particular destination system.
    /// </summary>
    public List<MessageHeaderDestination> Destination { get; set; }
    /// <summary>
    /// Usually only for the request but can be used in a response.
    /// </summary>
    public Reference Enterer { get; set; }
    /// <summary>
    /// The time of the event will be found in the focus resource. The time of the message will be found in [Bundle.timestamp](bundle-definitions.html#Bundle.timestamp).
    /// </summary>
    public Coding EventCoding { get; set; }
    /// <summary>
    /// The time of the event will be found in the focus resource. The time of the message will be found in [Bundle.timestamp](bundle-definitions.html#Bundle.timestamp).
    /// </summary>
    public string EventUri { get; set; }
    /// <summary>
    /// Extension container element for EventUri
    /// </summary>
    public Element _EventUri { get; set; }
    /// <summary>
    /// The data is defined where the transaction type is defined. The transaction data is always included in the bundle that is the full message.  Only the root resource is specified.  The resources it references should be contained in the bundle but are not also listed here.  Multiple repetitions are allowed to cater for merges and other situations with multiple focal targets.
    /// </summary>
    public List<Reference> Focus { get; set; }
    /// <summary>
    /// Coded indication of the cause for the event - indicates  a reason for the occurrence of the event that is a focus of this message.
    /// </summary>
    public CodeableConcept Reason { get; set; }
    /// <summary>
    /// Information about the message that this message is a response to.  Only present if this message is a response.
    /// </summary>
    public MessageHeaderResponse Response { get; set; }
    /// <summary>
    /// Usually only for the request but can be used in a response.
    /// </summary>
    public Reference Responsible { get; set; }
    /// <summary>
    /// Use case is for where a (trusted) sending system is responsible for multiple organizations, and therefore cannot differentiate based on source endpoint / authentication alone.
    /// </summary>
    public Reference Sender { get; set; }
    /// <summary>
    /// The source application from which this message originated.
    /// </summary>
    public MessageHeaderSource Source { get; set; }
    /// <summary>
    /// Serialize to a JSON object
    /// </summary>
    public new void SerializeJson(Utf8JsonWriter writer, JsonSerializerOptions options, bool includeStartObject = true)
    {
      if (includeStartObject)
      {
        writer.WriteStartObject();
      }
      if (!string.IsNullOrEmpty(ResourceType))
      {
        writer.WriteString("resourceType", (string)ResourceType!);
      }


      ((fhirCsR4.Models.DomainResource)this).SerializeJson(writer, options, false);

      if (EventCoding != null)
      {
        writer.WritePropertyName("eventCoding");
        EventCoding.SerializeJson(writer, options);
      }

      if (!string.IsNullOrEmpty(EventUri))
      {
        writer.WriteString("eventUri", (string)EventUri!);
      }

      if (_EventUri != null)
      {
        writer.WritePropertyName("_eventUri");
        _EventUri.SerializeJson(writer, options);
      }

      if ((Destination != null) && (Destination.Count != 0))
      {
        writer.WritePropertyName("destination");
        writer.WriteStartArray();

        foreach (MessageHeaderDestination valDestination in Destination)
        {
          valDestination.SerializeJson(writer, options, true);
        }

        writer.WriteEndArray();
      }

      if (Sender != null)
      {
        writer.WritePropertyName("sender");
        Sender.SerializeJson(writer, options);
      }

      if (Enterer != null)
      {
        writer.WritePropertyName("enterer");
        Enterer.SerializeJson(writer, options);
      }

      if (Author != null)
      {
        writer.WritePropertyName("author");
        Author.SerializeJson(writer, options);
      }

      if (Source != null)
      {
        writer.WritePropertyName("source");
        Source.SerializeJson(writer, options);
      }

      if (Responsible != null)
      {
        writer.WritePropertyName("responsible");
        Responsible.SerializeJson(writer, options);
      }

      if (Reason != null)
      {
        writer.WritePropertyName("reason");
        Reason.SerializeJson(writer, options);
      }

      if (Response != null)
      {
        writer.WritePropertyName("response");
        Response.SerializeJson(writer, options);
      }

      if ((Focus != null) && (Focus.Count != 0))
      {
        writer.WritePropertyName("focus");
        writer.WriteStartArray();

        foreach (Reference valFocus in Focus)
        {
          valFocus.SerializeJson(writer, options, true);
        }

        writer.WriteEndArray();
      }

      if (!string.IsNullOrEmpty(Definition))
      {
        writer.WriteString("definition", (string)Definition!);
      }

      if (_Definition != null)
      {
        writer.WritePropertyName("_definition");
        _Definition.SerializeJson(writer, options);
      }

      if (includeStartObject)
      {
        writer.WriteEndObject();
      }
    }
    /// <summary>
    /// Deserialize a JSON property
    /// </summary>
    public new void DeserializeJsonProperty(ref Utf8JsonReader reader, JsonSerializerOptions options, string propertyName)
    {
      switch (propertyName)
      {
        case "author":
          Author = new fhirCsR4.Models.Reference();
          Author.DeserializeJson(ref reader, options);
          break;

        case "definition":
          Definition = reader.GetString();
          break;

        case "_definition":
          _Definition = new fhirCsR4.Models.Element();
          _Definition.DeserializeJson(ref reader, options);
          break;

        case "destination":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          Destination = new List<MessageHeaderDestination>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            fhirCsR4.Models.MessageHeaderDestination objDestination = new fhirCsR4.Models.MessageHeaderDestination();
            objDestination.DeserializeJson(ref reader, options);
            Destination.Add(objDestination);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (Destination.Count == 0)
          {
            Destination = null;
          }

          break;

        case "enterer":
          Enterer = new fhirCsR4.Models.Reference();
          Enterer.DeserializeJson(ref reader, options);
          break;

        case "eventCoding":
          EventCoding = new fhirCsR4.Models.Coding();
          EventCoding.DeserializeJson(ref reader, options);
          break;

        case "eventUri":
          EventUri = reader.GetString();
          break;

        case "_eventUri":
          _EventUri = new fhirCsR4.Models.Element();
          _EventUri.DeserializeJson(ref reader, options);
          break;

        case "focus":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          Focus = new List<Reference>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            fhirCsR4.Models.Reference objFocus = new fhirCsR4.Models.Reference();
            objFocus.DeserializeJson(ref reader, options);
            Focus.Add(objFocus);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (Focus.Count == 0)
          {
            Focus = null;
          }

          break;

        case "reason":
          Reason = new fhirCsR4.Models.CodeableConcept();
          Reason.DeserializeJson(ref reader, options);
          break;

        case "response":
          Response = new fhirCsR4.Models.MessageHeaderResponse();
          Response.DeserializeJson(ref reader, options);
          break;

        case "responsible":
          Responsible = new fhirCsR4.Models.Reference();
          Responsible.DeserializeJson(ref reader, options);
          break;

        case "sender":
          Sender = new fhirCsR4.Models.Reference();
          Sender.DeserializeJson(ref reader, options);
          break;

        case "source":
          Source = new fhirCsR4.Models.MessageHeaderSource();
          Source.DeserializeJson(ref reader, options);
          break;

        default:
          ((fhirCsR4.Models.DomainResource)this).DeserializeJsonProperty(ref reader, options, propertyName);
          break;
      }
    }

    /// <summary>
    /// Deserialize a JSON object
    /// </summary>
    public new void DeserializeJson(ref Utf8JsonReader reader, JsonSerializerOptions options)
    {
      string propertyName;

      while (reader.Read())
      {
        if (reader.TokenType == JsonTokenType.EndObject)
        {
          return;
        }

        if (reader.TokenType == JsonTokenType.PropertyName)
        {
          propertyName = reader.GetString();
          reader.Read();
          this.DeserializeJsonProperty(ref reader, options, propertyName);
        }
      }

      throw new JsonException();
    }
  }
}
