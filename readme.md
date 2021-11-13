# Instructions

## Getting started with Stryker.NET
For the purpose of this demo two projects have been created: class library called Math and MSTest project called Math.Tests. Both with .NET Core 3.1.

## Installing Stryker.NET
First of all we need to create tool manifest for Math solution by running below command in the root folder 

dotnet new tool-manifest

It should result with new folder being created called .config containing dotnet-tools.json file. When it is done, the actual Stryker.NET installation can be run with below command.

dotnet tool install dotnet-stryker

Successful installation should result with appropriate message in command line and also new entry in the manifest file.

Now, we’re good to go with below command which runs mutation tests. It should be executed in the test project path 

dotnet stryker

Stryker.NET automatically identifies projects to mutate based on references added to test project. As the Math has no content yet, there is nothing to mutate, so the Stryker ends with warning message “It’s a mutant-free world, nothing to test”.

After added some code and test; We’ll analyse it on the report though, which has been generated in HTML format (mutation-report.html).

After opening the report we can see a summary of all mutated files with details like mutation score (the higher is better), number of killed and survived mutants, timeouts, no coverage and ignored code and also runtime and compile errors.

Seed taken from http://csharp.academy/mutation-testing/

