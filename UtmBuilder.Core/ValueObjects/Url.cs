using UtmBuilder.Core.ValueObjects.Exceptions;
using UtmBuilder.Core.ValueObjects.Shared;

namespace UtmBuilder.Core.ValueObjects;
public class Url : ValueObject
{
    public Url(string address)
    {
        Address = address;
        InvalidUrlException.ThrowIfInvalid(address);
    }

    public string Address { get; private set; }
}