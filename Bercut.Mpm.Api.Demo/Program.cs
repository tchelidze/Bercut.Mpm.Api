using System;
using System.Net;
using Bercut.Mpm.Api.Exceptions;
using Bercut.Mpm.Api.Operations;
using Bercut.Mpm.Api.Operations.Extensions;

namespace Bercut.Mpm.Api.Demo
{
    public class Program
    {
        static void Main(string[] args)
        {
            var bercutClient = new BercutMpmClient(opts =>
            {
                opts.Host = "https://u.u.u.u:u";
                opts.UserName = "u";
                opts.Password = "u";
            });

            Console.WriteLine("Enter the command");

            try
            {
                // In case you get InvalidBercutApiResponseException with ErrorMessage : `An error occurred while sending the request. A security error occurred` 

                ServicePointManager.SecurityProtocol =
                    SecurityProtocolType.Tls12
                    | SecurityProtocolType.Tls11
                    | SecurityProtocolType.Tls;

                ServicePointManager.ServerCertificateValidationCallback
                    = (sender, certificate, chain, sslPolicyErrors) => true;

                string cmd;
                while ((cmd = Console.ReadLine()) != "cancel")
                    switch (cmd.ToLower())
                    {
                        case "act7":
                            var response = bercutClient.Act7(new Act7.Request
                            {
                                Msisdn = "97933199"
                            }).Result;

                            Console.WriteLine("response is null " + (response == null));

                            Console.WriteLine($"Act7 response. " +
                                              $"StatusCode -> {response.StatusCode} "
                                              + $" Balance -> {(response.HasNumericValue() ? response.ParseBalance().ToString() : "Not a number")}"
                                              + $" Name -> {response.Name}"
                                              + $" PayAccount -> {response.PayAccount}"
                                              + $" TimeStamp -> {response.TimeStamp}"
                            );
                            break;

                        default:
                            Console.WriteLine($"{cmd} not supported.");
                            break;
                    }
            }
            catch (AggregateException ex)
            {
                Console.WriteLine("Several exception occured. ");

                for (var index = 0; index < ex.InnerExceptions.Count; index++)
                {
                    var innerException = ex.InnerExceptions[index];
                    var asInvalidBercutApiResponseException = innerException as InvalidBercutApiResponseException;

                    Console.WriteLine($"{index} -> " +
                                      $"Message : {innerException.Message} ." +
                                      $" {(asInvalidBercutApiResponseException != null ? $"InvalidHttpStatusCode {asInvalidBercutApiResponseException.InvalidHttpStatusCode} . ErrorMessage {asInvalidBercutApiResponseException.ErrorMessage}" : "")}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Unexpected error occured. Message : {ex}");
                Console.ReadKey();
            }
        }
    }
}