Feature: Login

This feature tests a successful login to saucedemo.com with valid credentials

Scenario: Login to Saucedemo
	Given Open a website
	And Fill in the form
	And Submit the form
	Then User should be logged in successfully
	And Get redirected to the Main Page
	And Quit browser