//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a RdGen v1.09.
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


namespace Org.TestRoot1
{
  
  
  /// <summary>
  /// <p>Generated from: FactoryFqnTestDataModel.kt:37</p>
  /// </summary>
  public class Solution2 : RdExtBase
  {
    //fields
    //public fields
    [NotNull] public IRdEndpoint<int, MyClass> Get => _Get;
    [NotNull] public IViewableProperty<string> Version => _Version;
    [NotNull] public IViewableProperty<RdDocumentModel> TestBuffer => _TestBuffer;
    [NotNull] public IViewableProperty<List<string>> String_list_prop => _String_list_prop;
    [NotNull] public IViewableProperty<string> Nls_prop => _Nls_prop;
    [NotNull] public IViewableProperty<List<string>> Nls_list_prop => _Nls_list_prop;
    [NotNull] public IViewableProperty<string> Nullable_nls_prop => _Nullable_nls_prop;
    [NotNull] public IViewableProperty<List<string>> Nullable_nls_list_prop => _Nullable_nls_list_prop;
    
    //private fields
    [NotNull] private readonly RdCall<int, MyClass> _Get;
    [NotNull] private readonly RdProperty<string> _Version;
    [NotNull] private readonly RdProperty<RdDocumentModel> _TestBuffer;
    [NotNull] private readonly RdProperty<List<string>> _String_list_prop;
    [NotNull] private readonly RdProperty<string> _Nls_prop;
    [NotNull] private readonly RdProperty<List<string>> _Nls_list_prop;
    [NotNull] private readonly RdProperty<string> _Nullable_nls_prop;
    [NotNull] private readonly RdProperty<List<string>> _Nullable_nls_list_prop;
    
    //primary constructor
    private Solution2(
      [NotNull] RdCall<int, MyClass> get,
      [NotNull] RdProperty<string> version,
      [NotNull] RdProperty<RdDocumentModel> testBuffer,
      [NotNull] RdProperty<List<string>> string_list_prop,
      [NotNull] RdProperty<string> nls_prop,
      [NotNull] RdProperty<List<string>> nls_list_prop,
      [NotNull] RdProperty<string> nullable_nls_prop,
      [NotNull] RdProperty<List<string>> nullable_nls_list_prop
    )
    {
      if (get == null) throw new ArgumentNullException("get");
      if (version == null) throw new ArgumentNullException("version");
      if (testBuffer == null) throw new ArgumentNullException("testBuffer");
      if (string_list_prop == null) throw new ArgumentNullException("string_list_prop");
      if (nls_prop == null) throw new ArgumentNullException("nls_prop");
      if (nls_list_prop == null) throw new ArgumentNullException("nls_list_prop");
      if (nullable_nls_prop == null) throw new ArgumentNullException("nullable_nls_prop");
      if (nullable_nls_list_prop == null) throw new ArgumentNullException("nullable_nls_list_prop");
      
      _Get = get;
      _Version = version;
      _TestBuffer = testBuffer;
      _String_list_prop = string_list_prop;
      _Nls_prop = nls_prop;
      _Nls_list_prop = nls_list_prop;
      _Nullable_nls_prop = nullable_nls_prop;
      _Nullable_nls_list_prop = nullable_nls_list_prop;
      _Version.OptimizeNested = true;
      _String_list_prop.OptimizeNested = true;
      _Nls_prop.OptimizeNested = true;
      _Nls_list_prop.OptimizeNested = true;
      _Nullable_nls_prop.OptimizeNested = true;
      _Nullable_nls_list_prop.OptimizeNested = true;
      _Version.ValueCanBeNull = true;
      _Nullable_nls_prop.ValueCanBeNull = true;
      BindableChildren.Add(new KeyValuePair<string, object>("get", _Get));
      BindableChildren.Add(new KeyValuePair<string, object>("version", _Version));
      BindableChildren.Add(new KeyValuePair<string, object>("testBuffer", _TestBuffer));
      BindableChildren.Add(new KeyValuePair<string, object>("string_list_prop", _String_list_prop));
      BindableChildren.Add(new KeyValuePair<string, object>("nls_prop", _Nls_prop));
      BindableChildren.Add(new KeyValuePair<string, object>("nls_list_prop", _Nls_list_prop));
      BindableChildren.Add(new KeyValuePair<string, object>("nullable_nls_prop", _Nullable_nls_prop));
      BindableChildren.Add(new KeyValuePair<string, object>("nullable_nls_list_prop", _Nullable_nls_list_prop));
    }
    //secondary constructor
    private Solution2 (
    ) : this (
      new RdCall<int, MyClass>(JetBrains.Rd.Impl.Serializers.ReadInt, JetBrains.Rd.Impl.Serializers.WriteInt, MyClass.Read, MyClass.Write),
      new RdProperty<string>(ReadStringNullable, WriteStringNullable),
      new RdProperty<RdDocumentModel>(RdDocumentModel.Read, RdDocumentModel.Write),
      new RdProperty<List<string>>(ReadStringList, WriteStringList),
      new RdProperty<string>(JetBrains.Rd.Impl.Serializers.ReadString, JetBrains.Rd.Impl.Serializers.WriteString),
      new RdProperty<List<string>>(ReadStringList, WriteStringList),
      new RdProperty<string>(ReadStringNullable, WriteStringNullable),
      new RdProperty<List<string>>(ReadStringNullableList, WriteStringNullableList)
    ) {}
    //deconstruct trait
    //statics
    
