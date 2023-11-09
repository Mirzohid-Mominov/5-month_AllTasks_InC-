using Microsoft.Extensions.DependencyInjection;
using VerificationCode.Services;
using VerificationCode.Models;

var services = new ServiceCollection();

services.AddDataProtection();
services.AddSingleton<VerificationCodeGeneratorService>();
services.AddSingleton<VerificationTokenGeneratorService>();
services.AddSingleton<QrCodeGeneratorService>();

var provider = services.BuildServiceProvider();

var verificationTokenGeneratorService = provider.GetRequiredService<VerificationTokenGeneratorService>();
var verificationCodeGeneratorService = provider.GetRequiredService<VerificationCodeGeneratorService>() as VerificationCodeGeneratorService;

var userId = Guid.Parse("E195382C-C038-42AF-9AF9-704CA3A3C7F1");
var testVerificationCode =
    "CfDJ8CC8yvMGmNxImzwwMDkGZXfmokNIFgRNxZ33bM5MOtYUZR-iF07rpsVYnSsS877L8J7Rh8MejwWZUKTPvlMLGO5ndf7cY9eygIf8LTVyv_YGsG4KALnh1LdHlmz0DzTW7pwoVRpN4Amqjft7cEYs-VO7W37N-DlNBFO8nP2asz7aQOkbwts8KOj7N0V6uxZmLRDv-YbBNmCllR_OF_a03nx5oLsur21y7beGnFgAFip_4jxPeMZAKiuqoTd-SJ4NCg";

var verificationCode = verificationCodeGeneratorService.Generate;
var verificationToken = verificationTokenGeneratorService.Generate(userId, VerificationType.Email, DateTimeOffset.UtcNow.AddMinutes(5));
var testVerificationModel = verificationTokenGeneratorService.Decrypt(testVerificationCode);

Console.WriteLine(verificationCode);
Console.WriteLine(verificationToken);

Console.WriteLine("Frontend link example : " + $"https:example.com/verify?verificationToken={verificationCode}");
Console.WriteLine("Frontend link example : " + $"https:example.com/verify?verificationToken={verificationToken}");

Console.WriteLine("Backend link example : " + $"https:example.com/api/accounts/{userId}/emails/verification/{verificationCode}");
Console.WriteLine("Backend link example : " + $"https:example.com/api/accounts/verification/{verificationToken}");

var qrCodeGeneratorService = provider.GetRequiredService<QrCodeGeneratorService>();

qrCodeGeneratorService.Generate(verificationCode);
qrCodeGeneratorService.Generate(verificationToken);
qrCodeGeneratorService.Generate($"https:example.com/api/accounts/{userId}/emails/verification/{verificationToken}");





