# XP_Specflow_Selenium_Test_Example
This is a C Sharp Specflow test example using Selenium webdriver
To use this example, you need to install Specflow in your visual studugets to your project.

Before running the test, you need to make sure the Home.HTML in XP_BDD_1 project is running and use its URL in your test definition.

When your test runs successfuly, add below scenario to it and test again:

```C#
Scenario Outline: Example Scenario Outline
	Given I am on the home page
	When I enter '<text>' into the 'title' input field  
		And I click the 'submit' control
	Then '<text>' should be displayed in the 'results' field

	Examples:
		| text                  |
		| hello world           |
		| good morning sunshine |
		| HELLO XP Students     |
```