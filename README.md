# Bercut.Mpm.Api

Bercut Mobile Payment Module .NET Client

# [Nuget](https://www.nuget.org/packages/Bercut.Mpm.Api/)

```
PM> Install-Package Bercut.Mpm.Api -Version 1.0.0
```

# Usage 

- Create `BercutMpmClient` with necessary configuration

```
var bercutClient = new BercutMpmClient(opts =>
{
    opts.Host = "https://u.u.u.u:u";
    opts.UserName = "u";
    opts.Password = "u";
});
```
- Invoke desired API method
```
var response = await bercutClient.Act7(new Act7.Request { Msisdn = "97933199" });
```

If you get **InvalidBercutApiResponseException** with
Message :  `An error occurred while sending the request. A security error occurred`,
then add following before invoking API

```
 ServicePointManager.SecurityProtocol =
                    SecurityProtocolType.Tls12
                    | SecurityProtocolType.Tls11
                    | SecurityProtocolType.Tls;

ServicePointManager.ServerCertificateValidationCallback
                    = (sender, certificate, chain, sslPolicyErrors) => true;
```
