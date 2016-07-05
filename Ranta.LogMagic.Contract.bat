msbuild Ranta.LogMagic.Contract.Net40\Ranta.LogMagic.Contract.Net40.csproj /t:rebuild /p:configuration=release;DocumentationFile=bin\Release\Ranta.LogMagic.Contract.xml;DebugType=none

msbuild Ranta.LogMagic.Contract.Net45\Ranta.LogMagic.Contract.Net45.csproj /t:rebuild /p:configuration=release;DocumentationFile=bin\Release\Ranta.LogMagic.Contract.xml;DebugType=none

nuget pack Ranta.LogMagic.Contract.nuspec

pause