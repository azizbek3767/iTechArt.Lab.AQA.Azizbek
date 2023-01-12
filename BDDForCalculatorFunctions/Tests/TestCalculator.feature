Feature: TestCalculator

This test feature tests sum, suctraction, multiplication, division functions of calculator

Scenario: Check Sum
	Given Calculator class
	And I have the first number 10
	And I have the second number 20
	When I want to sum those numbers
	Then The result should be 30

Scenario: Check Subtraction
	Given Calculator class
	And I have the first number 10
	And I have the second number 20
	When I want to subtract those numbers
	Then The result should be -10

Scenario: Check Multiplication
	Given Calculator class
	And I have the first number 10
	And I have the second number 20
	When I want to multiply those numbers
	Then The result should be 200

Scenario: Check Division
	Given Calculator class
	And I have the first number 10
	And I have the second number 5
	When I want to divide those numbers
	Then The result should be 2