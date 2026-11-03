using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Encodings.Web;
using System.Text.Json;

Console.OutputEncoding = System.Text.Encoding.UTF8;

string json = File.ReadAllText("books.json");

List<Book> books = JsonSerializer.Deserialize<List<Book>>(json) ?? new List<Book>(); 

foreach (Book book in books)
{
    Console.WriteLine($"Книга: {book.Title}");
    Console.WriteLine($"Видавництво: {book.PublishingHouse.Name}");
    Console.WriteLine();
}

string result = JsonSerializer.Serialize(
    books,
    new JsonSerializerOptions
    {
        WriteIndented = true,
        Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping
    }
);

Console.WriteLine(result);