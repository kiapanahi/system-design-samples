@ECHO OFF
SETLOCAL

:: This command launches a Visual Studio solution with environment variables required to use a local version of the .NET Core SDK.

SET PATH=%PATH%

SET sln=%~1

IF "%sln%"=="" (
    SET sln=%~dp0SystemDesign.sln
)

start "" "%sln%"