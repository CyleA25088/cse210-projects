class Address
{
    private string _street;
    private string _city;
    private string _stateOrProvince;
    private string _country;

    public Address(string streetAddress, string city, string stateOrProvince, string country)
    {
        _street = streetAddress;
        _city = city;
        _stateOrProvince = stateOrProvince;
        _country = country;
    }

    public bool IsUS()
    {
        return _country.ToLower() == "usa" || _country.ToLower() == "united states" || _country.ToLower() == "united states of america";
    }

    public string GetAddressInfo()
    {
        return $"{_street}\n{_city}, {_stateOrProvince}\n{_country}";
    }
}