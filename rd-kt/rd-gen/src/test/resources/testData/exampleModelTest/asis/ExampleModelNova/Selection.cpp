//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a RdGen v1.11.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#include "Selection.Generated.h"



#ifdef _MSC_VER
#pragma warning( push )
#pragma warning( disable:4250 )
#pragma warning( disable:4307 )
#pragma warning( disable:4267 )
#pragma warning( disable:4244 )
#pragma warning( disable:4100 )
#endif

namespace org.example {
// companion
// constants
// initializer
void Selection::initialize()
{
}
// primary ctor
Selection::Selection(int32_t start_, int32_t end_, std::vector<int32_t> lst_, EnumSetTest enumSetTest_, rd::Wrapper<std::wstring> nls_field_) :
rd::IPolymorphicSerializable()
,start_(std::move(start_)), end_(std::move(end_)), lst_(std::move(lst_)), enumSetTest_(std::move(enumSetTest_)), nls_field_(std::move(nls_field_))
{
    initialize();
}
// secondary constructor
// default ctors and dtors
// reader
Selection Selection::read(rd::SerializationCtx& ctx, rd::Buffer & buffer)
{
    auto start_ = buffer.read_integral<int32_t>();
    auto end_ = buffer.read_integral<int32_t>();
    auto lst_ = buffer.read_array<std::vector, int32_t, rd::allocator<Int>>(
    [&ctx, &buffer]() mutable  
    { return buffer.read_integral<int32_t>(); }
    );
    auto enumSetTest_ = rd::Polymorphic<EnumSetTest>::read(ctx, buffer);
    auto nls_field_ = buffer.read_wstring();
    Selection res{std::move(start_), std::move(end_), std::move(lst_), std::move(enumSetTest_), std::move(nls_field_)};
    return res;
}
// writer
void Selection::write(rd::SerializationCtx& ctx, rd::Buffer& buffer) const
{
    buffer.write_integral(start_);
    buffer.write_integral(end_);
    buffer.write_array<std::vector, int32_t, rd::allocator<Int>>(lst_, 
    [&ctx, &buffer](int32_t const & it) mutable  -> void 
    { buffer.write_integral(it); }
    );
    rd::Polymorphic<EnumSetTest>::write(ctx, buffer, enumSetTest_);
    buffer.write_wstring(nls_field_);
}
// virtual init
// identify
// getters
int32_t const & Selection::get_start() const
{
    return start_;
}
int32_t const & Selection::get_end() const
{
    return end_;
}
std::vector<int32_t> const & Selection::get_lst() const
{
    return lst_;
}
EnumSetTest const & Selection::get_enumSetTest() const
{
    return enumSetTest_;
}
std::wstring const & Selection::get_nls_field() const
{
    return nls_field_;
}
// intern
// equals trait
bool Selection::equals(rd::ISerializable const& object) const
{
    auto const &other = dynamic_cast<Selection const&>(object);
    if (this == &other) return true;
    if (this->start_ != other.start_) return false;
    if (this->end_ != other.end_) return false;
    if (this->lst_ != other.lst_) return false;
    if (this->enumSetTest_ != other.enumSetTest_) return false;
    if (this->nls_field_ != other.nls_field_) return false;
    
    return true;
}
// equality operators
bool operator==(const Selection &lhs, const Selection &rhs) {
    if (lhs.type_name() != rhs.type_name()) return false;
    return lhs.equals(rhs);
}
bool operator!=(const Selection &lhs, const Selection &rhs){
    return !(lhs == rhs);
}
// hash code trait
size_t Selection::hashCode() const noexcept
{
    size_t __r = 0;
    __r = __r * 31 + (rd::hash<int32_t>()(get_start()));
    __r = __r * 31 + (rd::hash<int32_t>()(get_end()));
    __r = __r * 31 + (rd::contentDeepHashCode(get_lst()));
    __r = __r * 31 + (rd::hash<EnumSetTest>()(get_enumSetTest()));
    __r = __r * 31 + (rd::hash<std::wstring>()(get_nls_field()));
    return __r;
}
// type name trait
std::string Selection::type_name() const
{
    return "Selection";
}
// static type name trait
std::string Selection::static_type_name()
{
    return "Selection";
}
// polymorphic to string
std::string Selection::toString() const
{
    std::string res = "Selection\n";
    res += "\tstart = ";
    res += rd::to_string(start_);
    res += '\n';
    res += "\tend = ";
    res += rd::to_string(end_);
    res += '\n';
    res += "\tlst = ";
    res += rd::to_string(lst_);
    res += '\n';
    res += "\tenumSetTest = ";
    res += rd::to_string(enumSetTest_);
    res += '\n';
    res += "\tnls_field = ";
    res += rd::to_string(nls_field_);
    res += '\n';
    return res;
}
// external to string
std::string to_string(const Selection & value)
{
    return value.toString();
}
}

#ifdef _MSC_VER
#pragma warning( pop )
#endif

