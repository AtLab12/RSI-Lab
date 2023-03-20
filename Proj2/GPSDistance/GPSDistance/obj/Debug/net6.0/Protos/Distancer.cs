// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Protos/Distancer.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace GPSDistance {

  /// <summary>Holder for reflection information generated from Protos/Distancer.proto</summary>
  public static partial class DistancerReflection {

    #region Descriptor
    /// <summary>File descriptor for Protos/Distancer.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static DistancerReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChZQcm90b3MvRGlzdGFuY2VyLnByb3RvEglEaXN0YW5jZXIi5wEKEERpc3Rh",
            "bmNlclJlcXVlc3QSMQoGcG9pbnQxGAEgASgLMiEuRGlzdGFuY2VyLkRpc3Rh",
            "bmNlclJlcXVlc3QuUG9pbnQSMQoGcG9pbnQyGAIgASgLMiEuRGlzdGFuY2Vy",
            "LkRpc3RhbmNlclJlcXVlc3QuUG9pbnQSMQoGcG9pbnQzGAMgASgLMiEuRGlz",
            "dGFuY2VyLkRpc3RhbmNlclJlcXVlc3QuUG9pbnQaOgoFUG9pbnQSDAoEY2l0",
            "eRgBIAEoCRIQCghsYXRpdHVkZRgCIAEoARIRCglsb25naXR1ZGUYAyABKAEi",
            "JQoRRGlzdGFuY2VyUmVzcG9uc2USEAoIZGlzdGFuY2UYASABKAEyWwoJRGlz",
            "dGFuY2VyEk4KEUNhbGN1bGF0ZURpc3RhbmNlEhsuRGlzdGFuY2VyLkRpc3Rh",
            "bmNlclJlcXVlc3QaHC5EaXN0YW5jZXIuRGlzdGFuY2VyUmVzcG9uc2VCDqoC",
            "C0dQU0Rpc3RhbmNlYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::GPSDistance.DistancerRequest), global::GPSDistance.DistancerRequest.Parser, new[]{ "Point1", "Point2", "Point3" }, null, null, null, new pbr::GeneratedClrTypeInfo[] { new pbr::GeneratedClrTypeInfo(typeof(global::GPSDistance.DistancerRequest.Types.Point), global::GPSDistance.DistancerRequest.Types.Point.Parser, new[]{ "City", "Latitude", "Longitude" }, null, null, null, null)}),
            new pbr::GeneratedClrTypeInfo(typeof(global::GPSDistance.DistancerResponse), global::GPSDistance.DistancerResponse.Parser, new[]{ "Distance" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class DistancerRequest : pb::IMessage<DistancerRequest>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<DistancerRequest> _parser = new pb::MessageParser<DistancerRequest>(() => new DistancerRequest());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<DistancerRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::GPSDistance.DistancerReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public DistancerRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public DistancerRequest(DistancerRequest other) : this() {
      point1_ = other.point1_ != null ? other.point1_.Clone() : null;
      point2_ = other.point2_ != null ? other.point2_.Clone() : null;
      point3_ = other.point3_ != null ? other.point3_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public DistancerRequest Clone() {
      return new DistancerRequest(this);
    }

    /// <summary>Field number for the "point1" field.</summary>
    public const int Point1FieldNumber = 1;
    private global::GPSDistance.DistancerRequest.Types.Point point1_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::GPSDistance.DistancerRequest.Types.Point Point1 {
      get { return point1_; }
      set {
        point1_ = value;
      }
    }

    /// <summary>Field number for the "point2" field.</summary>
    public const int Point2FieldNumber = 2;
    private global::GPSDistance.DistancerRequest.Types.Point point2_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::GPSDistance.DistancerRequest.Types.Point Point2 {
      get { return point2_; }
      set {
        point2_ = value;
      }
    }

    /// <summary>Field number for the "point3" field.</summary>
    public const int Point3FieldNumber = 3;
    private global::GPSDistance.DistancerRequest.Types.Point point3_;
    /// <summary>
    /// Opcjonalne
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::GPSDistance.DistancerRequest.Types.Point Point3 {
      get { return point3_; }
      set {
        point3_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as DistancerRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(DistancerRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(Point1, other.Point1)) return false;
      if (!object.Equals(Point2, other.Point2)) return false;
      if (!object.Equals(Point3, other.Point3)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (point1_ != null) hash ^= Point1.GetHashCode();
      if (point2_ != null) hash ^= Point2.GetHashCode();
      if (point3_ != null) hash ^= Point3.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void WriteTo(pb::CodedOutputStream output) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      if (point1_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(Point1);
      }
      if (point2_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(Point2);
      }
      if (point3_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(Point3);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (point1_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(Point1);
      }
      if (point2_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(Point2);
      }
      if (point3_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(Point3);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (point1_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Point1);
      }
      if (point2_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Point2);
      }
      if (point3_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Point3);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(DistancerRequest other) {
      if (other == null) {
        return;
      }
      if (other.point1_ != null) {
        if (point1_ == null) {
          Point1 = new global::GPSDistance.DistancerRequest.Types.Point();
        }
        Point1.MergeFrom(other.Point1);
      }
      if (other.point2_ != null) {
        if (point2_ == null) {
          Point2 = new global::GPSDistance.DistancerRequest.Types.Point();
        }
        Point2.MergeFrom(other.Point2);
      }
      if (other.point3_ != null) {
        if (point3_ == null) {
          Point3 = new global::GPSDistance.DistancerRequest.Types.Point();
        }
        Point3.MergeFrom(other.Point3);
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(pb::CodedInputStream input) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      input.ReadRawMessage(this);
    #else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            if (point1_ == null) {
              Point1 = new global::GPSDistance.DistancerRequest.Types.Point();
            }
            input.ReadMessage(Point1);
            break;
          }
          case 18: {
            if (point2_ == null) {
              Point2 = new global::GPSDistance.DistancerRequest.Types.Point();
            }
            input.ReadMessage(Point2);
            break;
          }
          case 26: {
            if (point3_ == null) {
              Point3 = new global::GPSDistance.DistancerRequest.Types.Point();
            }
            input.ReadMessage(Point3);
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 10: {
            if (point1_ == null) {
              Point1 = new global::GPSDistance.DistancerRequest.Types.Point();
            }
            input.ReadMessage(Point1);
            break;
          }
          case 18: {
            if (point2_ == null) {
              Point2 = new global::GPSDistance.DistancerRequest.Types.Point();
            }
            input.ReadMessage(Point2);
            break;
          }
          case 26: {
            if (point3_ == null) {
              Point3 = new global::GPSDistance.DistancerRequest.Types.Point();
            }
            input.ReadMessage(Point3);
            break;
          }
        }
      }
    }
    #endif

    #region Nested types
    /// <summary>Container for nested types declared in the DistancerRequest message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static partial class Types {
      public sealed partial class Point : pb::IMessage<Point>
      #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
          , pb::IBufferMessage
      #endif
      {
        private static readonly pb::MessageParser<Point> _parser = new pb::MessageParser<Point>(() => new Point());
        private pb::UnknownFieldSet _unknownFields;
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public static pb::MessageParser<Point> Parser { get { return _parser; } }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public static pbr::MessageDescriptor Descriptor {
          get { return global::GPSDistance.DistancerRequest.Descriptor.NestedTypes[0]; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        pbr::MessageDescriptor pb::IMessage.Descriptor {
          get { return Descriptor; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public Point() {
          OnConstruction();
        }

        partial void OnConstruction();

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public Point(Point other) : this() {
          city_ = other.city_;
          latitude_ = other.latitude_;
          longitude_ = other.longitude_;
          _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public Point Clone() {
          return new Point(this);
        }

        /// <summary>Field number for the "city" field.</summary>
        public const int CityFieldNumber = 1;
        private string city_ = "";
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public string City {
          get { return city_; }
          set {
            city_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
          }
        }

        /// <summary>Field number for the "latitude" field.</summary>
        public const int LatitudeFieldNumber = 2;
        private double latitude_;
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public double Latitude {
          get { return latitude_; }
          set {
            latitude_ = value;
          }
        }

        /// <summary>Field number for the "longitude" field.</summary>
        public const int LongitudeFieldNumber = 3;
        private double longitude_;
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public double Longitude {
          get { return longitude_; }
          set {
            longitude_ = value;
          }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public override bool Equals(object other) {
          return Equals(other as Point);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public bool Equals(Point other) {
          if (ReferenceEquals(other, null)) {
            return false;
          }
          if (ReferenceEquals(other, this)) {
            return true;
          }
          if (City != other.City) return false;
          if (!pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(Latitude, other.Latitude)) return false;
          if (!pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(Longitude, other.Longitude)) return false;
          return Equals(_unknownFields, other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public override int GetHashCode() {
          int hash = 1;
          if (City.Length != 0) hash ^= City.GetHashCode();
          if (Latitude != 0D) hash ^= pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(Latitude);
          if (Longitude != 0D) hash ^= pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(Longitude);
          if (_unknownFields != null) {
            hash ^= _unknownFields.GetHashCode();
          }
          return hash;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public override string ToString() {
          return pb::JsonFormatter.ToDiagnosticString(this);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public void WriteTo(pb::CodedOutputStream output) {
        #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
          output.WriteRawMessage(this);
        #else
          if (City.Length != 0) {
            output.WriteRawTag(10);
            output.WriteString(City);
          }
          if (Latitude != 0D) {
            output.WriteRawTag(17);
            output.WriteDouble(Latitude);
          }
          if (Longitude != 0D) {
            output.WriteRawTag(25);
            output.WriteDouble(Longitude);
          }
          if (_unknownFields != null) {
            _unknownFields.WriteTo(output);
          }
        #endif
        }

        #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
          if (City.Length != 0) {
            output.WriteRawTag(10);
            output.WriteString(City);
          }
          if (Latitude != 0D) {
            output.WriteRawTag(17);
            output.WriteDouble(Latitude);
          }
          if (Longitude != 0D) {
            output.WriteRawTag(25);
            output.WriteDouble(Longitude);
          }
          if (_unknownFields != null) {
            _unknownFields.WriteTo(ref output);
          }
        }
        #endif

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public int CalculateSize() {
          int size = 0;
          if (City.Length != 0) {
            size += 1 + pb::CodedOutputStream.ComputeStringSize(City);
          }
          if (Latitude != 0D) {
            size += 1 + 8;
          }
          if (Longitude != 0D) {
            size += 1 + 8;
          }
          if (_unknownFields != null) {
            size += _unknownFields.CalculateSize();
          }
          return size;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public void MergeFrom(Point other) {
          if (other == null) {
            return;
          }
          if (other.City.Length != 0) {
            City = other.City;
          }
          if (other.Latitude != 0D) {
            Latitude = other.Latitude;
          }
          if (other.Longitude != 0D) {
            Longitude = other.Longitude;
          }
          _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public void MergeFrom(pb::CodedInputStream input) {
        #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
          input.ReadRawMessage(this);
        #else
          uint tag;
          while ((tag = input.ReadTag()) != 0) {
            switch(tag) {
              default:
                _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
                break;
              case 10: {
                City = input.ReadString();
                break;
              }
              case 17: {
                Latitude = input.ReadDouble();
                break;
              }
              case 25: {
                Longitude = input.ReadDouble();
                break;
              }
            }
          }
        #endif
        }

        #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
          uint tag;
          while ((tag = input.ReadTag()) != 0) {
            switch(tag) {
              default:
                _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
                break;
              case 10: {
                City = input.ReadString();
                break;
              }
              case 17: {
                Latitude = input.ReadDouble();
                break;
              }
              case 25: {
                Longitude = input.ReadDouble();
                break;
              }
            }
          }
        }
        #endif

      }

    }
    #endregion

  }

  public sealed partial class DistancerResponse : pb::IMessage<DistancerResponse>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<DistancerResponse> _parser = new pb::MessageParser<DistancerResponse>(() => new DistancerResponse());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<DistancerResponse> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::GPSDistance.DistancerReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public DistancerResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public DistancerResponse(DistancerResponse other) : this() {
      distance_ = other.distance_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public DistancerResponse Clone() {
      return new DistancerResponse(this);
    }

    /// <summary>Field number for the "distance" field.</summary>
    public const int DistanceFieldNumber = 1;
    private double distance_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public double Distance {
      get { return distance_; }
      set {
        distance_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as DistancerResponse);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(DistancerResponse other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(Distance, other.Distance)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Distance != 0D) hash ^= pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(Distance);
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void WriteTo(pb::CodedOutputStream output) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      if (Distance != 0D) {
        output.WriteRawTag(9);
        output.WriteDouble(Distance);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (Distance != 0D) {
        output.WriteRawTag(9);
        output.WriteDouble(Distance);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (Distance != 0D) {
        size += 1 + 8;
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(DistancerResponse other) {
      if (other == null) {
        return;
      }
      if (other.Distance != 0D) {
        Distance = other.Distance;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(pb::CodedInputStream input) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      input.ReadRawMessage(this);
    #else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 9: {
            Distance = input.ReadDouble();
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 9: {
            Distance = input.ReadDouble();
            break;
          }
        }
      }
    }
    #endif

  }

  #endregion

}

#endregion Designer generated code
