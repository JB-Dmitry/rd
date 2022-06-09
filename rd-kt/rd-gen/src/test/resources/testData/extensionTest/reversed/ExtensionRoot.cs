//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a RdGen v1.10.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using JetBrains.Annotations;

using JetBrains.Core;
using JetBrains.Diagnostics;
using JetBrains.Collections;
using JetBrains.Collections.Viewable;
using JetBrains.Lifetimes;
using JetBrains.Serialization;
using JetBrains.Rd;
using JetBrains.Rd.Base;
using JetBrains.Rd.Impl;
using JetBrains.Rd.Tasks;
using JetBrains.Rd.Util;
using JetBrains.Rd.Text;


// ReSharper disable RedundantEmptyObjectCreationArgumentList
// ReSharper disable InconsistentNaming
// ReSharper disable RedundantOverflowCheckingContext


namespace ExtensionRoot
{
  
  
  /// <summary>
  /// <p>Generated from: Extension.kt:11</p>
  /// </summary>
  public class ExtensionRoot : RdExtBase
  {
    //fields
    //public fields
    
    //private fields
    //primary constructor
    private ExtensionRoot(
    )
    {
    }
    //secondary constructor
    //deconstruct trait
    //statics
    
    
    
    protected override long SerializationHash => -8799809714061118005L;
    
    protected override Action<ISerializers> Register => RegisterDeclaredTypesSerializers;
    public static void RegisterDeclaredTypesSerializers(ISerializers serializers)
    {
      
      serializers.RegisterToplevelOnce(typeof(ExtensionRoot), ExtensionRoot.RegisterDeclaredTypesSerializers);
    }
    
    public ExtensionRoot(Lifetime lifetime, IProtocol protocol) : this()
    {
      Identify(protocol.Identities, RdId.Root.Mix("ExtensionRoot"));
      Bind(lifetime, protocol, "ExtensionRoot");
    }
    
    //constants
    
    //custom body
    //methods
    //equals trait
    //hash code trait
    //pretty print
    public override void Print(PrettyPrinter printer)
    {
      printer.Println("ExtensionRoot (");
      printer.Print(")");
    }
    //toString
    public override string ToString()
    {
      var printer = new SingleLinePrettyPrinter();
      Print(printer);
      return printer.ToString();
    }
  }
  
  
  /// <summary>
  /// <p>Generated from: Extension.kt:23</p>
  /// </summary>
  public sealed class ClassWithStr : RdBindableBase
  {
    //fields
    //public fields
    [CanBeNull] public string ExtFromClass1 {get; private set;}
    public int ExtFromClass2 => _ExtFromClass2;
    [CanBeNull] public LocalizedString ExtFromClass3 => _ExtFromClass3;
    [NotNull] public string ReallyStrFromClass {get; private set;}
    
    //private fields
    private readonly int _ExtFromClass2;
    [CanBeNull] private readonly LocalizedString _ExtFromClass3;
    
    //primary constructor
    public ClassWithStr(
      [CanBeNull] string extFromClass1,
      int extFromClass2,
      [CanBeNull] LocalizedString extFromClass3,
      [NotNull] string reallyStrFromClass
    )
    {
      if (extFromClass1 == null) throw new ArgumentNullException("extFromClass1");
      if (extFromClass2 == null) throw new ArgumentNullException("extFromClass2");
      if (extFromClass3 == null) throw new ArgumentNullException("extFromClass3");
      if (reallyStrFromClass == null) throw new ArgumentNullException("reallyStrFromClass");
      
      ExtFromClass1 = extFromClass1;
      _ExtFromClass2 = extFromClass2;
      _ExtFromClass3 = extFromClass3;
      ReallyStrFromClass = reallyStrFromClass;
    }
    //secondary constructor
    //deconstruct trait
    //statics
    
    public static CtxReadDelegate<ClassWithStr> Read = (ctx, reader) => 
    {
      var _id = RdId.Read(reader);
      var extFromClass1 = ReadStringNullable(ctx, reader);
      var extFromClass2 = Int.Parse(ReadStringNullable(ctx, reader));
      var extFromClass3 = SomeFactory(ReadStringNullable(ctx, reader));
      var reallyStrFromClass = reader.ReadString();
      var _result = new ClassWithStr(extFromClass1, extFromClass2, extFromClass3, reallyStrFromClass).WithId(_id);
      return _result;
    };
    
    public static CtxWriteDelegate<ClassWithStr> Write = (ctx, writer, value) => 
    {
      value.RdId.Write(writer);
      WriteStringNullable(ctx, writer, value.ExtFromClass1);
      WriteStringNullable(ctx, writer, value._ExtFromClass2);
      WriteStringNullable(ctx, writer, value._ExtFromClass3.Delegate);
      writer.Write(value.ReallyStrFromClass);
    };
    
    //constants
    
