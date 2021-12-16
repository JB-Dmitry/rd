//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a RdGen v1.09.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#ifndef DOCUMENT_GENERATED_H
#define DOCUMENT_GENERATED_H


#include "protocol/Protocol.h"
#include "types/DateTime.h"
#include "impl/RdSignal.h"
#include "impl/RdProperty.h"
#include "impl/RdList.h"
#include "impl/RdSet.h"
#include "impl/RdMap.h"
#include "base/ISerializersOwner.h"
#include "base/IUnknownInstance.h"
#include "serialization/ISerializable.h"
#include "serialization/Polymorphic.h"
#include "serialization/NullableSerializer.h"
#include "serialization/ArraySerializer.h"
#include "serialization/InternedSerializer.h"
#include "serialization/SerializationCtx.h"
#include "serialization/Serializers.h"
#include "ext/RdExtBase.h"
#include "task/RdCall.h"
#include "task/RdEndpoint.h"
#include "task/RdSymmetricCall.h"
#include "std/to_string.h"
#include "std/hash.h"
#include "std/allocator.h"
#include "util/enum.h"
#include "util/gen_util.h"

#include <cstring>
#include <cstdint>
#include <vector>
#include <ctime>

#include "thirdparty.hpp"
#include "instantiations_ExampleRootNova.h"

#include "ExampleModelNova/FooBar.Generated.h"
#include "ExampleModelNova/Completion.Generated.h"



#ifdef _MSC_VER
#pragma warning( push )
#pragma warning( disable:4250 )
#pragma warning( disable:4307 )
#pragma warning( disable:4267 )
#pragma warning( disable:4244 )
#pragma warning( disable:4100 )
#endif

/// <summary>
/// <p>Generated from: Example.kt:84</p>
/// </summary>
namespace org.example {

class Document : public rd::IPolymorphicSerializable, public rd::RdBindableBase {

private:
    // custom serializers

public:
    // constants

protected:
    // fields
    rd::Wrapper<FooBar> moniker_;
    rd::Wrapper<std::wstring> buffer_;
    rd::RdCall<std::wstring, int32_t, rd::Polymorphic<std::wstring>, rd::Polymorphic<int32_t>> andBackAgain_;
    rd::Wrapper<Completion> completion_;
    std::vector<uint8_t> arr1_;
    std::vector<std::vector<bool>> arr2_;
    

private:
    // initializer
    void initialize();

public:
    // primary ctor
    Document(rd::Wrapper<FooBar> moniker_, rd::Wrapper<std::wstring> buffer_, rd::RdCall<std::wstring, int32_t, rd::Polymorphic<std::wstring>, rd::Polymorphic<int32_t>> andBackAgain_, rd::Wrapper<Completion> completion_, std::vector<uint8_t> arr1_, std::vector<std::vector<bool>> arr2_);
    // secondary constructor
    Document(rd::Wrapper<FooBar> moniker_, rd::Wrapper<std::wstring> buffer_, std::vector<uint8_t> arr1_, std::vector<std::vector<bool>> arr2_);
    
    // default ctors and dtors
    
    Document() = delete;
    
    Document(Document &&) = default;
    
    Document& operator=(Document &&) = default;
    
    virtual ~Document() = default;
    
    // reader
    static Document read(rd::SerializationCtx& ctx, rd::Buffer & buffer);
    
    // writer
    void write(rd::SerializationCtx& ctx, rd::Buffer& buffer) const override;
    
    // virtual init
    void init(rd::Lifetime lifetime) const override;
    
    // identify
    void identify(const rd::Identities &identities, rd::RdId const &id) const override;
    
    // getters
    FooBar const & get_moniker() const;
    rd::Wrapper<std::wstring> const & get_buffer() const;
    rd::RdCall<std::wstring, int32_t, rd::Polymorphic<std::wstring>, rd::Polymorphic<int32_t>> const & get_andBackAgain() const;
    Completion const & get_completion() const;
    std::vector<uint8_t> const & get_arr1() const;
    std::vector<std::vector<bool>> const & get_arr2() const;
    
    // intern

private:
    // equals trait
    bool equals(rd::ISerializable const& object) const override;

public:
    // equality operators
    friend bool operator==(const Document &lhs, const Document &rhs);
    friend bool operator!=(const Document &lhs, const Document &rhs);
    // hash code trait
    // type name trait
    std::string type_name() const override;
    // static type name trait
    static std::string static_type_name();

private:
    // polymorphic to string
    std::string toString() const override;

public:
    // external to string
    friend std::string to_string(const Document & value);
};

}

#ifdef _MSC_VER
#pragma warning( pop )
#endif



#endif // DOCUMENT_GENERATED_H
