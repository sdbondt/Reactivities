using System;

namespace Application.Core;

public class AppException(int statuscode, string message, string? details)
{
    public int StatusCode { get; set; } = statuscode;
    public string Message { get; set; } = message;
    public string? details { get; set; } = details;
}