    //custom body
    //methods
    //equals trait
    //hash code trait
    //pretty print
    public override void Print(PrettyPrinter printer)
    {
      printer.Println("ClassWithStr (");
      using (printer.IndentCookie()) {
        printer.Print("extFromClass1 = "); ExtFromClass1.PrintEx(printer); printer.Println();
        printer.Print("extFromClass2 = "); _ExtFromClass2.PrintEx(printer); printer.Println();
        printer.Print("extFromClass3 = "); _ExtFromClass3.PrintEx(printer); printer.Println();
        printer.Print("reallyStrFromClass = "); ReallyStrFromClass.PrintEx(printer); printer.Println();
      }
      printer.Print(")");
    }
    //toString
    public override string ToString()
    {
      var printer = new SingleLinePrettyPrinter();
      Print(printer);
      return printer.ToString();
    }
  }
  
  
  /// <summary>
  /// <p>Generated from: Extension.kt:29</p>
  /// </summary>
  public sealed class StructWithStr : IPrintable, IEquatable<StructWithStr>
  {
    //fields
    //public fields
    [CanBeNull] public string ExtFromStruct1 {get; private set;}
    public int ExtFromStruct2 => _ExtFromStruct2;
    [CanBeNull] public LocalizedString ExtFromStruct3 => _ExtFromStruct3;
    [NotNull] public string ReallyStrFromStruct {get; private set;}
    
    //private fields
    private readonly int _ExtFromStruct2;
    [CanBeNull] private readonly LocalizedString _ExtFromStruct3;
    
    //primary constructor
    public StructWithStr(
      [CanBeNull] string extFromStruct1,
      int extFromStruct2,
      [CanBeNull] LocalizedString extFromStruct3,
      [NotNull] string reallyStrFromStruct
    )
    {
      if (extFromStruct1 == null) throw new ArgumentNullException("extFromStruct1");
      if (extFromStruct2 == null) throw new ArgumentNullException("extFromStruct2");
      if (extFromStruct3 == null) throw new ArgumentNullException("extFromStruct3");
      if (reallyStrFromStruct == null) throw new ArgumentNullException("reallyStrFromStruct");
      
      ExtFromStruct1 = extFromStruct1;
      _ExtFromStruct2 = extFromStruct2;
      _ExtFromStruct3 = extFromStruct3;
      ReallyStrFromStruct = reallyStrFromStruct;
    }
    //secondary constructor
    //deconstruct trait
    public void Deconstruct([CanBeNull] out string extFromStruct1, out int extFromStruct2, [CanBeNull] out LocalizedString extFromStruct3, [NotNull] out string reallyStrFromStruct)
    {
      extFromStruct1 = ExtFromStruct1;
      extFromStruct2 = _ExtFromStruct2;
      extFromStruct3 = _ExtFromStruct3;
      reallyStrFromStruct = ReallyStrFromStruct;
    }
    //statics
    
    public static CtxReadDelegate<StructWithStr> Read = (ctx, reader) => 
    {
      var extFromStruct1 = ReadStringNullable(ctx, reader);
      var extFromStruct2 = Int.Parse(ReadStringNullable(ctx, reader));
      var extFromStruct3 = SomeFactory(ReadStringNullable(ctx, reader));
      var reallyStrFromStruct = reader.ReadString();
      var _result = new StructWithStr(extFromStruct1, extFromStruct2, extFromStruct3, reallyStrFromStruct);
      return _result;
    };
    
    public static CtxWriteDelegate<StructWithStr> Write = (ctx, writer, value) => 
    {
      WriteStringNullable(ctx, writer, value.ExtFromStruct1);
      WriteStringNullable(ctx, writer, value._ExtFromStruct2);
      WriteStringNullable(ctx, writer, value._ExtFromStruct3.Delegate);
      writer.Write(value.ReallyStrFromStruct);
    };
    
    //constants
    
    //custom body
    //methods
    //equals trait
    public override bool Equals(object obj)
    {
      if (ReferenceEquals(null, obj)) return false;
      if (ReferenceEquals(this, obj)) return true;
      if (obj.GetType() != GetType()) return false;
      return Equals((StructWithStr) obj);
    }
    public bool Equals(StructWithStr other)
    {
      if (ReferenceEquals(null, other)) return false;
      if (ReferenceEquals(this, other)) return true;
      return Equals(ExtFromStruct1, other.ExtFromStruct1) && Equals(_ExtFromStruct2, other._ExtFromStruct2) && Equals(_ExtFromStruct3, other._ExtFromStruct3) && ReallyStrFromStruct == other.ReallyStrFromStruct;
    }
    //hash code trait
    public override int GetHashCode()
    {
      unchecked {
        var hash = 0;
        hash = hash * 31 + (ExtFromStruct1 != null ? ExtFromStruct1.GetHashCode() : 0);
        hash = hash * 31 + (_ExtFromStruct2 != null ? _ExtFromStruct2.GetHashCode() : 0);
        hash = hash * 31 + (_ExtFromStruct3 != null ? _ExtFromStruct3.GetHashCode() : 0);
        hash = hash * 31 + ReallyStrFromStruct.GetHashCode();
        return hash;
      }
    }
    //pretty print
    public void Print(PrettyPrinter printer)
    {
      printer.Println("StructWithStr (");
      using (printer.IndentCookie()) {
        printer.Print("extFromStruct1 = "); ExtFromStruct1.PrintEx(printer); printer.Println();
        printer.Print("extFromStruct2 = "); _ExtFromStruct2.PrintEx(printer); printer.Println();
        printer.Print("extFromStruct3 = "); _ExtFromStruct3.PrintEx(printer); printer.Println();
        printer.Print("reallyStrFromStruct = "); ReallyStrFromStruct.PrintEx(printer); printer.Println();
      }
      printer.Print(")");
    }
    //toString
    public override string ToString()
    {
      var printer = new SingleLinePrettyPrinter();
      Print(printer);
      return printer.ToString();
    }
  }
}
