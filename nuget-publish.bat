msbuild /t:pack /p:Configuration=Release

cd .\Cmas.Backend.Infrastructure.Domain\bin\Release\

nuget push Cmas.Backend.Infrastructure.Domain.1.0.2.nupkg -Source http://cm-ylng-msk-04/nuget/nuget

pause