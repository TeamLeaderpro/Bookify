﻿using Bookify.Domain.Abstractions;
using Bookify.Domain.Apartments.Enums;
using Bookify.Domain.Apartments.ValueObjects;

namespace Bookify.Domain.Apartments;

public sealed class Apartment : Entity
{ 
    public Name Name { get;private set; }
    public Description Description { get;private set; }
    public Address Address { get;private set; }
    public Money Price { get;private set; }
    public Money CleaningFee { get;private set; }
    public DateTime? LastTimeBookedOnUtc { get;private set; }
    public List<Amenity> Amenities { get; private set; } = [];

    public Apartment(
        Guid id,
        Name name,
        Description description,
        Address address,
        Money price,
        Money cleaningFee,
        DateTime? lastTimeBookedOnUtc,
        List<Amenity> amenities) 
        : base(id)
    {
        Name = name;
        Description = description;
        Address = address;
        Price = price;
        CleaningFee = cleaningFee;
        LastTimeBookedOnUtc = lastTimeBookedOnUtc;
        Amenities = amenities;
    }
}