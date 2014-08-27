Feature: Valet Parking
	The parking lot calculator calculates costs for Valet Parking.

Scenario Outline: Calculate Valet Parking Cost for half an hour
	When I park my car in the Valet Parking Lot for <Parking Duration>
	Then I will have to pay $<Parking Costs>

Examples: 
		| Parking Duration | Parking Costs |
		| 30 minutes       | 12.00         |
		| 1 hour           | 2.00          |
