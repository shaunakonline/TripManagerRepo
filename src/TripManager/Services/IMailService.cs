using System;

namespace TripManager.Services
{
  public interface IMailService
  {
    bool SendMail(string to, string from, string subject, string body);
  }
}