    public static CtxReadDelegate<string> ReadStringNullable = JetBrains.Rd.Impl.Serializers.ReadString.NullableClass();
    public static CtxReadDelegate<List<string>> ReadStringList = JetBrains.Rd.Impl.Serializers.ReadString.List();
    public static CtxReadDelegate<List<string>> ReadStringNullableList = JetBrains.Rd.Impl.Serializers.ReadString.NullableClass().List();
    
    public static  CtxWriteDelegate<string> WriteStringNullable = JetBrains.Rd.Impl.Serializers.WriteString.NullableClass();
    public static  CtxWriteDelegate<List<string>> WriteStringList = JetBrains.Rd.Impl.Serializers.WriteString.List();
    public static  CtxWriteDelegate<List<string>> WriteStringNullableList = JetBrains.Rd.Impl.Serializers.WriteString.NullableClass().List();
    
    protected override long SerializationHash => -7739621369434209029L;
    
    protected override Action<ISerializers> Register => RegisterDeclaredTypesSerializers;
    public static void RegisterDeclaredTypesSerializers(ISerializers serializers)
    {
      
      serializers.RegisterToplevelOnce(typeof(TestRoot1), TestRoot1.RegisterDeclaredTypesSerializers);
    }
    
    public Solution2(Lifetime lifetime, IProtocol protocol) : this()
    {
      Identify(protocol.Identities, RdId.Root.Mix("Solution2"));
      Bind(lifetime, protocol, "Solution2");
    }
    
    //constants
    
