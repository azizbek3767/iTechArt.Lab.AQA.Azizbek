Feature: AddToCart

This test tests the add to cart function of saucedemo website

Scenario: Add to cart
	Given Open website
	And Log in to website
	When Added an item to cart
	Then Item should be added to cart
