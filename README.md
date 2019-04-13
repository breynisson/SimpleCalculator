# SimpleCalculator

A super-simple calculator that takes two numbers and adds them.

The SimpleCalculator can be found at:
[https://breynisson-simple-calc.azurewebsites.net](https://breynisson-simple-calc.azurewebsites.net)


### Why?
This is an exercise. The requirements were:
> Source code for a solution for a simple calculator where two numbers between 0 and 9 are added.

In this solution, the two numbers are not limited to being between 0 and 9, but rather can be an arbitrary integer
or a float value. If we were to enforce the 0-9 requirement, we would have to put in guard clauses on the allowed values,
along with messages to the user if the values are out of range.


### How?
As there was no hard requirement on how this Calculator should work, one of decisions to be made was what kind
of User Interface we wanted on the calculator. A simple command-line tool, a stand-alone executable
with some-kind of graphical user interface, or a web-app?

We choose the web-based approach. There is good tooling for deploying web-based apps, so it seemed like a good
choice.

### Implementation
The project is a ASP.NET Core Web application, with an Index page which has two input fields and
a Calculate button. The input values are bound to float properties and the result of the additon is
bound to a label field on post. As simple as it gets.

The solution consists three projects:
<pre>
├── Calculator
├── Calculator.TestAutomation
├── Calculator.Tests
├── Calculator.sln
├── Calculator.sln.DotSettings.user
└── README.md
</pre>
Calculator is the web-based project, while Calculator.Tests and Calculator.TestAutomation consists of code for testing.

While splitting the testing code into two project is overkill for such a simple project, we do it here as an example of
how we might structure the testing-framework for a more complex project.

### Testing
In the Calculator.Tests project, we have a UnitTest.cs file, and a CalcAddWebTests.cs file. The naming of the first file
tells us which kind of tests we find there. There are two super-simple unit-tests, which, one might argue are more for 
demonstration purposes, since we are testing if addition works.

The CalcAddWebTests.cs file is holds the end-to-end tests, which are run using [Selenium](https://www.seleniumhq.org).
The CalcAddWebTests Class in this file has higher level abstraction of the web-tests, while the Selenium implementation
details are kept in the Calculator.TestAutomation project.

### Deployment
A CI loop has been setup with Azure App Services, so that a new version is deployed on each commit or
pull request to the master branch. 

The tests are currently not hooked up the the CI loop. We took a quick look at using [Appveyor](https://appveyor.com)
to run the test test in the CI loop, but we ran into problems that seemed to be related to .NET Core versions
used, so this exercise was shelved for now.  