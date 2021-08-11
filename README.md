# AdCodicem.SpecFlow.MicrosoftDependencyInjection testing
Issue with specflow >= 3.7

Referencing nuget package specflow 3.6.23

Running `dotnet test` is successful
```
> dotnet test
  Determining projects to restore...
  Restored \SpecFlowProject1\SpecFlowProject1.csproj (in 420 ms).
  1 of 2 projects are up-to-date for restore.
  SpecFlowFeatureFiles: Features\Calculator.feature
-> Using default config
  SpecFlowGeneratedFiles: Features\Calculator.feature.cs
  MsInjectionSite31 -> \MsInjectionSite31\bin\Debug\netcoreapp3.1\MsInjectionSite31.dll
  SpecFlowProject1 -> \SpecFlowProject1\bin\Debug\netcoreapp3.1\SpecFlowProject1.dll
Test run for \SpecFlowProject1\bin\Debug\netcoreapp3.1\SpecFlowProject1.dll (.NETCoreApp,Version=v3.1)
Microsoft (R) Test Execution Command Line Tool Version 16.10.0
Copyright (c) Microsoft Corporation.  All rights reserved.

Starting test execution, please wait...
A total of 1 test files matched the specified pattern.

Passed!  - Failed:     0, Passed:     1, Skipped:     0, Total:     1, Duration: 556 ms - SpecFlowProject1.dll (netcoreapp3.1)
```