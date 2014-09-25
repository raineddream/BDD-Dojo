Feature: Valet Parking
	The parking lot calculator calculates costs for Valet Parking.

Scenario Outline: Calculate Valet Parking Cost
	When I park my car in the Valet Parking Lot for <Parking Duration>
	Then I will have to pay $<Parking Costs>

Examples: 
		| Parking Duration | Parking Costs |
		| 30 minutes       | 12.00         |
		| 3 hours          | 12.00         |
		| 5 hours          | 12.00         |
		| 5 hours 1 minute | 18.00         |
		| 12 hours         | 18.00         |
		| 24 hours         | 18.00         |
		| 1 day 1 minute   | 36.00         |