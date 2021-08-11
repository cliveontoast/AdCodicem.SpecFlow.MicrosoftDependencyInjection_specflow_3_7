# AdCodicem.SpecFlow.MicrosoftDependencyInjection testing
Issue with specflow >= 3.7

Referencing nuget package specflow 3.7.13+

Running `dotnet test` is unsuccessful
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
  Failed AddTwoNumbers
  Error Message:
   Assembly Initialization method SpecFlowProject1_MSTestAssemblyHooks.AssemblyInitialize threw exception. System.MissingMethodException: System.MissingMethodException: Method not found: 'Void BoDi.ObjectContainer.RegisterTypeAs(System.String)'.. Aborting test execution.
  Stack Trace:
      at AdCodicem.SpecFlow.MicrosoftDependencyInjection.DependencyInjectionPlugin.<>c.<Initialize>b__3_0(Object _, CustomizeGlobalDependenciesEventArgs args)
   at TechTalk.SpecFlow.Plugins.RuntimePluginEvents.RaiseCustomizeGlobalDependencies(ObjectContainer container, SpecFlowConfiguration specFlowConfiguration)
   at TechTalk.SpecFlow.Infrastructure.ContainerBuilder.CreateGlobalContainer(Assembly testAssembly, IRuntimeConfigurationProvider configurationProvider)
   at TechTalk.SpecFlow.MSTest.SpecFlowPlugin.MsTestContainerBuilder.CreateGlobalContainer(Assembly testAssembly, IRuntimeConfigurationProvider configurationProvider)
   at TechTalk.SpecFlow.TestRunnerManager.CreateTestRunnerManager(Assembly testAssembly, IContainerBuilder containerBuilder)
   at TechTalk.SpecFlow.TestRunnerManager.GetTestRunnerManager(Assembly testAssembly, IContainerBuilder containerBuilder, Boolean createIfMissing)
   at TechTalk.SpecFlow.TestRunnerManager.OnTestRunStart(Assembly testAssembly, IContainerBuilder containerBuilder)
   at SpecFlowProject1_MSTestAssemblyHooks.AssemblyInitialize(TestContext testContext) in     \SpecFlowProject1\obj\Debug\netcoreapp3.1\MSTest.AssemblyHooks.cs:line 22

  Standard Output Messages:
 -> Loading plugin     \SpecFlowProject1\bin\Debug\netcoreapp3.1\AdCodicem.SpecFlow.MicrosoftDependencyInjection.SpecFlowPlugin.dll
 -> Loading plugin     \SpecFlowProject1\bin\Debug\netcoreapp3.1\TechTalk.SpecFlow.MSTest.SpecFlowPlugin.dll
 -> Loading plugin     \SpecFlowProject1\bin\Debug\netcoreapp3.1\SpecFlowProject1.dll
 -> Missing [assembly:RuntimePlugin] attribute in SpecFlowProject1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null. Please check https://go.specflow.org/doc-plugins for details.



Failed!  - Failed:     1, Passed:     0, Skipped:     0, Total:     1, Duration: 169 ms - SpecFlowProject1.dll (netcoreapp3.1)
```