    //custom body
    //methods
    //equals trait
    //hash code trait
    //pretty print
    public override void Print(PrettyPrinter printer)
    {
      printer.Println("Solution2 (");
      using (printer.IndentCookie()) {
        printer.Print("get = "); _Get.PrintEx(printer); printer.Println();
        printer.Print("version = "); _Version.PrintEx(printer); printer.Println();
        printer.Print("testBuffer = "); _TestBuffer.PrintEx(printer); printer.Println();
        printer.Print("string_list_prop = "); _String_list_prop.PrintEx(printer); printer.Println();
        printer.Print("nls_prop = "); _Nls_prop.PrintEx(printer); printer.Println();
        printer.Print("nls_list_prop = "); _Nls_list_prop.PrintEx(printer); printer.Println();
        printer.Print("nullable_nls_prop = "); _Nullable_nls_prop.PrintEx(printer); printer.Println();
        printer.Print("nullable_nls_list_prop = "); _Nullable_nls_list_prop.PrintEx(printer); printer.Println();
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
  /// <p>Generated from: FactoryFqnTestDataModel.kt:49</p>
  /// </summary>
  public sealed class MyClass : RdBindableBase
  {
    //fields
    //public fields
    [NotNull] public IViewableSet<string> MySet => _MySet;
    
    //private fields
    [NotNull] private readonly RdSet<string> _MySet;
    
    //primary constructor
    private MyClass(
      [NotNull] RdSet<string> mySet
    )
    {
      if (mySet == null) throw new ArgumentNullException("mySet");
      
      _MySet = mySet;
      _MySet.OptimizeNested = true;
      BindableChildren.Add(new KeyValuePair<string, object>("mySet", _MySet));
    }
    //secondary constructor
    public MyClass (
    ) : this (
      new RdSet<string>(JetBrains.Rd.Impl.Serializers.ReadString, JetBrains.Rd.Impl.Serializers.WriteString)
    ) {}
    //deconstruct trait
    //statics
    
    public static CtxReadDelegate<MyClass> Read = (ctx, reader) => 
    {
      var _id = RdId.Read(reader);
      var mySet = RdSet<string>.Read(ctx, reader, JetBrains.Rd.Impl.Serializers.ReadString, JetBrains.Rd.Impl.Serializers.WriteString);
      var _result = new MyClass(mySet).WithId(_id);
      return _result;
    };
    
    public static CtxWriteDelegate<MyClass> Write = (ctx, writer, value) => 
    {
      value.RdId.Write(writer);
      RdSet<string>.Write(ctx, writer, value._MySet);
    };
    
    //constants
    
    //custom body
    //methods
    //equals trait
    //hash code trait
    //pretty print
    public override void Print(PrettyPrinter printer)
    {
      printer.Println("MyClass (");
      using (printer.IndentCookie()) {
        printer.Print("mySet = "); _MySet.PrintEx(printer); printer.Println();
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
  /// <p>Generated from: FactoryFqnTestDataModel.kt:39</p>
  /// </summary>
  public sealed class RdDocumentModel : RdBindableBase
  {
    //fields
    //public fields
    [NotNull] public JetBrains.Rd.Text.Impl.RdTextBuffer Text => _Text;
    [NotNull] public string Nls_field {get; private set;}
    [CanBeNull] public string Nullable_nls_field {get; private set;}
    [NotNull] public List<string> String_list_field {get; private set;}
    [NotNull] public List<string> Nls_list_field {get; private set;}
    
    //private fields
    [NotNull] private readonly JetBrains.Rd.Text.Impl.RdTextBuffer _Text;
    
    //primary constructor
    private RdDocumentModel(
      [NotNull] JetBrains.Rd.Text.Impl.RdTextBuffer text,
      [NotNull] string nls_field,
      [CanBeNull] string nullable_nls_field,
      [NotNull] List<string> string_list_field,
      [NotNull] List<string> nls_list_field
    )
    {
      if (text == null) throw new ArgumentNullException("text");
      if (nls_field == null) throw new ArgumentNullException("nls_field");
      if (string_list_field == null) throw new ArgumentNullException("string_list_field");
      if (nls_list_field == null) throw new ArgumentNullException("nls_list_field");
      
      _Text = text;
      Nls_field = nls_field;
      Nullable_nls_field = nullable_nls_field;
      String_list_field = string_list_field;
      Nls_list_field = nls_list_field;
      BindableChildren.Add(new KeyValuePair<string, object>("text", _Text));
    }
    //secondary constructor
    public RdDocumentModel (
      [NotNull] string nls_field,
      [CanBeNull] string nullable_nls_field,
      [NotNull] List<string> string_list_field,
      [NotNull] List<string> nls_list_field
    ) : this (
      JetBrains.Rd.Text.Impl.RdTextBuffer.CreateByFactory(new JetBrains.Rd.Text.Impl.Intrinsics.RdTextBufferState()),
      nls_field,
      nullable_nls_field,
      string_list_field,
      nls_list_field
    ) {}
    //deconstruct trait
    //statics
    
    public static CtxReadDelegate<RdDocumentModel> Read = (ctx, reader) => 
    {
      var _id = RdId.Read(reader);
      var text = JetBrains.Rd.Text.Impl.RdTextBuffer.CreateByFactory(JetBrains.Rd.Text.Impl.Intrinsics.RdTextBufferState.Read(ctx, reader));
      var nls_field = reader.ReadString();
      var nullable_nls_field = ReadStringNullable(ctx, reader);
      var string_list_field = ReadStringList(ctx, reader);
      var nls_list_field = ReadStringList(ctx, reader);
      var _result = new RdDocumentModel(text, nls_field, nullable_nls_field, string_list_field, nls_list_field).WithId(_id);
      return _result;
    };
    public static CtxReadDelegate<string> ReadStringNullable = JetBrains.Rd.Impl.Serializers.ReadString.NullableClass();
    public static CtxReadDelegate<List<string>> ReadStringList = JetBrains.Rd.Impl.Serializers.ReadString.List();
    
    public static CtxWriteDelegate<RdDocumentModel> Write = (ctx, writer, value) => 
    {
      value.RdId.Write(writer);
      JetBrains.Rd.Text.Impl.Intrinsics.RdTextBufferState.Write(ctx, writer, value._Text.Delegate);
      writer.Write(value.Nls_field);
      WriteStringNullable(ctx, writer, value.Nullable_nls_field);
      WriteStringList(ctx, writer, value.String_list_field);
      WriteStringList(ctx, writer, value.Nls_list_field);
    };
    public static  CtxWriteDelegate<string> WriteStringNullable = JetBrains.Rd.Impl.Serializers.WriteString.NullableClass();
    public static  CtxWriteDelegate<List<string>> WriteStringList = JetBrains.Rd.Impl.Serializers.WriteString.List();
    
    //constants
    
    //custom body
    //methods
    //equals trait
    //hash code trait
    //pretty print
    public override void Print(PrettyPrinter printer)
    {
      printer.Println("RdDocumentModel (");
      using (printer.IndentCookie()) {
        printer.Print("text = "); _Text.PrintEx(printer); printer.Println();
        printer.Print("nls_field = "); Nls_field.PrintEx(printer); printer.Println();
        printer.Print("nullable_nls_field = "); Nullable_nls_field.PrintEx(printer); printer.Println();
        printer.Print("string_list_field = "); String_list_field.PrintEx(printer); printer.Println();
        printer.Print("nls_list_field = "); Nls_list_field.PrintEx(printer); printer.Println();
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
