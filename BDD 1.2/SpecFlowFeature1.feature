Feature: SpecFlowFeature1
	In order to check an acess to the Yadex.Market
	As a User
	I want to open the main page of Yandex.Market


	Scenario: Open the main page 
	Given I have opened "https://yandex.ru"
	When I click "Маркет"
	Then the Yandex.Market main page is presented
