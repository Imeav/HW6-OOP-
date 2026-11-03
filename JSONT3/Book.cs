using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

public class Book
{
    [JsonIgnore]
    public int PublishingHouseId { get; set; }

    [JsonPropertyName("Name")]
    public string Title { get; set; } = "";


    public PublishingHouse PublishingHouse { get; set; } = new();
}
